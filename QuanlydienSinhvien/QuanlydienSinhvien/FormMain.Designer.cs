namespace QuanlydienSinhvien.App_Form
{
    partial class FormMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.btnManagerment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClassManagerment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubjectManagerment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudyResultManagerment = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManagerment,
            this.btnStatistical});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuMain.Size = new System.Drawing.Size(1096, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // btnManagerment
            // 
            this.btnManagerment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClassManagerment,
            this.btnSubjectManagerment,
            this.btnStudentInformation,
            this.btnStudyResultManagerment});
            this.btnManagerment.Name = "btnManagerment";
            this.btnManagerment.Size = new System.Drawing.Size(117, 19);
            this.btnManagerment.Text = "Tra cứu và Quản lý";
            // 
            // btnClassManagerment
            // 
            this.btnClassManagerment.Name = "btnClassManagerment";
            this.btnClassManagerment.Size = new System.Drawing.Size(176, 22);
            this.btnClassManagerment.Text = "Lớp học";
            this.btnClassManagerment.Click += new System.EventHandler(this.btnClassManagerment_Click);
            // 
            // btnSubjectManagerment
            // 
            this.btnSubjectManagerment.Name = "btnSubjectManagerment";
            this.btnSubjectManagerment.Size = new System.Drawing.Size(176, 22);
            this.btnSubjectManagerment.Text = "Môn học";
            this.btnSubjectManagerment.Click += new System.EventHandler(this.btnSubjectManagerment_Click);
            // 
            // btnStudentInformation
            // 
            this.btnStudentInformation.Name = "btnStudentInformation";
            this.btnStudentInformation.Size = new System.Drawing.Size(176, 22);
            this.btnStudentInformation.Text = "Thông tin sinh viên";
            this.btnStudentInformation.Click += new System.EventHandler(this.btnStudentInformation_Click);
            // 
            // btnStudyResultManagerment
            // 
            this.btnStudyResultManagerment.Name = "btnStudyResultManagerment";
            this.btnStudyResultManagerment.Size = new System.Drawing.Size(176, 22);
            this.btnStudyResultManagerment.Text = "Kết quả học tập";
            this.btnStudyResultManagerment.Click += new System.EventHandler(this.btnStudyResultManagerment_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStatistic});
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(69, 19);
            this.btnStatistical.Text = "Thống kê";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(236, 22);
            this.btnStatistic.Text = "Điểm Trung Bình theo Lớp học";
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 629);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem btnManagerment;
        private System.Windows.Forms.ToolStripMenuItem btnClassManagerment;
        private System.Windows.Forms.ToolStripMenuItem btnSubjectManagerment;
        private System.Windows.Forms.ToolStripMenuItem btnStudentInformation;
        private System.Windows.Forms.ToolStripMenuItem btnStudyResultManagerment;
        private System.Windows.Forms.ToolStripMenuItem btnStatistical;
        private System.Windows.Forms.ToolStripMenuItem btnStatistic;
    }
}