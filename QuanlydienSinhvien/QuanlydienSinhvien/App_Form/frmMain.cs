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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuLopHoc_Click(object sender, EventArgs e)
        {
            //hien thi form Lop Hoc
            frmLopHoc frmLopHoc = new frmLopHoc();
            //dat form hien tai la orm cha
            frmLopHoc.MdiParent = this;
            frmLopHoc.Show();
        }

        private void menuMonHoc_Click(object sender, EventArgs e)
        {
            //hien thi form Mon Hoc
            frmMonHoc frmMonHoc = new frmMonHoc();
            //dat form hien tai la orm cha
            frmMonHoc.MdiParent = this;
            frmMonHoc.Show();
        }

        private void menuThongTinSinhVien_Click(object sender, EventArgs e)
        {
            //hien thi form Thong tin Sinh vien
            frmSinhVien frmSinhVien = new frmSinhVien();
            //dat form hien tai la orm cha
            frmSinhVien.MdiParent = this;
            frmSinhVien.Show();
        }

        private void menuKQHT_Click(object sender, EventArgs e)
        {
            //hien thi form Ket Qua Hoc Tap
            frmKQHT frmKQHT = new frmKQHT();
            //dat form hien tai la orm cha
            frmKQHT.MdiParent = this;
            frmKQHT.Show();
        }

        private void menuDiembyLop_Click(object sender, EventArgs e)
        {
            //hien thi form Diem Trung Bình học tâp
            frmThongKe frmThongKe = new frmThongKe();
            //dat form hien tai la orm cha
            frmThongKe.MdiParent = this;
            frmThongKe.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
