using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.ClassManagerment
{
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            this.ShowClassList();
            this.lstClass.Columns["lophoc_id"].Visible = false;
        }

        private void ShowClassList()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.lophocs.ToList();
            this.lstClass.DataSource = list;
            this.lstClass.Columns["ketquahoctaps"].Visible = false;
            this.lstClass.Columns["sinhviens"].Visible = false;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var form = new FormAddClass();
            form.ShowDialog();
            this.ShowClassList();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            if (MessageBox.Show("Bạn có muốn xóa ?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lstClass.SelectedRows.Count; i++)
                {
                    var row = this.lstClass.SelectedRows[i];
                    var item = (lophoc)row.DataBoundItem;
                    try
                    {
                        lophoc lop = db.lophocs.Find(item.lophoc_id);
                        db.lophocs.Remove(lop);
                        db.SaveChanges();
                        MessageBox.Show("Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
            }
            this.ShowClassList();
        }

        private void lstClass_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstClass.SelectedRows.Count == 1)
            {
                var row = this.lstClass.SelectedRows[0];
                var item = (lophoc)row.DataBoundItem;

                var form = new FormEditClass(item);
                form.ShowDialog();
                this.ShowClassList();
            }
        }
    }
}
