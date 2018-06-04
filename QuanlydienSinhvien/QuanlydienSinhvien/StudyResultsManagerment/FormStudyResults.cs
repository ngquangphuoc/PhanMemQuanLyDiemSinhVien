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
    public partial class FormStudyResults : Form
    {
        public FormStudyResults()
        {
            InitializeComponent();
        }

        private void FormStudyResults_Load(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboSubjectBySemester.DataSource = db.hockies.ToList(); // load list subject and assign to combobox
            this.cboSubjectBySemester.ValueMember = "hocki_id"; // set a value subject
            this.cboSubjectBySemester.DisplayMember = "tenhocky"; // set the display subject
            this.cboStudyResultBySubject.Enabled = false;
        }

        private ketquahoctap findKetQuaHocTapByID(int id) {
            quanlydiemSinhVienEntities db = new quanlydiemSinhVienEntities();
            var value = db.ketquahoctaps.Where(b => b.kqht_id == id).FirstOrDefault();
            return value;
        }

        private void FormStudyResultBySubject_Load(int studyResult_id)
        {
            quanlydiemSinhVienEntities db = new quanlydiemSinhVienEntities();
            var lists = (from kq in db.ketquahoctaps
                         join mon in db.monhocs
                             on kq.monhoc_id equals mon.monhoc_id
                         join sv in db.sinhviens
                            on kq.mssv equals sv.mssv
                            where kq.monhoc_id == studyResult_id
                         select new
                         {
                             kq.kqht_id,
                             mon.tenMH,
                             kq.mssv,
                             sv.hovaten,
                             kq.chuyencan,
                             kq.giuaki,
                             kq.cuoiki,
                             kq.DTB
                         }).ToList();

            //var list = db.ketquahoctaps.Where(b => b.monhoc_id == studyResult_id).ToList();
            //this.lstStudyResults.DataSource = list;
            //this.lstStudyResults.Columns["kqht_id"].Visible = false;
            //this.lstStudyResults.Columns["tenMH"].Visible = false;
            //this.lstStudyResults.Columns["monhoc_id"].Visible = false;
            this.lstStudyResults.DataSource = lists;
            this.lstStudyResults.Refresh();
        }

        

        private void cboSubjectBySemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            this.cboStudyResultBySubject.Enabled = true;
            int semester_id = ((hocky)this.cboSubjectBySemester.SelectedItem).hocki_id;
            this.cboStudyResultBySubject.DataSource = db.monhocs.Where(b => b.hocki_id == semester_id).ToList(); // load list subject and assign to combobox
            this.cboStudyResultBySubject.ValueMember = "monhoc_id"; // set a value subject
            this.cboStudyResultBySubject.DisplayMember = "tenMH"; // set the display subject
        }

        private void ShowStudyResults()
        {
            var db = new quanlydiemSinhVienEntities();
            //var list = db.ketquahoctaps.ToList();

            var lists = (from kq in db.ketquahoctaps
                         join mon in db.monhocs
                             on kq.monhoc_id equals mon.monhoc_id
                         join sv in db.sinhviens
                            on kq.mssv equals sv.mssv
                         select new
                         {
                             kq.kqht_id,
                             mon.tenMH,
                             kq.mssv,
                             sv.hovaten,
                             kq.chuyencan,
                             kq.giuaki,
                             kq.cuoiki,
                             kq.DTB
                         }).ToList();

            this.lstStudyResults.DataSource = lists;
            this.lstStudyResults.Refresh();
            //this.lstStudyResults.Columns["kqht_id"].Visible = true;
            //this.lstStudyResults.Columns["monhoc"].Visible = false;
            //this.lstStudyResults.Columns["monhoc_id"].Visible = false;
            //this.lstStudyResults.Columns["lophoc_id"].Visible = false;
        }

        private void btnAddStudyResults_Click(object sender, EventArgs e)
        {
            var form = new FormAddStudyResults();
            form.ShowDialog();
            this.ShowStudyResults();
        }

        private void lstStudyResults_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstStudyResults.SelectedRows.Count == 1)
            {
                var row = this.lstStudyResults.SelectedRows[0];
                var d = row.Cells["kqht_id"].Value.ToString();
                var ketqua = findKetQuaHocTapByID(Int32.Parse(d));
                var form = new FormEditStudyResults(ketqua);
                form.ShowDialog();
                this.ShowStudyResults();
            }
        }

        private void btnDeleteStudyResults_Click(object sender, EventArgs e)
        {
            var db = new quanlydiemSinhVienEntities();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.lstStudyResults.SelectedRows.Count; i++)
                {
                    var row = this.lstStudyResults.SelectedRows[i];
                    var item = (ketquahoctap)row.DataBoundItem;

                    try
                    {
                        ketquahoctap KetQuaHocTap = db.ketquahoctaps.Find(item.kqht_id);
                        db.ketquahoctaps.Remove(KetQuaHocTap);
                        db.SaveChanges();
                        MessageBox.Show("Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
            }
            this.ShowStudyResults();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            this.ShowStudyResults();
        }

        private void cboStudyResultBySubject_SelectedValueChanged(object sender, EventArgs e)
        {
            // get id from combobox
            var temp = cboStudyResultBySubject.SelectedValue;
            int studyResult_id = 0;
            int.TryParse(temp.ToString(), out studyResult_id);
            if (studyResult_id != 0)
            {
                FormStudyResultBySubject_Load(studyResult_id);
            }
        }
    }
}
