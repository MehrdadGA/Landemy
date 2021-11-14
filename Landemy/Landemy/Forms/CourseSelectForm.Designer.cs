namespace Landemy.Forms
{
    partial class CourseSelectForm
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
            this.btn_CourseSelectGroup = new System.Windows.Forms.Button();
            this.btn_CourseSelectStudent = new System.Windows.Forms.Button();
            this.btn_CourseSelectCourseGroup = new System.Windows.Forms.Button();
            this.txt_CourseSelectAttendScore = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectStudent = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectCourse = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectFinalScore = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectActivityScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CourseSelectInsert = new System.Windows.Forms.Button();
            this.btn_CourseSelectUpdate = new System.Windows.Forms.Button();
            this.btn_CourseSelectDelete = new System.Windows.Forms.Button();
            this.btn_CourseSelectPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_CourseSelect = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_GroupSelectMoreSearch = new System.Windows.Forms.Button();
            this.btn_CourseSelectYear = new System.Windows.Forms.Button();
            this.btn_CourseSSearchGroup = new System.Windows.Forms.Button();
            this.btn_CourseSelectSearchStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_GroupSelectSearchYear = new System.Windows.Forms.TextBox();
            this.txt_GroupSelectSearchCourse = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectSearchStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.erp_CourseSelect = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseSelect)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_CourseSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CourseSelectGroup);
            this.panel1.Controls.Add(this.btn_CourseSelectStudent);
            this.panel1.Controls.Add(this.btn_CourseSelectCourseGroup);
            this.panel1.Controls.Add(this.txt_CourseSelectAttendScore);
            this.panel1.Controls.Add(this.txt_CourseSelectStudent);
            this.panel1.Controls.Add(this.txt_CourseSelectCourse);
            this.panel1.Controls.Add(this.txt_CourseSelectFinalScore);
            this.panel1.Controls.Add(this.txt_CourseSelectActivityScore);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_CourseSelectInsert);
            this.panel1.Controls.Add(this.btn_CourseSelectUpdate);
            this.panel1.Controls.Add(this.btn_CourseSelectDelete);
            this.panel1.Controls.Add(this.btn_CourseSelectPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 205);
            this.panel1.TabIndex = 2;
            // 
            // btn_CourseSelectGroup
            // 
            this.btn_CourseSelectGroup.Location = new System.Drawing.Point(17, 131);
            this.btn_CourseSelectGroup.Name = "btn_CourseSelectGroup";
            this.btn_CourseSelectGroup.Size = new System.Drawing.Size(210, 53);
            this.btn_CourseSelectGroup.TabIndex = 48;
            this.btn_CourseSelectGroup.Text = "انتخاب گروهی";
            this.btn_CourseSelectGroup.UseVisualStyleBackColor = true;
            this.btn_CourseSelectGroup.Click += new System.EventHandler(this.btn_CourseSelectGroup_Click);
            // 
            // btn_CourseSelectStudent
            // 
            this.btn_CourseSelectStudent.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectStudent.Location = new System.Drawing.Point(589, 27);
            this.btn_CourseSelectStudent.Name = "btn_CourseSelectStudent";
            this.btn_CourseSelectStudent.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectStudent.TabIndex = 47;
            this.btn_CourseSelectStudent.UseVisualStyleBackColor = true;
            this.btn_CourseSelectStudent.Click += new System.EventHandler(this.btn_CourseSelectStudent_Click);
            // 
            // btn_CourseSelectCourseGroup
            // 
            this.btn_CourseSelectCourseGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectCourseGroup.Location = new System.Drawing.Point(589, 77);
            this.btn_CourseSelectCourseGroup.Name = "btn_CourseSelectCourseGroup";
            this.btn_CourseSelectCourseGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectCourseGroup.TabIndex = 46;
            this.btn_CourseSelectCourseGroup.UseVisualStyleBackColor = true;
            this.btn_CourseSelectCourseGroup.Click += new System.EventHandler(this.btn_CourseSelectCourseGroup_Click);
            // 
            // txt_CourseSelectAttendScore
            // 
            this.txt_CourseSelectAttendScore.Location = new System.Drawing.Point(967, 86);
            this.txt_CourseSelectAttendScore.Name = "txt_CourseSelectAttendScore";
            this.txt_CourseSelectAttendScore.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectAttendScore.TabIndex = 45;
            // 
            // txt_CourseSelectStudent
            // 
            this.txt_CourseSelectStudent.Location = new System.Drawing.Point(638, 36);
            this.txt_CourseSelectStudent.Name = "txt_CourseSelectStudent";
            this.txt_CourseSelectStudent.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectStudent.TabIndex = 41;
            // 
            // txt_CourseSelectCourse
            // 
            this.txt_CourseSelectCourse.Location = new System.Drawing.Point(638, 86);
            this.txt_CourseSelectCourse.Name = "txt_CourseSelectCourse";
            this.txt_CourseSelectCourse.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectCourse.TabIndex = 39;
            // 
            // txt_CourseSelectFinalScore
            // 
            this.txt_CourseSelectFinalScore.Location = new System.Drawing.Point(967, 145);
            this.txt_CourseSelectFinalScore.Name = "txt_CourseSelectFinalScore";
            this.txt_CourseSelectFinalScore.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectFinalScore.TabIndex = 38;
            // 
            // txt_CourseSelectActivityScore
            // 
            this.txt_CourseSelectActivityScore.Location = new System.Drawing.Point(967, 36);
            this.txt_CourseSelectActivityScore.Name = "txt_CourseSelectActivityScore";
            this.txt_CourseSelectActivityScore.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectActivityScore.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "گروه درسی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "دانشجو :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1120, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "نمره پایانی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1120, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "نمره حضور غیاب :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "نمره فعالیت :";
            // 
            // btn_CourseSelectInsert
            // 
            this.btn_CourseSelectInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_CourseSelectInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseSelectInsert.Location = new System.Drawing.Point(128, 9);
            this.btn_CourseSelectInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseSelectInsert.Name = "btn_CourseSelectInsert";
            this.btn_CourseSelectInsert.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseSelectInsert.TabIndex = 27;
            this.btn_CourseSelectInsert.Text = "افزودن";
            this.btn_CourseSelectInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseSelectInsert.UseVisualStyleBackColor = true;
            this.btn_CourseSelectInsert.Click += new System.EventHandler(this.btn_CourseSelectInsert_Click);
            // 
            // btn_CourseSelectUpdate
            // 
            this.btn_CourseSelectUpdate.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_CourseSelectUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseSelectUpdate.Location = new System.Drawing.Point(17, 9);
            this.btn_CourseSelectUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseSelectUpdate.Name = "btn_CourseSelectUpdate";
            this.btn_CourseSelectUpdate.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseSelectUpdate.TabIndex = 28;
            this.btn_CourseSelectUpdate.Text = "ویرایش";
            this.btn_CourseSelectUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseSelectUpdate.UseVisualStyleBackColor = true;
            this.btn_CourseSelectUpdate.Click += new System.EventHandler(this.btn_CourseSelectUpdate_Click);
            // 
            // btn_CourseSelectDelete
            // 
            this.btn_CourseSelectDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_CourseSelectDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseSelectDelete.Location = new System.Drawing.Point(128, 70);
            this.btn_CourseSelectDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseSelectDelete.Name = "btn_CourseSelectDelete";
            this.btn_CourseSelectDelete.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseSelectDelete.TabIndex = 26;
            this.btn_CourseSelectDelete.Text = "حذف";
            this.btn_CourseSelectDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseSelectDelete.UseVisualStyleBackColor = true;
            this.btn_CourseSelectDelete.Click += new System.EventHandler(this.btn_CourseSelectDelete_Click);
            // 
            // btn_CourseSelectPrint
            // 
            this.btn_CourseSelectPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_CourseSelectPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseSelectPrint.Location = new System.Drawing.Point(17, 70);
            this.btn_CourseSelectPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseSelectPrint.Name = "btn_CourseSelectPrint";
            this.btn_CourseSelectPrint.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseSelectPrint.TabIndex = 25;
            this.btn_CourseSelectPrint.Text = "چاپ";
            this.btn_CourseSelectPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseSelectPrint.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_CourseSelect);
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 458);
            this.panel2.TabIndex = 3;
            // 
            // dgv_CourseSelect
            // 
            this.dgv_CourseSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CourseSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_CourseSelect.Location = new System.Drawing.Point(0, 0);
            this.dgv_CourseSelect.Name = "dgv_CourseSelect";
            this.dgv_CourseSelect.RowHeadersWidth = 51;
            this.dgv_CourseSelect.Size = new System.Drawing.Size(1251, 458);
            this.dgv_CourseSelect.TabIndex = 0;
            this.dgv_CourseSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CourseSelect_CellClick);
            this.dgv_CourseSelect.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CourseSelect_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_GroupSelectMoreSearch);
            this.panel3.Controls.Add(this.btn_CourseSelectYear);
            this.panel3.Controls.Add(this.btn_CourseSSearchGroup);
            this.panel3.Controls.Add(this.btn_CourseSelectSearchStudent);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_GroupSelectSearchYear);
            this.panel3.Controls.Add(this.txt_GroupSelectSearchCourse);
            this.panel3.Controls.Add(this.txt_CourseSelectSearchStudent);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 681);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 104);
            this.panel3.TabIndex = 3;
            // 
            // btn_GroupSelectMoreSearch
            // 
            this.btn_GroupSelectMoreSearch.Location = new System.Drawing.Point(12, 27);
            this.btn_GroupSelectMoreSearch.Name = "btn_GroupSelectMoreSearch";
            this.btn_GroupSelectMoreSearch.Size = new System.Drawing.Size(104, 51);
            this.btn_GroupSelectMoreSearch.TabIndex = 51;
            this.btn_GroupSelectMoreSearch.Text = "جستجوی بیشتر";
            this.btn_GroupSelectMoreSearch.UseVisualStyleBackColor = true;
            this.btn_GroupSelectMoreSearch.Click += new System.EventHandler(this.btn_GroupSelectMoreSearch_Click);
            // 
            // btn_CourseSelectYear
            // 
            this.btn_CourseSelectYear.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectYear.Location = new System.Drawing.Point(281, 31);
            this.btn_CourseSelectYear.Name = "btn_CourseSelectYear";
            this.btn_CourseSelectYear.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectYear.TabIndex = 48;
            this.btn_CourseSelectYear.UseVisualStyleBackColor = true;
            this.btn_CourseSelectYear.Click += new System.EventHandler(this.btn_CourseSelectYear_Click);
            // 
            // btn_CourseSSearchGroup
            // 
            this.btn_CourseSSearchGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSSearchGroup.Location = new System.Drawing.Point(598, 31);
            this.btn_CourseSSearchGroup.Name = "btn_CourseSSearchGroup";
            this.btn_CourseSSearchGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSSearchGroup.TabIndex = 49;
            this.btn_CourseSSearchGroup.UseVisualStyleBackColor = true;
            this.btn_CourseSSearchGroup.Click += new System.EventHandler(this.btn_CourseSSearchGroup_Click);
            // 
            // btn_CourseSelectSearchStudent
            // 
            this.btn_CourseSelectSearchStudent.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectSearchStudent.Location = new System.Drawing.Point(918, 31);
            this.btn_CourseSelectSearchStudent.Name = "btn_CourseSelectSearchStudent";
            this.btn_CourseSelectSearchStudent.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectSearchStudent.TabIndex = 50;
            this.btn_CourseSelectSearchStudent.UseVisualStyleBackColor = true;
            this.btn_CourseSelectSearchStudent.Click += new System.EventHandler(this.btn_CourseSelectSearchStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "سال :";
            // 
            // txt_GroupSelectSearchYear
            // 
            this.txt_GroupSelectSearchYear.Location = new System.Drawing.Point(330, 40);
            this.txt_GroupSelectSearchYear.Name = "txt_GroupSelectSearchYear";
            this.txt_GroupSelectSearchYear.Size = new System.Drawing.Size(147, 26);
            this.txt_GroupSelectSearchYear.TabIndex = 42;
            // 
            // txt_GroupSelectSearchCourse
            // 
            this.txt_GroupSelectSearchCourse.Location = new System.Drawing.Point(647, 40);
            this.txt_GroupSelectSearchCourse.Name = "txt_GroupSelectSearchCourse";
            this.txt_GroupSelectSearchCourse.Size = new System.Drawing.Size(147, 26);
            this.txt_GroupSelectSearchCourse.TabIndex = 43;
            // 
            // txt_CourseSelectSearchStudent
            // 
            this.txt_CourseSelectSearchStudent.Location = new System.Drawing.Point(967, 40);
            this.txt_CourseSelectSearchStudent.Name = "txt_CourseSelectSearchStudent";
            this.txt_CourseSelectSearchStudent.Size = new System.Drawing.Size(147, 26);
            this.txt_CourseSelectSearchStudent.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(800, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "گروه درسی :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1120, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "دانشجو :";
            // 
            // erp_CourseSelect
            // 
            this.erp_CourseSelect.ContainerControl = this;
            // 
            // CourseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CourseSelectForm";
            this.Load += new System.EventHandler(this.CourseSelectForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseSelect)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_CourseSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_CourseSelect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CourseSelectInsert;
        private System.Windows.Forms.Button btn_CourseSelectUpdate;
        private System.Windows.Forms.Button btn_CourseSelectDelete;
        private System.Windows.Forms.Button btn_CourseSelectPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_CourseSelectCourseGroup;
        private System.Windows.Forms.TextBox txt_CourseSelectAttendScore;
        private System.Windows.Forms.TextBox txt_CourseSelectStudent;
        private System.Windows.Forms.TextBox txt_CourseSelectCourse;
        private System.Windows.Forms.TextBox txt_CourseSelectFinalScore;
        private System.Windows.Forms.TextBox txt_CourseSelectActivityScore;
        private System.Windows.Forms.TextBox txt_GroupSelectSearchYear;
        private System.Windows.Forms.TextBox txt_GroupSelectSearchCourse;
        private System.Windows.Forms.TextBox txt_CourseSelectSearchStudent;
        private System.Windows.Forms.Button btn_CourseSelectStudent;
        private System.Windows.Forms.Button btn_CourseSelectYear;
        private System.Windows.Forms.Button btn_CourseSSearchGroup;
        private System.Windows.Forms.Button btn_CourseSelectSearchStudent;
        private System.Windows.Forms.Button btn_GroupSelectMoreSearch;
        private System.Windows.Forms.ErrorProvider erp_CourseSelect;
        private System.Windows.Forms.Button btn_CourseSelectGroup;
    }
}