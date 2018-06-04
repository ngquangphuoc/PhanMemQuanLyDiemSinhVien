namespace QuanlydienSinhvien.StudyResultsManagerment
{
    partial class FormStudyResults
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
            this.lstStudyResults = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddStudyResults = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteStudyResults = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.cboStudyResultBySubject = new System.Windows.Forms.ComboBox();
            this.cboSubjectBySemester = new System.Windows.Forms.ComboBox();
            this.clMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiuaky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstStudyResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStudyResults
            // 
            this.lstStudyResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudyResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMonHoc,
            this.clMSSV,
            this.clHoVaTen,
            this.clChuyenCan,
            this.clGiuaky,
            this.clCuoiKy,
            this.clDiemTrungBinh});
            this.lstStudyResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudyResults.Location = new System.Drawing.Point(0, 24);
            this.lstStudyResults.Name = "lstStudyResults";
            this.lstStudyResults.Size = new System.Drawing.Size(817, 296);
            this.lstStudyResults.TabIndex = 0;
            this.lstStudyResults.DoubleClick += new System.EventHandler(this.lstStudyResults_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStudyResults,
            this.btnDeleteStudyResults,
            this.btnRefesh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddStudyResults
            // 
            this.btnAddStudyResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudyResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddStudyResults.Name = "btnAddStudyResults";
            this.btnAddStudyResults.Size = new System.Drawing.Size(141, 20);
            this.btnAddStudyResults.Text = "Thêm Kết quả học tập";
            this.btnAddStudyResults.Click += new System.EventHandler(this.btnAddStudyResults_Click);
            // 
            // btnDeleteStudyResults
            // 
            this.btnDeleteStudyResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudyResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteStudyResults.Name = "btnDeleteStudyResults";
            this.btnDeleteStudyResults.Size = new System.Drawing.Size(130, 20);
            this.btnDeleteStudyResults.Text = "Xóa Kết quả học tập";
            this.btnDeleteStudyResults.Click += new System.EventHandler(this.btnDeleteStudyResults_Click);
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
            // cboStudyResultBySubject
            // 
            this.cboStudyResultBySubject.FormattingEnabled = true;
            this.cboStudyResultBySubject.Location = new System.Drawing.Point(465, 0);
            this.cboStudyResultBySubject.Name = "cboStudyResultBySubject";
            this.cboStudyResultBySubject.Size = new System.Drawing.Size(276, 21);
            this.cboStudyResultBySubject.TabIndex = 3;
            this.cboStudyResultBySubject.SelectedValueChanged += new System.EventHandler(this.cboStudyResultBySubject_SelectedValueChanged);
            // 
            // cboSubjectBySemester
            // 
            this.cboSubjectBySemester.FormattingEnabled = true;
            this.cboSubjectBySemester.Location = new System.Drawing.Point(358, 0);
            this.cboSubjectBySemester.Name = "cboSubjectBySemester";
            this.cboSubjectBySemester.Size = new System.Drawing.Size(84, 21);
            this.cboSubjectBySemester.TabIndex = 4;
            this.cboSubjectBySemester.SelectedIndexChanged += new System.EventHandler(this.cboSubjectBySemester_SelectedIndexChanged);
            // 
            // clMonHoc
            // 
            this.clMonHoc.DataPropertyName = "tenMH";
            this.clMonHoc.HeaderText = "Môn học";
            this.clMonHoc.Name = "clMonHoc";
            this.clMonHoc.Width = 200;
            // 
            // clMSSV
            // 
            this.clMSSV.DataPropertyName = "mssv";
            this.clMSSV.HeaderText = "MSSV";
            this.clMSSV.Name = "clMSSV";
            // 
            // clHoVaTen
            // 
            this.clHoVaTen.DataPropertyName = "hovaten";
            this.clHoVaTen.HeaderText = "Họ và Tên";
            this.clHoVaTen.Name = "clHoVaTen";
            this.clHoVaTen.Width = 160;
            // 
            // clChuyenCan
            // 
            this.clChuyenCan.DataPropertyName = "chuyencan";
            this.clChuyenCan.HeaderText = "Chuyên cần";
            this.clChuyenCan.Name = "clChuyenCan";
            this.clChuyenCan.Width = 80;
            // 
            // clGiuaky
            // 
            this.clGiuaky.DataPropertyName = "giuaki";
            this.clGiuaky.HeaderText = "Giữa Kỳ";
            this.clGiuaky.Name = "clGiuaky";
            this.clGiuaky.Width = 80;
            // 
            // clCuoiKy
            // 
            this.clCuoiKy.DataPropertyName = "cuoiki";
            this.clCuoiKy.HeaderText = "Cuối Kỳ";
            this.clCuoiKy.Name = "clCuoiKy";
            this.clCuoiKy.Width = 80;
            // 
            // clDiemTrungBinh
            // 
            this.clDiemTrungBinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDiemTrungBinh.DataPropertyName = "DTB";
            this.clDiemTrungBinh.HeaderText = "Điểm Trung Bình";
            this.clDiemTrungBinh.Name = "clDiemTrungBinh";
            // 
            // FormStudyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 320);
            this.Controls.Add(this.cboSubjectBySemester);
            this.Controls.Add(this.cboStudyResultBySubject);
            this.Controls.Add(this.lstStudyResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudyResults";
            this.Text = "DANH SÁCH KẾT QUẢ HỌC TẬP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStudyResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstStudyResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstStudyResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddStudyResults;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteStudyResults;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.ComboBox cboStudyResultBySubject;
        private System.Windows.Forms.ComboBox cboSubjectBySemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiuaky;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemTrungBinh;
    }
}