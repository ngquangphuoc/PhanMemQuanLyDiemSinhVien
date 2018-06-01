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
        //private lophoc LopHoc;

        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboClass.Text = SinhVien.lophoc_id.ToString();
            this.cboClass.Enabled = false;
            this.txtMSSV.Text = SinhVien.mssv;
            this.txtMSSV.Enabled = false;
            this.txtName.Text = SinhVien.hovaten;
            this.dtpBirthday.Text = SinhVien.ngaysinh.ToString();
            this.cboGender.Text = SinhVien.gioitinh;
            this.txtPhoneNumber.Text = SinhVien.sdt;
            this.txtMail.Text = SinhVien.email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newStudent = db.sinhviens.Find(this.SinhVien.mssv);
                //int class_id = ((lophoc)this.cboClass.SelectedItem).lophoc_id;
                //newStudent.lophoc_id = class_id;
                newStudent.mssv = this.txtMSSV.Text;
                newStudent.hovaten = this.txtName.Text;
                DateTime parsedate = DateTime.Parse(this.dtpBirthday.Text);
                newStudent.ngaysinh = parsedate;
                newStudent.gioitinh = this.cboGender.Text;
                newStudent.sdt = this.txtPhoneNumber.Text;
                newStudent.email = this.txtMail.Text;
                db.Entry(newStudent).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Thành Công");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtpBirthday.Value;
            this.dtpBirthday.Text = date.ToString("yyyy-MM-dd");
        }
    }
}
