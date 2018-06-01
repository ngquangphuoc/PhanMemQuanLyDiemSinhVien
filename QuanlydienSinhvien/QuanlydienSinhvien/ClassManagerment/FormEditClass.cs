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
    public partial class FormEditClass : Form
    {
        public FormEditClass(lophoc lop)
        {
            InitializeComponent();
            this.lop = lop;
        }

        private lophoc lop;

        private void FormEditClass_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.txtName.Text = lop.tenlop;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newClass = db.lophocs.Find(this.lop.lophoc_id);
                newClass.tenlop = this.txtName.Text;
                db.Entry(newClass).State = System.Data.Entity.EntityState.Modified;
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
