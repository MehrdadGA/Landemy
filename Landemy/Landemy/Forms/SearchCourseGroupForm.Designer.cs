namespace Landemy.Forms
{
    partial class SearchCourseGroupForm
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
            this.pnl_SearchGroupCourseGrid = new System.Windows.Forms.Panel();
            this.dgv_SearchGroupCourse = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_SearchGroupCourseTools = new System.Windows.Forms.Panel();
            this.btn_CourseNameSearchGroupCourse = new System.Windows.Forms.Button();
            this.btn_YearSearchGroupCourse = new System.Windows.Forms.Button();
            this.btn_PrintSearchGroupCourse = new System.Windows.Forms.Button();
            this.btn_SearchTeacherGroupCourse = new System.Windows.Forms.Button();
            this.txt_SearchTeacherGroupCourse = new System.Windows.Forms.TextBox();
            this.txt_YearSearchGroupCourse = new System.Windows.Forms.TextBox();
            this.txt_CourseNameSearchGroupCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_SearchGroupCourseGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchGroupCourse)).BeginInit();
            this.pnl_SearchGroupCourseTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_SearchGroupCourseGrid
            // 
            this.pnl_SearchGroupCourseGrid.Controls.Add(this.dgv_SearchGroupCourse);
            this.pnl_SearchGroupCourseGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_SearchGroupCourseGrid.Location = new System.Drawing.Point(0, 166);
            this.pnl_SearchGroupCourseGrid.Name = "pnl_SearchGroupCourseGrid";
            this.pnl_SearchGroupCourseGrid.Size = new System.Drawing.Size(1122, 410);
            this.pnl_SearchGroupCourseGrid.TabIndex = 0;
            // 
            // dgv_SearchGroupCourse
            // 
            this.dgv_SearchGroupCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchGroupCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_SearchGroupCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SearchGroupCourse.Location = new System.Drawing.Point(0, 0);
            this.dgv_SearchGroupCourse.Name = "dgv_SearchGroupCourse";
            this.dgv_SearchGroupCourse.RowHeadersWidth = 51;
            this.dgv_SearchGroupCourse.Size = new System.Drawing.Size(1122, 410);
            this.dgv_SearchGroupCourse.TabIndex = 10;
            this.dgv_SearchGroupCourse.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchGroupCourse_CellContentDoubleClick);
            this.dgv_SearchGroupCourse.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SearchGroupCourse_CellFormatting);
            this.dgv_SearchGroupCourse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchGroupCourse_CellMouseDoubleClick);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // pnl_SearchGroupCourseTools
            // 
            this.pnl_SearchGroupCourseTools.Controls.Add(this.btn_CourseNameSearchGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.btn_YearSearchGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.btn_PrintSearchGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.btn_SearchTeacherGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.txt_SearchTeacherGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.txt_YearSearchGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.txt_CourseNameSearchGroupCourse);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.label3);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.label2);
            this.pnl_SearchGroupCourseTools.Controls.Add(this.label1);
            this.pnl_SearchGroupCourseTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SearchGroupCourseTools.Location = new System.Drawing.Point(0, 29);
            this.pnl_SearchGroupCourseTools.Name = "pnl_SearchGroupCourseTools";
            this.pnl_SearchGroupCourseTools.Size = new System.Drawing.Size(1122, 141);
            this.pnl_SearchGroupCourseTools.TabIndex = 0;
            // 
            // btn_CourseNameSearchGroupCourse
            // 
            this.btn_CourseNameSearchGroupCourse.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseNameSearchGroupCourse.Location = new System.Drawing.Point(580, 31);
            this.btn_CourseNameSearchGroupCourse.Name = "btn_CourseNameSearchGroupCourse";
            this.btn_CourseNameSearchGroupCourse.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseNameSearchGroupCourse.TabIndex = 9;
            this.btn_CourseNameSearchGroupCourse.UseVisualStyleBackColor = true;
            this.btn_CourseNameSearchGroupCourse.Click += new System.EventHandler(this.btn_CourseNameSearchGroupCourse_Click);
            // 
            // btn_YearSearchGroupCourse
            // 
            this.btn_YearSearchGroupCourse.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_YearSearchGroupCourse.Location = new System.Drawing.Point(307, 31);
            this.btn_YearSearchGroupCourse.Name = "btn_YearSearchGroupCourse";
            this.btn_YearSearchGroupCourse.Size = new System.Drawing.Size(43, 42);
            this.btn_YearSearchGroupCourse.TabIndex = 8;
            this.btn_YearSearchGroupCourse.UseVisualStyleBackColor = true;
            this.btn_YearSearchGroupCourse.Click += new System.EventHandler(this.btn_YearSearchGroupCourse_Click);
            // 
            // btn_PrintSearchGroupCourse
            // 
            this.btn_PrintSearchGroupCourse.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_PrintSearchGroupCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PrintSearchGroupCourse.Location = new System.Drawing.Point(12, 84);
            this.btn_PrintSearchGroupCourse.Name = "btn_PrintSearchGroupCourse";
            this.btn_PrintSearchGroupCourse.Size = new System.Drawing.Size(90, 47);
            this.btn_PrintSearchGroupCourse.TabIndex = 7;
            this.btn_PrintSearchGroupCourse.Text = "پرینت";
            this.btn_PrintSearchGroupCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrintSearchGroupCourse.UseVisualStyleBackColor = true;
            // 
            // btn_SearchTeacherGroupCourse
            // 
            this.btn_SearchTeacherGroupCourse.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_SearchTeacherGroupCourse.Location = new System.Drawing.Point(872, 31);
            this.btn_SearchTeacherGroupCourse.Name = "btn_SearchTeacherGroupCourse";
            this.btn_SearchTeacherGroupCourse.Size = new System.Drawing.Size(43, 42);
            this.btn_SearchTeacherGroupCourse.TabIndex = 6;
            this.btn_SearchTeacherGroupCourse.UseVisualStyleBackColor = true;
            this.btn_SearchTeacherGroupCourse.Click += new System.EventHandler(this.btn_SearchTeacherGroupCourse_Click);
            // 
            // txt_SearchTeacherGroupCourse
            // 
            this.txt_SearchTeacherGroupCourse.Location = new System.Drawing.Point(921, 40);
            this.txt_SearchTeacherGroupCourse.Name = "txt_SearchTeacherGroupCourse";
            this.txt_SearchTeacherGroupCourse.Size = new System.Drawing.Size(139, 26);
            this.txt_SearchTeacherGroupCourse.TabIndex = 5;
            // 
            // txt_YearSearchGroupCourse
            // 
            this.txt_YearSearchGroupCourse.Location = new System.Drawing.Point(356, 40);
            this.txt_YearSearchGroupCourse.Name = "txt_YearSearchGroupCourse";
            this.txt_YearSearchGroupCourse.Size = new System.Drawing.Size(139, 26);
            this.txt_YearSearchGroupCourse.TabIndex = 4;
            // 
            // txt_CourseNameSearchGroupCourse
            // 
            this.txt_CourseNameSearchGroupCourse.Location = new System.Drawing.Point(629, 40);
            this.txt_CourseNameSearchGroupCourse.Name = "txt_CourseNameSearchGroupCourse";
            this.txt_CourseNameSearchGroupCourse.Size = new System.Drawing.Size(139, 26);
            this.txt_CourseNameSearchGroupCourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "سال :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام درس :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "استاد :";
            // 
            // SearchCourseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 576);
            this.Controls.Add(this.pnl_SearchGroupCourseTools);
            this.Controls.Add(this.pnl_SearchGroupCourseGrid);
            this.Name = "SearchCourseGroupForm";
            this.Load += new System.EventHandler(this.SearchCourseGroupForm_Load);
            this.Controls.SetChildIndex(this.pnl_SearchGroupCourseGrid, 0);
            this.Controls.SetChildIndex(this.pnl_SearchGroupCourseTools, 0);
            this.pnl_SearchGroupCourseGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchGroupCourse)).EndInit();
            this.pnl_SearchGroupCourseTools.ResumeLayout(false);
            this.pnl_SearchGroupCourseTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_SearchGroupCourseGrid;
        private System.Windows.Forms.Panel pnl_SearchGroupCourseTools;
        private System.Windows.Forms.Button btn_CourseNameSearchGroupCourse;
        private System.Windows.Forms.Button btn_YearSearchGroupCourse;
        private System.Windows.Forms.Button btn_PrintSearchGroupCourse;
        private System.Windows.Forms.Button btn_SearchTeacherGroupCourse;
        private System.Windows.Forms.TextBox txt_SearchTeacherGroupCourse;
        private System.Windows.Forms.TextBox txt_YearSearchGroupCourse;
        private System.Windows.Forms.TextBox txt_CourseNameSearchGroupCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        public System.Windows.Forms.DataGridView dgv_SearchGroupCourse;
    }
}