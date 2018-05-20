using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.StudentManagerment
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            this.ShowStudentList();
        }

        private void ShowStudentList()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.sinhviens.ToList();
            this.lstStudent.DataSource = list;
            this.lstStudent.Columns["lophoc_id"].Visible = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var form = new FormAddStudent();
            form.ShowDialog();
            this.ShowStudentList();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            if (MessageBox.Show("Bạn có muốn xóa ?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lstStudent.SelectedRows.Count; i++)
                {
                    var row = this.lstStudent.SelectedRows[i];
                    var item = (sinhvien)row.DataBoundItem;
                    try
                    {
                        sinhvien SinhVien = db.sinhviens.Find(item.mssv);
                        db.sinhviens.Remove(SinhVien);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa sinh viên");
                    }
                }
                this.ShowStudentList();
            }
        }

        private void lstStudent_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstStudent.SelectedRows.Count == 1)
            {
                var row = this.lstStudent.SelectedRows[0];
                var item = (sinhvien)row.DataBoundItem;

                var form = new FormEditStudent(item);
                form.ShowDialog();
                this.ShowStudentList();
            }
        }
    }
}
