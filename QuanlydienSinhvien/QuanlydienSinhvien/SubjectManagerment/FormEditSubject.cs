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
        private monhoc MonHoc;

        public FormEditSubject(monhoc MonHoc)
        {
            InitializeComponent();
            this.MonHoc = MonHoc;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newSubject = db.monhocs.Find(this.MonHoc.monhoc_id);
                newSubject.tenMH = this.txtSubjectName.Text;
                db.Entry(newSubject).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
