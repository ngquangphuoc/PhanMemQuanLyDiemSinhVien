using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlydienSinhvien.App_Form
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Kiem tra xem 1 Form nào đó đã hiển thị trong Form Cha hay chưa
        private bool CheckExitForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Kích hoạt hiển thị các Form
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnClassManagerment_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("FormClass"))
            {
                //hien thi form Quản lý Lớp học
                ClassManagerment.FormClass FrmLopHoc = new ClassManagerment.FormClass();
                //dat form hien tai la form cha
                FrmLopHoc.MdiParent = this;
                FrmLopHoc.Show();
            }
            else
                ActiveChildForm("FormClass");
        }

        private void btnSubjectManagerment_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("FormSubject"))
            {
                //hien thi form Mon Hoc
                SubjectManagerment.FormSubject frmMonHoc = new SubjectManagerment.FormSubject();
                //dat form hien tai la form cha
                frmMonHoc.MdiParent = this;
                frmMonHoc.Show();
            }
            else
                ActiveChildForm("FormSubject");
        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("FormStudent"))
            {
                //hien thi form Sinh Viên
                StudentManagerment.FormStudent frmSinhVien = new StudentManagerment.FormStudent();
                //dat form hien tai la form cha
                frmSinhVien.MdiParent = this;
                frmSinhVien.Show();
            }
            else
                ActiveChildForm("FormStudent");
        }

        private void btnStudyResultManagerment_Click(object sender, EventArgs e)
        {
            if (!CheckExitForm("FormStudyResults"))
            {
                //hien thi form Kết Quả Học Tập
                StudyResultsManagerment.FormStudyResults frmStudyResult = new StudyResultsManagerment.FormStudyResults();
                //dat form hien tai la form cha
                frmStudyResult.MdiParent = this;
                frmStudyResult.Show();
            }
            else
                ActiveChildForm("FormStudyResults");
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            
        }
    }
}
