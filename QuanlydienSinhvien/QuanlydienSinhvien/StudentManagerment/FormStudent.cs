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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            this.ShowStudentList();
        }

        private void ShowStudentList()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.sinhviens.ToList();
            this.lstStudent.DataSource = list;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var form = new FormAddStudent();
            form.ShowDialog();
            this.ShowStudentList();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();

            for (int i = 0; i < lstStudent.SelectedRows.Count; i++)
            {
                var row = this.lstStudent.SelectedRows[i];
                //var item = ()
            }
        }
    }
}
