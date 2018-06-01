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
            var db = new quanlydiemSinhVienEntities();
            this.cboFillterByClass.DataSource = db.lophocs.ToList(); // load list class and assign to combobox
            this.cboFillterByClass.ValueMember = "lophoc_id"; // set a value class
            this.cboFillterByClass.DisplayMember = "tenlop"; // set the display class
            this.ShowStudentList();
        }

        private void FormStudentByClass_Load(int class_id)
        {
            var db = new quanlydiemSinhVienEntities();
            var listByClass = db.sinhviens.Where(b => b.lophoc_id == class_id).ToList();
            lstStudent.DataSource = listByClass;
            this.lstStudent.Columns["lophoc_id"].Visible = false;
            this.lstStudent.Columns["lophoc"].Visible = false;
        }

        private void ShowStudentList()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.sinhviens.ToList();
            this.lstStudent.DataSource = list;
            this.lstStudent.Columns["lophoc_id"].Visible = false;
            this.lstStudent.Columns["lophoc"].Visible = false;
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
            if (MessageBox.Show("Bạn có muốn xóa ?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < lstStudent.SelectedRows.Count; i++)
                {
                    var row = this.lstStudent.SelectedRows[i];
                    var item = (sinhvien)row.DataBoundItem;
                    try
                    {
                        sinhvien SinhVien = db.sinhviens.Find(item.mssv);
                        db.sinhviens.Remove(SinhVien);
                        db.SaveChanges();
                        MessageBox.Show("Thành Công");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                this.ShowStudentList();
            }
        }

        private void lstStudent_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstStudent.SelectedRows.Count == 1)
            {
                var row = this.lstStudent.SelectedRows[0];
                var item = (sinhvien)row.DataBoundItem;

                var form = new FormEditStudent(item);
                form.ShowDialog();
                this.ShowStudentList();
            }
        }

        private void cboFillterByClass_SelectedValueChanged(object sender, EventArgs e)
        {
            // get id from combobox
            var temp = cboFillterByClass.SelectedValue;
            int class_id = 0;
            int.TryParse(temp.ToString(), out class_id);
            if (class_id != 0)
            {
                FormStudentByClass_Load(class_id);
            }
        }

    }
}
