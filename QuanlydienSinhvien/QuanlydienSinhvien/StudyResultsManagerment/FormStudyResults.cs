using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.StudyResultsManagerment
{
    public partial class FormStudyResults : Form
    {
        public FormStudyResults()
        {
            InitializeComponent();
        }

        private void FormStudyResults_Load(object sender, EventArgs e)
        {
            this.ShowStudyResults();
        }

        private void ShowStudyResults()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.ketquahoctaps.ToList();
            this.lstStudyResults.DataSource = list;
            this.lstStudyResults.Columns["kqht_id"].Visible = false;
            this.lstStudyResults.Columns["lophoc_id"].Visible = false;
            this.lstStudyResults.Columns["monhoc_id"].Visible = false;
            this.lstStudyResults.Columns["hocki_id"].Visible = false;
            this.lstStudyResults.Columns["hocky"].Visible = false;
            this.lstStudyResults.Columns["lophoc"].Visible = false;
        }

        private void btnAddStudyResults_Click(object sender, EventArgs e)
        {
            var form = new FormAddStudyResults();
            form.ShowDialog();
            this.ShowStudyResults();
        }

        private void lstStudyResults_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstStudyResults.SelectedRows.Count == 1)
            {
                var row = this.lstStudyResults.SelectedRows[0];
                var item = (ketquahoctap)row.DataBoundItem;
                var form = new FormEditStudyResults(item);
                form.ShowDialog();
                this.ShowStudyResults();
            }
        }

        private void btnDeleteStudyResults_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.lstStudyResults.SelectedRows.Count; i++)
                {
                    var row = this.lstStudyResults.SelectedRows[i];
                    var item = (ketquahoctap)row.DataBoundItem;

                    try
                    {
                        ketquahoctap KetQuaHocTap = db.ketquahoctaps.Find(item.kqht_id);
                        db.ketquahoctaps.Remove(KetQuaHocTap);
                        db.SaveChanges();
                        MessageBox.Show("Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
            }
            this.ShowStudyResults();
        }
    }
}
