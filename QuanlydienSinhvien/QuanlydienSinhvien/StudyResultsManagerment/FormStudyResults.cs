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
            this.ShowStudyResults();
        }

        private void ShowStudyResults()
        {
            var db = new quanlydiemSinhVienEntities();
            var list = db.ketquahoctaps.ToList();
            this.lstStudyResults.DataSource = list;
            this.lstStudyResults.Columns["kqht_id"].Visible = false;
            this.lstStudyResults.Columns["lophoc_id"].Visible = false;
            this.lstStudyResults.Columns["monhoc_id"].Visible = false;
            this.lstStudyResults.Columns["hocki_id"].Visible = false;
            this.lstStudyResults.Columns["hocky"].Visible = false;
            this.lstStudyResults.Columns["lophoc"].Visible = false;
        }
    }
}
