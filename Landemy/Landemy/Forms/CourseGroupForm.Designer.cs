namespace Landemy.Forms
{
    partial class CourseGroupForm
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
            this.pnl_CourseGroupGridView = new System.Windows.Forms.Panel();
            this.dgv_CourseGroup = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_CourseGroupTools = new System.Windows.Forms.Panel();
            this.btn_CourseGroupInsert = new System.Windows.Forms.Button();
            this.btn_CourseGroupEdit = new System.Windows.Forms.Button();
            this.btn_CourseGroupDelete = new System.Windows.Forms.Button();
            this.btn_CourseGroupPrint = new System.Windows.Forms.Button();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.btn_CourseName = new System.Windows.Forms.Button();
            this.com_LevelCourseGroup = new System.Windows.Forms.ComboBox();
            this.txt_TuitionCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_TeacherCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_YearCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_TermCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_ClassNumberCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_WeeklyPlanCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_CourseNameCourseGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_GroupCourseSearch = new System.Windows.Forms.Panel();
            this.btn_CourseGroupMoreSearch = new System.Windows.Forms.Button();
            this.btn_YearSearchCourseGroup = new System.Windows.Forms.Button();
            this.btn_CourseNameSearchCourseGroup = new System.Windows.Forms.Button();
            this.btn_TeacherSearchCourseGroup = new System.Windows.Forms.Button();
            this.txt_YearSearchCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_CourseSearchCourseGroup = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TeacherSearchCourseGroup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.erp_CourseGroup = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_CourseGroupGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseGroup)).BeginInit();
            this.pnl_CourseGroupTools.SuspendLayout();
            this.pnl_GroupCourseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_CourseGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_CourseGroupGridView
            // 
            this.pnl_CourseGroupGridView.Controls.Add(this.dgv_CourseGroup);
            this.pnl_CourseGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CourseGroupGridView.Location = new System.Drawing.Point(0, 29);
            this.pnl_CourseGroupGridView.Name = "pnl_CourseGroupGridView";
            this.pnl_CourseGroupGridView.Size = new System.Drawing.Size(1298, 688);
            this.pnl_CourseGroupGridView.TabIndex = 2;
            // 
            // dgv_CourseGroup
            // 
            this.dgv_CourseGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CourseGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_CourseGroup.Location = new System.Drawing.Point(0, 0);
            this.dgv_CourseGroup.Name = "dgv_CourseGroup";
            this.dgv_CourseGroup.RowHeadersWidth = 51;
            this.dgv_CourseGroup.RowTemplate.Height = 24;
            this.dgv_CourseGroup.Size = new System.Drawing.Size(926, 575);
            this.dgv_CourseGroup.TabIndex = 0;
            this.dgv_CourseGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CourseGroup_CellClick);
            this.dgv_CourseGroup.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CourseGroup_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // pnl_CourseGroupTools
            // 
            this.pnl_CourseGroupTools.Controls.Add(this.btn_CourseGroupInsert);
            this.pnl_CourseGroupTools.Controls.Add(this.btn_CourseGroupEdit);
            this.pnl_CourseGroupTools.Controls.Add(this.btn_CourseGroupDelete);
            this.pnl_CourseGroupTools.Controls.Add(this.btn_CourseGroupPrint);
            this.pnl_CourseGroupTools.Controls.Add(this.btn_Teacher);
            this.pnl_CourseGroupTools.Controls.Add(this.btn_CourseName);
            this.pnl_CourseGroupTools.Controls.Add(this.com_LevelCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_TuitionCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_TeacherCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_YearCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_TermCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_ClassNumberCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_WeeklyPlanCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.txt_CourseNameCourseGroup);
            this.pnl_CourseGroupTools.Controls.Add(this.label8);
            this.pnl_CourseGroupTools.Controls.Add(this.label7);
            this.pnl_CourseGroupTools.Controls.Add(this.label6);
            this.pnl_CourseGroupTools.Controls.Add(this.label5);
            this.pnl_CourseGroupTools.Controls.Add(this.label4);
            this.pnl_CourseGroupTools.Controls.Add(this.label3);
            this.pnl_CourseGroupTools.Controls.Add(this.label2);
            this.pnl_CourseGroupTools.Controls.Add(this.label1);
            this.pnl_CourseGroupTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_CourseGroupTools.Location = new System.Drawing.Point(929, 29);
            this.pnl_CourseGroupTools.Name = "pnl_CourseGroupTools";
            this.pnl_CourseGroupTools.Size = new System.Drawing.Size(369, 688);
            this.pnl_CourseGroupTools.TabIndex = 0;
            // 
            // btn_CourseGroupInsert
            // 
            this.btn_CourseGroupInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_CourseGroupInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseGroupInsert.Location = new System.Drawing.Point(230, 505);
            this.btn_CourseGroupInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseGroupInsert.Name = "btn_CourseGroupInsert";
            this.btn_CourseGroupInsert.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseGroupInsert.TabIndex = 28;
            this.btn_CourseGroupInsert.Text = "افزودن";
            this.btn_CourseGroupInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseGroupInsert.UseVisualStyleBackColor = true;
            this.btn_CourseGroupInsert.Click += new System.EventHandler(this.btn_CourseGroupInsert_Click);
            // 
            // btn_CourseGroupEdit
            // 
            this.btn_CourseGroupEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_CourseGroupEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseGroupEdit.Location = new System.Drawing.Point(119, 505);
            this.btn_CourseGroupEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseGroupEdit.Name = "btn_CourseGroupEdit";
            this.btn_CourseGroupEdit.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseGroupEdit.TabIndex = 29;
            this.btn_CourseGroupEdit.Text = "ویرایش";
            this.btn_CourseGroupEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseGroupEdit.UseVisualStyleBackColor = true;
            this.btn_CourseGroupEdit.Click += new System.EventHandler(this.btn_CourseGroupEdit_Click);
            // 
            // btn_CourseGroupDelete
            // 
            this.btn_CourseGroupDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_CourseGroupDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseGroupDelete.Location = new System.Drawing.Point(230, 566);
            this.btn_CourseGroupDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseGroupDelete.Name = "btn_CourseGroupDelete";
            this.btn_CourseGroupDelete.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseGroupDelete.TabIndex = 27;
            this.btn_CourseGroupDelete.Text = "حذف";
            this.btn_CourseGroupDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseGroupDelete.UseVisualStyleBackColor = true;
            this.btn_CourseGroupDelete.Click += new System.EventHandler(this.btn_CourseGroupDelete_Click);
            // 
            // btn_CourseGroupPrint
            // 
            this.btn_CourseGroupPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_CourseGroupPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseGroupPrint.Location = new System.Drawing.Point(119, 566);
            this.btn_CourseGroupPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseGroupPrint.Name = "btn_CourseGroupPrint";
            this.btn_CourseGroupPrint.Size = new System.Drawing.Size(99, 53);
            this.btn_CourseGroupPrint.TabIndex = 26;
            this.btn_CourseGroupPrint.Text = "چاپ";
            this.btn_CourseGroupPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseGroupPrint.UseVisualStyleBackColor = true;
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_Teacher.Location = new System.Drawing.Point(56, 145);
            this.btn_Teacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(43, 42);
            this.btn_Teacher.TabIndex = 24;
            this.btn_Teacher.UseVisualStyleBackColor = true;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // btn_CourseName
            // 
            this.btn_CourseName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseName.Location = new System.Drawing.Point(56, 8);
            this.btn_CourseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseName.Name = "btn_CourseName";
            this.btn_CourseName.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseName.TabIndex = 25;
            this.btn_CourseName.UseVisualStyleBackColor = true;
            this.btn_CourseName.Click += new System.EventHandler(this.btn_CourseName_Click);
            // 
            // com_LevelCourseGroup
            // 
            this.com_LevelCourseGroup.FormattingEnabled = true;
            this.com_LevelCourseGroup.Location = new System.Drawing.Point(105, 108);
            this.com_LevelCourseGroup.Name = "com_LevelCourseGroup";
            this.com_LevelCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.com_LevelCourseGroup.TabIndex = 24;
            // 
            // txt_TuitionCourseGroup
            // 
            this.txt_TuitionCourseGroup.Location = new System.Drawing.Point(105, 61);
            this.txt_TuitionCourseGroup.Name = "txt_TuitionCourseGroup";
            this.txt_TuitionCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_TuitionCourseGroup.TabIndex = 16;
            // 
            // txt_TeacherCourseGroup
            // 
            this.txt_TeacherCourseGroup.Location = new System.Drawing.Point(105, 154);
            this.txt_TeacherCourseGroup.Name = "txt_TeacherCourseGroup";
            this.txt_TeacherCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_TeacherCourseGroup.TabIndex = 15;
            // 
            // txt_YearCourseGroup
            // 
            this.txt_YearCourseGroup.Location = new System.Drawing.Point(105, 202);
            this.txt_YearCourseGroup.Name = "txt_YearCourseGroup";
            this.txt_YearCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_YearCourseGroup.TabIndex = 14;
            // 
            // txt_TermCourseGroup
            // 
            this.txt_TermCourseGroup.Location = new System.Drawing.Point(105, 250);
            this.txt_TermCourseGroup.Name = "txt_TermCourseGroup";
            this.txt_TermCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_TermCourseGroup.TabIndex = 13;
            // 
            // txt_ClassNumberCourseGroup
            // 
            this.txt_ClassNumberCourseGroup.Location = new System.Drawing.Point(105, 303);
            this.txt_ClassNumberCourseGroup.Name = "txt_ClassNumberCourseGroup";
            this.txt_ClassNumberCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_ClassNumberCourseGroup.TabIndex = 12;
            // 
            // txt_WeeklyPlanCourseGroup
            // 
            this.txt_WeeklyPlanCourseGroup.Location = new System.Drawing.Point(105, 356);
            this.txt_WeeklyPlanCourseGroup.Multiline = true;
            this.txt_WeeklyPlanCourseGroup.Name = "txt_WeeklyPlanCourseGroup";
            this.txt_WeeklyPlanCourseGroup.Size = new System.Drawing.Size(145, 117);
            this.txt_WeeklyPlanCourseGroup.TabIndex = 11;
            // 
            // txt_CourseNameCourseGroup
            // 
            this.txt_CourseNameCourseGroup.Location = new System.Drawing.Point(105, 17);
            this.txt_CourseNameCourseGroup.Name = "txt_CourseNameCourseGroup";
            this.txt_CourseNameCourseGroup.Size = new System.Drawing.Size(145, 26);
            this.txt_CourseNameCourseGroup.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "شهریه :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "سطح :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "استاد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "سال :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ترم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "برنامه هفتگی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره کلاس :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام درس :";
            // 
            // pnl_GroupCourseSearch
            // 
            this.pnl_GroupCourseSearch.Controls.Add(this.btn_CourseGroupMoreSearch);
            this.pnl_GroupCourseSearch.Controls.Add(this.btn_YearSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.btn_CourseNameSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.btn_TeacherSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.txt_YearSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.txt_CourseSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.label10);
            this.pnl_GroupCourseSearch.Controls.Add(this.txt_TeacherSearchCourseGroup);
            this.pnl_GroupCourseSearch.Controls.Add(this.label9);
            this.pnl_GroupCourseSearch.Controls.Add(this.label11);
            this.pnl_GroupCourseSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_GroupCourseSearch.Location = new System.Drawing.Point(0, 599);
            this.pnl_GroupCourseSearch.Name = "pnl_GroupCourseSearch";
            this.pnl_GroupCourseSearch.Size = new System.Drawing.Size(929, 118);
            this.pnl_GroupCourseSearch.TabIndex = 0;
            // 
            // btn_CourseGroupMoreSearch
            // 
            this.btn_CourseGroupMoreSearch.Location = new System.Drawing.Point(3, 19);
            this.btn_CourseGroupMoreSearch.Name = "btn_CourseGroupMoreSearch";
            this.btn_CourseGroupMoreSearch.Size = new System.Drawing.Size(84, 49);
            this.btn_CourseGroupMoreSearch.TabIndex = 23;
            this.btn_CourseGroupMoreSearch.Text = "جستجوی بیشتر";
            this.btn_CourseGroupMoreSearch.UseVisualStyleBackColor = true;
            this.btn_CourseGroupMoreSearch.Click += new System.EventHandler(this.btn_CourseGroupMoreSearch_Click);
            // 
            // btn_YearSearchCourseGroup
            // 
            this.btn_YearSearchCourseGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_YearSearchCourseGroup.Location = new System.Drawing.Point(135, 26);
            this.btn_YearSearchCourseGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_YearSearchCourseGroup.Name = "btn_YearSearchCourseGroup";
            this.btn_YearSearchCourseGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_YearSearchCourseGroup.TabIndex = 22;
            this.btn_YearSearchCourseGroup.UseVisualStyleBackColor = true;
            this.btn_YearSearchCourseGroup.Click += new System.EventHandler(this.btn_YearSearchCourseGroup_Click);
            // 
            // btn_CourseNameSearchCourseGroup
            // 
            this.btn_CourseNameSearchCourseGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseNameSearchCourseGroup.Location = new System.Drawing.Point(414, 26);
            this.btn_CourseNameSearchCourseGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CourseNameSearchCourseGroup.Name = "btn_CourseNameSearchCourseGroup";
            this.btn_CourseNameSearchCourseGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseNameSearchCourseGroup.TabIndex = 21;
            this.btn_CourseNameSearchCourseGroup.UseVisualStyleBackColor = true;
            this.btn_CourseNameSearchCourseGroup.Click += new System.EventHandler(this.btn_CourseNameSearchCourseGroup_Click);
            // 
            // btn_TeacherSearchCourseGroup
            // 
            this.btn_TeacherSearchCourseGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchCourseGroup.Location = new System.Drawing.Point(693, 26);
            this.btn_TeacherSearchCourseGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherSearchCourseGroup.Name = "btn_TeacherSearchCourseGroup";
            this.btn_TeacherSearchCourseGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_TeacherSearchCourseGroup.TabIndex = 20;
            this.btn_TeacherSearchCourseGroup.UseVisualStyleBackColor = true;
            this.btn_TeacherSearchCourseGroup.Click += new System.EventHandler(this.btn_TeacherSearchCourseGroup_Click);
            // 
            // txt_YearSearchCourseGroup
            // 
            this.txt_YearSearchCourseGroup.Location = new System.Drawing.Point(184, 35);
            this.txt_YearSearchCourseGroup.Name = "txt_YearSearchCourseGroup";
            this.txt_YearSearchCourseGroup.Size = new System.Drawing.Size(119, 26);
            this.txt_YearSearchCourseGroup.TabIndex = 19;
            // 
            // txt_CourseSearchCourseGroup
            // 
            this.txt_CourseSearchCourseGroup.Location = new System.Drawing.Point(463, 35);
            this.txt_CourseSearchCourseGroup.Name = "txt_CourseSearchCourseGroup";
            this.txt_CourseSearchCourseGroup.Size = new System.Drawing.Size(119, 26);
            this.txt_CourseSearchCourseGroup.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "سال :";
            // 
            // txt_TeacherSearchCourseGroup
            // 
            this.txt_TeacherSearchCourseGroup.Location = new System.Drawing.Point(742, 35);
            this.txt_TeacherSearchCourseGroup.Name = "txt_TeacherSearchCourseGroup";
            this.txt_TeacherSearchCourseGroup.Size = new System.Drawing.Size(119, 26);
            this.txt_TeacherSearchCourseGroup.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(867, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "استاد :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(588, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "نام درس :";
            // 
            // erp_CourseGroup
            // 
            this.erp_CourseGroup.ContainerControl = this;
            // 
            // CourseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 717);
            this.Controls.Add(this.pnl_GroupCourseSearch);
            this.Controls.Add(this.pnl_CourseGroupTools);
            this.Controls.Add(this.pnl_CourseGroupGridView);
            this.Name = "CourseGroupForm";
            this.Load += new System.EventHandler(this.CourseGroupForm_Load);
            this.Controls.SetChildIndex(this.pnl_CourseGroupGridView, 0);
            this.Controls.SetChildIndex(this.pnl_CourseGroupTools, 0);
            this.Controls.SetChildIndex(this.pnl_GroupCourseSearch, 0);
            this.pnl_CourseGroupGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseGroup)).EndInit();
            this.pnl_CourseGroupTools.ResumeLayout(false);
            this.pnl_CourseGroupTools.PerformLayout();
            this.pnl_GroupCourseSearch.ResumeLayout(false);
            this.pnl_GroupCourseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_CourseGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CourseGroupGridView;
        private System.Windows.Forms.DataGridView dgv_CourseGroup;
        private System.Windows.Forms.Panel pnl_CourseGroupTools;
        private System.Windows.Forms.Panel pnl_GroupCourseSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.TextBox txt_TuitionCourseGroup;
        private System.Windows.Forms.TextBox txt_TeacherCourseGroup;
        private System.Windows.Forms.TextBox txt_YearCourseGroup;
        private System.Windows.Forms.TextBox txt_TermCourseGroup;
        private System.Windows.Forms.TextBox txt_ClassNumberCourseGroup;
        private System.Windows.Forms.TextBox txt_WeeklyPlanCourseGroup;
        private System.Windows.Forms.TextBox txt_CourseNameCourseGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_YearSearchCourseGroup;
        private System.Windows.Forms.TextBox txt_CourseSearchCourseGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TeacherSearchCourseGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_YearSearchCourseGroup;
        private System.Windows.Forms.Button btn_CourseNameSearchCourseGroup;
        private System.Windows.Forms.Button btn_TeacherSearchCourseGroup;
        private System.Windows.Forms.Button btn_CourseGroupMoreSearch;
        private System.Windows.Forms.Button btn_Teacher;
        private System.Windows.Forms.Button btn_CourseName;
        private System.Windows.Forms.ComboBox com_LevelCourseGroup;
        private System.Windows.Forms.Button btn_CourseGroupInsert;
        private System.Windows.Forms.Button btn_CourseGroupEdit;
        private System.Windows.Forms.Button btn_CourseGroupDelete;
        private System.Windows.Forms.Button btn_CourseGroupPrint;
        private System.Windows.Forms.ErrorProvider erp_CourseGroup;
    }
}