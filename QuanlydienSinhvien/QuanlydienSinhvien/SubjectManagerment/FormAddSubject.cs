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

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboSemester.DataSource = db.hockies.ToList();
            this.cboSemester.ValueMember = "hocki_id";
            this.cboSemester.DisplayMember = "tenhocky";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            monhoc MonHoc = new monhoc();
            int semester_id = ((hocky)this.cboSemester.SelectedItem).hocki_id;
            MonHoc.hocki_id = semester_id;
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
