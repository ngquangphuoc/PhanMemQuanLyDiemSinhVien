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
    public partial class FormEditSubject : Form
    {
        public FormEditSubject(monhoc MonHoc)
        {
            InitializeComponent();
            this.MonHoc = MonHoc;
        }

        private monhoc MonHoc;

        private void FormEditSubject_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboSemester.Text = MonHoc.hocki_id.ToString();
            this.cboSemester.Enabled = false;
            this.txtSubjectId.Text = MonHoc.maMH;
            this.txtSubjectId.Enabled = false;
            this.txtSubjectName.Text = MonHoc.tenMH;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newSubject = db.monhocs.Find(this.MonHoc.monhoc_id);
                newSubject.maMH = this.txtSubjectId.Text;
                newSubject.tenMH = this.txtSubjectName.Text;
                db.Entry(newSubject).State = System.Data.Entity.EntityState.Modified;
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
    }
}
