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
    public partial class FormAddSubject : Form
    {
        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            monhoc MonHoc = new monhoc();
            MonHoc.maMH = this.txtSubjectId.Text;
            MonHoc.tenMH = this.txtSubjectName.Text;
            try
            {
                var db = new quanlydiemSinhVienEntities();
                db.monhocs.Add(MonHoc);
                db.SaveChanges();
                MessageBox.Show("Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất Bại");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
