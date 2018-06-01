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
    public partial class FormEditStudyResults : Form
    {
        private ketquahoctap KetQuaHocTap;

        public FormEditStudyResults(ketquahoctap KetQuaHocTap)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.KetQuaHocTap = KetQuaHocTap;
        }

        private void FormEditStudyResults_Load(object sender, EventArgs e)
        {
            quanlydiemSinhVienEntities db = new quanlydiemSinhVienEntities();
            this.cboClass.DataSource = db.lophocs.ToList();
            this.cboClass.ValueMember = "lophoc_id";
            this.cboClass.DisplayMember = "tenlop";
            this.cboSubject.DataSource = db.monhocs.ToList();
            this.cboSubject.ValueMember = "monhoc_id";
            this.cboSubject.DisplayMember = "tenMH";
            this.txtMssv.Text = KetQuaHocTap.mssv;
            this.txtAttendance.Text = KetQuaHocTap.chuyencan.ToString();
            this.txtMidterm.Text = KetQuaHocTap.giuaki.ToString();
            this.txtFinalterm.Text = KetQuaHocTap.cuoiki.ToString();
            this.txtAverage.Text = KetQuaHocTap.DTB.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new quanlydiemSinhVienEntities();
                var newStudyResult = db.ketquahoctaps.Find(this.KetQuaHocTap.kqht_id);
                newStudyResult.mssv = this.txtMssv.Text;
                int diemCC = int.Parse(this.txtAttendance.Text);
                newStudyResult.chuyencan = diemCC;
                int diemGk = int.Parse(this.txtMidterm.Text);
                newStudyResult.giuaki = diemGk;
                int diemCK = int.Parse(this.txtFinalterm.Text);
                newStudyResult.cuoiki = diemCK;
                int diemTB = int.Parse(this.txtAverage.Text);
                newStudyResult.DTB = diemTB;
                db.Entry(newStudyResult).State = System.Data.Entity.EntityState.Modified;
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
