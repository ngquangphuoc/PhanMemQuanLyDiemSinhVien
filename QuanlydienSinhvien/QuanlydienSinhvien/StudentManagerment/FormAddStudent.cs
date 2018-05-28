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

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboClass.DataSource = db.lophocs.ToList(); // load list class and assign to combobox
            this.cboClass.ValueMember = "lophoc_id"; // set a value class
            this.cboClass.DisplayMember = "tenlop"; // set the display class            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sinhvien student = new sinhvien();
            student.mssv = this.txtMSSV.Text;
            student.hovaten = this.txtName.Text;
            student.gioitinh = this.cboGender.Text;
            student.sdt = this.txtPhoneNumber.Text;
            student.email = this.txtMail.Text;
            DateTime parsedDate = DateTime.Parse(this.dtpBirthday.Text);
            student.ngaysinh = parsedDate;
            int class_id = ((lophoc)this.cboClass.SelectedItem).lophoc_id;
            student.lophoc_id = class_id;

            try
            {
                var db = new quanlydiemSinhVienEntities();
                db.sinhviens.Add(student);
                db.SaveChanges();
                MessageBox.Show("Thêm mới Sinh viên thành công !");
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

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtpBirthday.Value;
            this.dtpBirthday.Text = date.ToString("yyyy-MM-dd");
        }
    }
}
