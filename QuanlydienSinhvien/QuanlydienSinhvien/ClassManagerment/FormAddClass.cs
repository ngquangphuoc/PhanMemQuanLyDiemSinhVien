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
    public partial class FormAddClass : Form
    {
        public FormAddClass()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lophoc qllophoc = new lophoc();
            qllophoc.tenlop = this.txtName.Text;
            try
            {
                var db = new quanlydiemSinhVienEntities();
                db.lophocs.Add(qllophoc);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
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
