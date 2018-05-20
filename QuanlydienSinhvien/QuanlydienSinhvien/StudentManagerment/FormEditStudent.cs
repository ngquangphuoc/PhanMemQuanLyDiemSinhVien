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
    public partial class FormEditStudent : Form
    {
        public FormEditStudent(sinhvien SinhVien)
        {
            InitializeComponent();
            this.SinhVien = SinhVien;
        }

        private sinhvien SinhVien;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newStudent = db.sinhviens.Find(this.SinhVien.mssv);
                newStudent.hovaten = this.txtName.Text;
                newStudent.sdt = this.txtPhoneNumber.Text;
                newStudent.email = this.txtMail.Text;
                db.Entry(newStudent).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
