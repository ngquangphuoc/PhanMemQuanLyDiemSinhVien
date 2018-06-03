﻿namespace QuanlydienSinhvien.SubjectManagerment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSubjectBySemester = new System.Windows.Forms.ComboBox();
            this.clSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSubject,
            this.btnDeleteSubject,
            this.btnRefesh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(101, 20);
            this.btnAddSubject.Text = "Thêm Môn học";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(90, 20);
            this.btnDeleteSubject.Text = "Xóa Môn học";
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(78, 20);
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
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 370);
            this.Controls.Add(this.cboSubjectBySemester);
            this.Controls.Add(this.lstSubject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSubject";
            this.Text = "DANH SÁCH MÔN HỌC";
            this.Load += new System.EventHandler(this.FormSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstSubject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddSubject;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteSubject;
        private System.Windows.Forms.ComboBox cboSubjectBySemester;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubjectName;
    }
}