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
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            sinhvien student = new sinhvien();
            student.mssv = this.txtMSSV.Text;
            student.hovaten = this.txtName.Text;
            student.sdt = this.txtPhoneNumber.Text;
            student.email = this.txtMail.Text;

            try
            {
                var db = new quanlydiemSinhVienEntities();
                db.sinhviens.Add(student);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
