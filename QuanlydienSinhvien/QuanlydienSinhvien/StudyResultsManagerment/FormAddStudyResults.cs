using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.StudyResultsManagerment
{
    public partial class FormAddStudyResults : Form
    {
        public FormAddStudyResults()
        {
            InitializeComponent();
        }

        private void FormAddStudyResults_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboSemester.DataSource = db.hockies.ToList(); // load list subject and assign to combobox
            this.cboSemester.ValueMember = "hocki_id"; // set a value subject
            this.cboSemester.DisplayMember = "tenhocky"; // set the display subject
            //this.cboStudyResultBySubject.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ketquahoctap KQHT = new ketquahoctap();
            //int class_id = ((lophoc)this.cboClass.SelectedItem).lophoc_id;
            //KQHT.lophoc_id = class_id;
            int monhoc_id = ((monhoc)this.cboSubject.SelectedItem).monhoc_id;
            KQHT.monhoc_id = monhoc_id;
            KQHT.mssv = this.txtMssv.Text;
            int diemCC = int.Parse(txtAttendance.Text);
            KQHT.chuyencan = diemCC;
            int diemGK = int.Parse(txtMidterm.Text);
            KQHT.giuaki = diemGK;
            int diemCK = int.Parse(txtFinalterm.Text);
            KQHT.cuoiki = diemCK;
            int diemTB = int.Parse(txtAverage.Text);
            KQHT.DTB = diemTB;
            try
            {
                quanlydiemSinhVienEntities db = new quanlydiemSinhVienEntities();
                db.ketquahoctaps.Add(KQHT);
                db.SaveChanges();
                MessageBox.Show("Thành Công");
                this.Close();
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

        private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboSubject.Enabled = true;
            int semester_id = ((hocky)this.cboSemester.SelectedItem).hocki_id;
            this.cboSubject.DataSource = db.monhocs.Where(b => b.hocki_id == semester_id).ToList(); // load list subject and assign to combobox
            this.cboSubject.ValueMember = "monhoc_id"; // set a value subject
            this.cboSubject.DisplayMember = "tenMH"; // set the display subject
        }
    }
}
