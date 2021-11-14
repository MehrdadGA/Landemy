namespace Landemy.Forms
{
    partial class SearchCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_SearchCourse = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SearchCourseName = new System.Windows.Forms.TextBox();
            this.btn_SearchCoursePrint = new System.Windows.Forms.Button();
            this.btn_SearchCourseName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCourse)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_SearchCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 384);
            this.panel1.TabIndex = 2;
            // 
            // dgv_SearchCourse
            // 
            this.dgv_SearchCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_SearchCourse.Location = new System.Drawing.Point(-5, 0);
            this.dgv_SearchCourse.Name = "dgv_SearchCourse";
            this.dgv_SearchCourse.RowHeadersWidth = 51;
            this.dgv_SearchCourse.Size = new System.Drawing.Size(827, 381);
            this.dgv_SearchCourse.TabIndex = 0;
            this.dgv_SearchCourse.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SearchCourse_CellFormatting);
            this.dgv_SearchCourse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchCourse_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_SearchCourseName);
            this.panel2.Controls.Add(this.btn_SearchCoursePrint);
            this.panel2.Controls.Add(this.txt_SearchCourseName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 119);
            this.panel2.TabIndex = 0;
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // txt_SearchCourseName
            // 
            this.txt_SearchCourseName.Location = new System.Drawing.Point(587, 44);
            this.txt_SearchCourseName.Name = "txt_SearchCourseName";
            this.txt_SearchCourseName.Size = new System.Drawing.Size(151, 26);
            this.txt_SearchCourseName.TabIndex = 0;
            // 
            // btn_SearchCoursePrint
            // 
            this.btn_SearchCoursePrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_SearchCoursePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchCoursePrint.Location = new System.Drawing.Point(12, 38);
            this.btn_SearchCoursePrint.Name = "btn_SearchCoursePrint";
            this.btn_SearchCoursePrint.Size = new System.Drawing.Size(81, 37);
            this.btn_SearchCoursePrint.TabIndex = 1;
            this.btn_SearchCoursePrint.Text = "چاپ";
            this.btn_SearchCoursePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchCoursePrint.UseVisualStyleBackColor = true;
            // 
            // btn_SearchCourseName
            // 
            this.btn_SearchCourseName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_SearchCourseName.Location = new System.Drawing.Point(538, 35);
            this.btn_SearchCourseName.Name = "btn_SearchCourseName";
            this.btn_SearchCourseName.Size = new System.Drawing.Size(43, 42);
            this.btn_SearchCourseName.TabIndex = 2;
            this.btn_SearchCourseName.UseVisualStyleBackColor = true;
            this.btn_SearchCourseName.Click += new System.EventHandler(this.btn_SearchCourseName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام درس :";
            // 
            // SearchCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchCourseForm";
            this.Load += new System.EventHandler(this.SearchCourseForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCourse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SearchCourseName;
        private System.Windows.Forms.Button btn_SearchCoursePrint;
        private System.Windows.Forms.TextBox txt_SearchCourseName;
        public System.Windows.Forms.DataGridView dgv_SearchCourse;
    }
}