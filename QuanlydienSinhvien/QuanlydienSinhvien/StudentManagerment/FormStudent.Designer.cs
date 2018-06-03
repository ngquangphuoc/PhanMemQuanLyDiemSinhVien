namespace QuanlydienSinhvien.StudentManagerment
{
    partial class FormStudent
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
            this.lstStudent = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboFillterByClass = new System.Windows.Forms.ComboBox();
            this.clStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStudentID,
            this.clFullName,
            this.clBirthday,
            this.clGender,
            this.clPhoneNumber,
            this.clEmail});
            this.lstStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudent.Location = new System.Drawing.Point(0, 24);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(772, 286);
            this.lstStudent.TabIndex = 0;
            this.lstStudent.DoubleClick += new System.EventHandler(this.lstStudent_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStudent,
            this.btnDeleteStudent,
            this.xemTấtCảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(101, 20);
            this.btnAddStudent.Text = "Thêm Sinh viên";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(90, 20);
            this.btnDeleteStudent.Text = "Xóa Sinh viên";
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // xemTấtCảToolStripMenuItem
            // 
            this.xemTấtCảToolStripMenuItem.Name = "xemTấtCảToolStripMenuItem";
            this.xemTấtCảToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.xemTấtCảToolStripMenuItem.Text = "Xem Tất cả";
            this.xemTấtCảToolStripMenuItem.Click += new System.EventHandler(this.xemTấtCảToolStripMenuItem_Click);
            // 
            // cboFillterByClass
            // 
            this.cboFillterByClass.FormattingEnabled = true;
            this.cboFillterByClass.Location = new System.Drawing.Point(285, 0);
            this.cboFillterByClass.Name = "cboFillterByClass";
            this.cboFillterByClass.Size = new System.Drawing.Size(78, 21);
            this.cboFillterByClass.TabIndex = 2;
            this.cboFillterByClass.SelectedValueChanged += new System.EventHandler(this.cboFillterByClass_SelectedValueChanged);
            // 
            // clStudentID
            // 
            this.clStudentID.DataPropertyName = "mssv";
            this.clStudentID.HeaderText = "MSSV";
            this.clStudentID.Name = "clStudentID";
            this.clStudentID.Width = 60;
            // 
            // clFullName
            // 
            this.clFullName.DataPropertyName = "hovaten";
            this.clFullName.HeaderText = "Họ và Tên";
            this.clFullName.Name = "clFullName";
            this.clFullName.Width = 200;
            // 
            // clBirthday
            // 
            this.clBirthday.DataPropertyName = "ngaysinh";
            this.clBirthday.HeaderText = "Ngày sinh";
            this.clBirthday.Name = "clBirthday";
            this.clBirthday.Width = 90;
            // 
            // clGender
            // 
            this.clGender.DataPropertyName = "gioitinh";
            this.clGender.HeaderText = "Giới tính";
            this.clGender.Name = "clGender";
            this.clGender.Width = 50;
            // 
            // clPhoneNumber
            // 
            this.clPhoneNumber.DataPropertyName = "sdt";
            this.clPhoneNumber.HeaderText = "SDT";
            this.clPhoneNumber.Name = "clPhoneNumber";
            // 
            // clEmail
            // 
            this.clEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEmail.DataPropertyName = "email";
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 310);
            this.Controls.Add(this.cboFillterByClass);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudent";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteStudent;
        private System.Windows.Forms.ComboBox cboFillterByClass;
        private System.Windows.Forms.ToolStripMenuItem xemTấtCảToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
    }
}