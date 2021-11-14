namespace Landemy.Forms
{
    partial class CourseForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Course = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CourseInsert = new System.Windows.Forms.Button();
            this.btn_CourseEdit = new System.Windows.Forms.Button();
            this.btn_CourseDelete = new System.Windows.Forms.Button();
            this.btn_CoursePrint = new System.Windows.Forms.Button();
            this.txt_CorseLevelCount = new System.Windows.Forms.TextBox();
            this.txt_CourseTuition = new System.Windows.Forms.TextBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_MoreCourseSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CourseSearchName = new System.Windows.Forms.TextBox();
            this.btn_CourseNameSearch = new System.Windows.Forms.Button();
            this.erp_Course = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Course);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 568);
            this.panel1.TabIndex = 2;
            // 
            // dgv_Course
            // 
            this.dgv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_Course.Location = new System.Drawing.Point(0, 0);
            this.dgv_Course.Name = "dgv_Course";
            this.dgv_Course.RowHeadersWidth = 51;
            this.dgv_Course.Size = new System.Drawing.Size(642, 442);
            this.dgv_Course.TabIndex = 25;
            this.dgv_Course.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Course_CellClick);
            this.dgv_Course.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Course_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_CourseInsert);
            this.panel2.Controls.Add(this.btn_CourseEdit);
            this.panel2.Controls.Add(this.btn_CourseDelete);
            this.panel2.Controls.Add(this.btn_CoursePrint);
            this.panel2.Controls.Add(this.txt_CorseLevelCount);
            this.panel2.Controls.Add(this.txt_CourseTuition);
            this.panel2.Controls.Add(this.txt_CourseName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(642, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 442);
            this.panel2.TabIndex = 0;
            // 
            // btn_CourseInsert
            // 
            this.btn_CourseInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_CourseInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseInsert.Location = new System.Drawing.Point(212, 321);
            this.btn_CourseInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseInsert.Name = "btn_CourseInsert";
            this.btn_CourseInsert.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseInsert.TabIndex = 23;
            this.btn_CourseInsert.Text = "افزودن";
            this.btn_CourseInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseInsert.UseVisualStyleBackColor = true;
            this.btn_CourseInsert.Click += new System.EventHandler(this.btn_CourseInsert_Click);
            // 
            // btn_CourseEdit
            // 
            this.btn_CourseEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_CourseEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseEdit.Location = new System.Drawing.Point(101, 321);
            this.btn_CourseEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseEdit.Name = "btn_CourseEdit";
            this.btn_CourseEdit.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseEdit.TabIndex = 24;
            this.btn_CourseEdit.Text = "ویرایش";
            this.btn_CourseEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseEdit.UseVisualStyleBackColor = true;
            this.btn_CourseEdit.Click += new System.EventHandler(this.btn_CourseEdit_Click);
            // 
            // btn_CourseDelete
            // 
            this.btn_CourseDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_CourseDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseDelete.Location = new System.Drawing.Point(212, 382);
            this.btn_CourseDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseDelete.Name = "btn_CourseDelete";
            this.btn_CourseDelete.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseDelete.TabIndex = 22;
            this.btn_CourseDelete.Text = "حذف";
            this.btn_CourseDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseDelete.UseVisualStyleBackColor = true;
            this.btn_CourseDelete.Click += new System.EventHandler(this.btn_CourseDelete_Click);
            // 
            // btn_CoursePrint
            // 
            this.btn_CoursePrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_CoursePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CoursePrint.Location = new System.Drawing.Point(101, 382);
            this.btn_CoursePrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CoursePrint.Name = "btn_CoursePrint";
            this.btn_CoursePrint.Size = new System.Drawing.Size(99, 53);
            this.btn_CoursePrint.TabIndex = 21;
            this.btn_CoursePrint.Text = "چاپ";
            this.btn_CoursePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CoursePrint.UseVisualStyleBackColor = true;
            // 
            // txt_CorseLevelCount
            // 
            this.txt_CorseLevelCount.Location = new System.Drawing.Point(50, 120);
            this.txt_CorseLevelCount.Name = "txt_CorseLevelCount";
            this.txt_CorseLevelCount.Size = new System.Drawing.Size(169, 26);
            this.txt_CorseLevelCount.TabIndex = 5;
            // 
            // txt_CourseTuition
            // 
            this.txt_CourseTuition.Location = new System.Drawing.Point(50, 184);
            this.txt_CourseTuition.Name = "txt_CourseTuition";
            this.txt_CourseTuition.Size = new System.Drawing.Size(169, 26);
            this.txt_CourseTuition.TabIndex = 4;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Location = new System.Drawing.Point(50, 50);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(169, 26);
            this.txt_CourseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام درس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد سطح :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "شهریه :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_MoreCourseSearch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_CourseSearchName);
            this.panel3.Controls.Add(this.btn_CourseNameSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 126);
            this.panel3.TabIndex = 0;
            // 
            // btn_MoreCourseSearch
            // 
            this.btn_MoreCourseSearch.Location = new System.Drawing.Point(12, 44);
            this.btn_MoreCourseSearch.Name = "btn_MoreCourseSearch";
            this.btn_MoreCourseSearch.Size = new System.Drawing.Size(104, 51);
            this.btn_MoreCourseSearch.TabIndex = 10;
            this.btn_MoreCourseSearch.Text = "جستجوی بیشتر";
            this.btn_MoreCourseSearch.UseVisualStyleBackColor = true;
            this.btn_MoreCourseSearch.Click += new System.EventHandler(this.btn_MoreCourseSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "نام درس :";
            // 
            // txt_CourseSearchName
            // 
            this.txt_CourseSearchName.Location = new System.Drawing.Point(692, 53);
            this.txt_CourseSearchName.Name = "txt_CourseSearchName";
            this.txt_CourseSearchName.Size = new System.Drawing.Size(178, 26);
            this.txt_CourseSearchName.TabIndex = 8;
            // 
            // btn_CourseNameSearch
            // 
            this.btn_CourseNameSearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseNameSearch.Location = new System.Drawing.Point(633, 44);
            this.btn_CourseNameSearch.Name = "btn_CourseNameSearch";
            this.btn_CourseNameSearch.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseNameSearch.TabIndex = 7;
            this.btn_CourseNameSearch.UseVisualStyleBackColor = true;
            this.btn_CourseNameSearch.Click += new System.EventHandler(this.btn_CourseNameSearch_Click);
            // 
            // erp_Course
            // 
            this.erp_Course.ContainerControl = this;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_CorseLevelCount;
        private System.Windows.Forms.TextBox txt_CourseTuition;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Course;
        private System.Windows.Forms.Button btn_CourseInsert;
        private System.Windows.Forms.Button btn_CourseEdit;
        private System.Windows.Forms.Button btn_CourseDelete;
        private System.Windows.Forms.Button btn_CoursePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Button btn_MoreCourseSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CourseSearchName;
        private System.Windows.Forms.Button btn_CourseNameSearch;
        private System.Windows.Forms.ErrorProvider erp_Course;
    }
}