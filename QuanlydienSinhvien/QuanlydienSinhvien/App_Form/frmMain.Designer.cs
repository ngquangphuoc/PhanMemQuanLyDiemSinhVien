namespace QuanlydienSinhvien.App_Form
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.traCứuVàQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKQHT = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiembyLop = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.traCứuVàQuảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1096, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // traCứuVàQuảnLýToolStripMenuItem
            // 
            this.traCứuVàQuảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLopHoc,
            this.menuMonHoc,
            this.menuThongTinSinhVien,
            this.menuKQHT});
            this.traCứuVàQuảnLýToolStripMenuItem.Name = "traCứuVàQuảnLýToolStripMenuItem";
            this.traCứuVàQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.traCứuVàQuảnLýToolStripMenuItem.Text = "Tra cứu và Quản lý";
            // 
            // menuLopHoc
            // 
            this.menuLopHoc.Name = "menuLopHoc";
            this.menuLopHoc.Size = new System.Drawing.Size(176, 22);
            this.menuLopHoc.Text = "Lớp học";
            this.menuLopHoc.Click += new System.EventHandler(this.menuLopHoc_Click);
            // 
            // menuMonHoc
            // 
            this.menuMonHoc.Name = "menuMonHoc";
            this.menuMonHoc.Size = new System.Drawing.Size(176, 22);
            this.menuMonHoc.Text = "Môn học";
            this.menuMonHoc.Click += new System.EventHandler(this.menuMonHoc_Click);
            // 
            // menuThongTinSinhVien
            // 
            this.menuThongTinSinhVien.Name = "menuThongTinSinhVien";
            this.menuThongTinSinhVien.Size = new System.Drawing.Size(176, 22);
            this.menuThongTinSinhVien.Text = "Thông tin sinh viên";
            this.menuThongTinSinhVien.Click += new System.EventHandler(this.menuThongTinSinhVien_Click);
            // 
            // menuKQHT
            // 
            this.menuKQHT.Name = "menuKQHT";
            this.menuKQHT.Size = new System.Drawing.Size(176, 22);
            this.menuKQHT.Text = "Kết quả học tập";
            this.menuKQHT.Click += new System.EventHandler(this.menuKQHT_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDiembyLop});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuDiembyLop
            // 
            this.menuDiembyLop.Name = "menuDiembyLop";
            this.menuDiembyLop.Size = new System.Drawing.Size(236, 22);
            this.menuDiembyLop.Text = "Điểm Trung Bình theo Lớp học";
            this.menuDiembyLop.Click += new System.EventHandler(this.menuDiembyLop_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 629);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem traCứuVàQuảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuKQHT;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDiembyLop;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}