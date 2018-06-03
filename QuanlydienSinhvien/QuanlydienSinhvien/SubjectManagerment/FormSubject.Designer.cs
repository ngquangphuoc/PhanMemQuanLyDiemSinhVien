namespace QuanlydienSinhvien.SubjectManagerment
{
    partial class FormSubject
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
            this.lstSubject = new System.Windows.Forms.DataGridView();
            this.clSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSubject = new System.Windows.Forms.MenuStrip();
            this.btnAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSubjectBySemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).BeginInit();
            this.menuSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubject
            // 
            this.lstSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSubjectCode,
            this.clSubjectName});
            this.lstSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSubject.Location = new System.Drawing.Point(0, 24);
            this.lstSubject.Name = "lstSubject";
            this.lstSubject.Size = new System.Drawing.Size(651, 346);
            this.lstSubject.TabIndex = 0;
            this.lstSubject.DoubleClick += new System.EventHandler(this.lstSubject_DoubleClick);
            // 
            // clSubjectCode
            // 
            this.clSubjectCode.DataPropertyName = "maMH";
            this.clSubjectCode.HeaderText = "Mã Môn học";
            this.clSubjectCode.Name = "clSubjectCode";
            this.clSubjectCode.Width = 150;
            // 
            // clSubjectName
            // 
            this.clSubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSubjectName.DataPropertyName = "tenMH";
            this.clSubjectName.HeaderText = "Tên Môn học";
            this.clSubjectName.Name = "clSubjectName";
            // 
            // menuSubject
            // 
            this.menuSubject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSubject,
            this.btnDeleteSubject,
            this.btnRefesh});
            this.menuSubject.Location = new System.Drawing.Point(0, 0);
            this.menuSubject.Name = "menuSubject";
            this.menuSubject.Size = new System.Drawing.Size(651, 24);
            this.menuSubject.TabIndex = 1;
            this.menuSubject.Text = "menuStrip1";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.Brown;
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(102, 20);
            this.btnAddSubject.Text = "Thêm Môn học";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(91, 20);
            this.btnDeleteSubject.Text = "Xóa Môn học";
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(81, 20);
            this.btnRefesh.Text = "Xem Tất cả";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // cboSubjectBySemester
            // 
            this.cboSubjectBySemester.FormattingEnabled = true;
            this.cboSubjectBySemester.Location = new System.Drawing.Point(282, 0);
            this.cboSubjectBySemester.Name = "cboSubjectBySemester";
            this.cboSubjectBySemester.Size = new System.Drawing.Size(85, 21);
            this.cboSubjectBySemester.TabIndex = 2;
            this.cboSubjectBySemester.SelectedValueChanged += new System.EventHandler(this.cboSubjectBySemester_SelectedValueChanged);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 370);
            this.Controls.Add(this.cboSubjectBySemester);
            this.Controls.Add(this.lstSubject);
            this.Controls.Add(this.menuSubject);
            this.MainMenuStrip = this.menuSubject;
            this.Name = "FormSubject";
            this.Text = "DANH SÁCH MÔN HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).EndInit();
            this.menuSubject.ResumeLayout(false);
            this.menuSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstSubject;
        private System.Windows.Forms.MenuStrip menuSubject;
        private System.Windows.Forms.ToolStripMenuItem btnAddSubject;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteSubject;
        private System.Windows.Forms.ComboBox cboSubjectBySemester;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubjectName;
    }
}