using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.SubjectManagerment
{
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            this.ShowSubjectList();
        }

        private void ShowSubjectList()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.monhocs.ToList();
            this.lstSubject.DataSource = list;
            this.lstSubject.Columns["monhoc_id"].Visible = false;
            this.lstSubject.Columns["ketquahoctaps"].Visible = false;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            var form = new FormAddSubject();
            form.ShowDialog();
            this.ShowSubjectList();
        }

        private void lstSubject_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSubject.SelectedRows.Count == 1)
            {
                var row = this.lstSubject.SelectedRows[0];
                var item = (monhoc)row.DataBoundItem;

                var form = new FormEditSubject(item);
                form.ShowDialog();
                this.ShowSubjectList();
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            if (MessageBox.Show("Bạn có muốn xóa Môn học này không ?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lstSubject.SelectedRows.Count; i++)
                {
                    var row = this.lstSubject.SelectedRows[i];
                    var item = (monhoc)row.DataBoundItem;
                    try
                    {
                        monhoc MonHoc = db.monhocs.Find(item.monhoc_id);
                        db.monhocs.Remove(MonHoc);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa Môn học này!");
                    }
                }
            }
            this.ShowSubjectList();
        }
    }
}
