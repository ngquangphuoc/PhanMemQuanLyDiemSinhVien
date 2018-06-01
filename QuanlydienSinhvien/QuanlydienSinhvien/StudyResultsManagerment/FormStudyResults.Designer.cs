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
            ((System.ComponentModel.ISupportInitialize)(this.lstStudyResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStudyResults
            // 
            this.lstStudyResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudyResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudyResults.Location = new System.Drawing.Point(0, 24);
            this.lstStudyResults.Name = "lstStudyResults";
            this.lstStudyResults.Size = new System.Drawing.Size(657, 296);
            this.lstStudyResults.TabIndex = 0;
            this.lstStudyResults.DoubleClick += new System.EventHandler(this.lstStudyResults_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStudyResults,
            this.btnDeleteStudyResults});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddStudyResults
            // 
            this.btnAddStudyResults.Name = "btnAddStudyResults";
            this.btnAddStudyResults.Size = new System.Drawing.Size(136, 20);
            this.btnAddStudyResults.Text = "Thêm Kết quả học tập";
            this.btnAddStudyResults.Click += new System.EventHandler(this.btnAddStudyResults_Click);
            // 
            // btnDeleteStudyResults
            // 
            this.btnDeleteStudyResults.Name = "btnDeleteStudyResults";
            this.btnDeleteStudyResults.Size = new System.Drawing.Size(125, 20);
            this.btnDeleteStudyResults.Text = "Xóa Kết quả học tập";
            this.btnDeleteStudyResults.Click += new System.EventHandler(this.btnDeleteStudyResults_Click);
            // 
            // FormStudyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 320);
            this.Controls.Add(this.lstStudyResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudyResults";
            this.Text = "DANH SÁCH KẾT QUẢ HỌC TẬP";
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
    }
}