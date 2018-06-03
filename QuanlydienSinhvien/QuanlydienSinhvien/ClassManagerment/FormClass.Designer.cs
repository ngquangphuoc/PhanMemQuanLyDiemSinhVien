namespace QuanlydienSinhvien.ClassManagerment
{
    partial class FormClass
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
            this.lstClass = new System.Windows.Forms.DataGridView();
            this.clClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuClass = new System.Windows.Forms.MenuStrip();
            this.btnAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteClass = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lstClass)).BeginInit();
            this.menuClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClass
            // 
            this.lstClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clClassName});
            this.lstClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClass.Location = new System.Drawing.Point(0, 0);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(681, 337);
            this.lstClass.TabIndex = 0;
            this.lstClass.DoubleClick += new System.EventHandler(this.lstClass_DoubleClick);
            // 
            // clClassName
            // 
            this.clClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clClassName.DataPropertyName = "tenlop";
            this.clClassName.HeaderText = "Tên Lớp học";
            this.clClassName.Name = "clClassName";
            // 
            // menuClass
            // 
            this.menuClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddClass,
            this.btnDeleteClass});
            this.menuClass.Location = new System.Drawing.Point(0, 0);
            this.menuClass.Name = "menuClass";
            this.menuClass.Size = new System.Drawing.Size(681, 24);
            this.menuClass.TabIndex = 1;
            this.menuClass.Text = "menuStrip1";
            this.menuClass.Visible = false;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(98, 20);
            this.btnAddClass.Text = "Thêm Lớp học";
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(87, 20);
            this.btnDeleteClass.Text = "Xóa Lớp học";
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 337);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.menuClass);
            this.MainMenuStrip = this.menuClass;
            this.Name = "FormClass";
            this.Text = "DANH SÁCH LỚP HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstClass)).EndInit();
            this.menuClass.ResumeLayout(false);
            this.menuClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstClass;
        private System.Windows.Forms.MenuStrip menuClass;
        private System.Windows.Forms.ToolStripMenuItem btnAddClass;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clClassName;
    }
}