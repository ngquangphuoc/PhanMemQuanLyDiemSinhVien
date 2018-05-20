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
        private lophoc lop;

        public FormEditClass(lophoc lop)
        {
            InitializeComponent();
            this.lop = lop;
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
