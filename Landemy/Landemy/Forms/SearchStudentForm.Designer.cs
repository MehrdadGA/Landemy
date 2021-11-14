namespace Landemy.Forms
{
    partial class SearchStudentForm
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
            this.pnl_SearchStudent = new System.Windows.Forms.Panel();
            this.btn_StudentPrint = new System.Windows.Forms.Button();
            this.btn_SearchDegreeStd = new System.Windows.Forms.Button();
            this.com_StudentDegreeID_FK = new System.Windows.Forms.ComboBox();
            this.lbl_degreeOfStudent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.com_StudentSex = new System.Windows.Forms.ComboBox();
            this.lbl_SexOfStudent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_stdFamilySearch = new System.Windows.Forms.Button();
            this.btn_StdSearchName = new System.Windows.Forms.Button();
            this.btn_StdNationalcodeSearch = new System.Windows.Forms.Button();
            this.txt_NationalSearch = new BaseControl.BaseTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NameSearch = new System.Windows.Forms.TextBox();
            this.txt_FamilySearch = new System.Windows.Forms.TextBox();
            this.dgv_SearchStudent = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_SearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SearchStudent
            // 
            this.pnl_SearchStudent.Controls.Add(this.btn_StudentPrint);
            this.pnl_SearchStudent.Controls.Add(this.btn_SearchDegreeStd);
            this.pnl_SearchStudent.Controls.Add(this.com_StudentDegreeID_FK);
            this.pnl_SearchStudent.Controls.Add(this.lbl_degreeOfStudent);
            this.pnl_SearchStudent.Controls.Add(this.button2);
            this.pnl_SearchStudent.Controls.Add(this.com_StudentSex);
            this.pnl_SearchStudent.Controls.Add(this.lbl_SexOfStudent);
            this.pnl_SearchStudent.Controls.Add(this.button1);
            this.pnl_SearchStudent.Controls.Add(this.btn_stdFamilySearch);
            this.pnl_SearchStudent.Controls.Add(this.btn_StdSearchName);
            this.pnl_SearchStudent.Controls.Add(this.btn_StdNationalcodeSearch);
            this.pnl_SearchStudent.Controls.Add(this.txt_NationalSearch);
            this.pnl_SearchStudent.Controls.Add(this.label1);
            this.pnl_SearchStudent.Controls.Add(this.label2);
            this.pnl_SearchStudent.Controls.Add(this.label3);
            this.pnl_SearchStudent.Controls.Add(this.txt_NameSearch);
            this.pnl_SearchStudent.Controls.Add(this.txt_FamilySearch);
            this.pnl_SearchStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SearchStudent.Location = new System.Drawing.Point(0, 29);
            this.pnl_SearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_SearchStudent.Name = "pnl_SearchStudent";
            this.pnl_SearchStudent.Size = new System.Drawing.Size(1066, 168);
            this.pnl_SearchStudent.TabIndex = 2;
            this.pnl_SearchStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SearchStudent_Paint);
            // 
            // btn_StudentPrint
            // 
            this.btn_StudentPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_StudentPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StudentPrint.Location = new System.Drawing.Point(3, 105);
            this.btn_StudentPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StudentPrint.Name = "btn_StudentPrint";
            this.btn_StudentPrint.Size = new System.Drawing.Size(99, 53);
            this.btn_StudentPrint.TabIndex = 43;
            this.btn_StudentPrint.Text = "چاپ";
            this.btn_StudentPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StudentPrint.UseVisualStyleBackColor = true;
            // 
            // btn_SearchDegreeStd
            // 
            this.btn_SearchDegreeStd.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_SearchDegreeStd.Location = new System.Drawing.Point(149, 50);
            this.btn_SearchDegreeStd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchDegreeStd.Name = "btn_SearchDegreeStd";
            this.btn_SearchDegreeStd.Size = new System.Drawing.Size(43, 42);
            this.btn_SearchDegreeStd.TabIndex = 42;
            this.btn_SearchDegreeStd.UseVisualStyleBackColor = true;
            this.btn_SearchDegreeStd.Click += new System.EventHandler(this.btn_SearchDegreeStd_Click);
            // 
            // com_StudentDegreeID_FK
            // 
            this.com_StudentDegreeID_FK.FormattingEnabled = true;
            this.com_StudentDegreeID_FK.Location = new System.Drawing.Point(199, 58);
            this.com_StudentDegreeID_FK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_StudentDegreeID_FK.Name = "com_StudentDegreeID_FK";
            this.com_StudentDegreeID_FK.Size = new System.Drawing.Size(161, 26);
            this.com_StudentDegreeID_FK.TabIndex = 41;
            // 
            // lbl_degreeOfStudent
            // 
            this.lbl_degreeOfStudent.AutoSize = true;
            this.lbl_degreeOfStudent.Location = new System.Drawing.Point(367, 62);
            this.lbl_degreeOfStudent.Name = "lbl_degreeOfStudent";
            this.lbl_degreeOfStudent.Size = new System.Drawing.Size(53, 18);
            this.lbl_degreeOfStudent.TabIndex = 40;
            this.lbl_degreeOfStudent.Text = "مدرک :";
            // 
            // button2
            // 
            this.button2.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.button2.Location = new System.Drawing.Point(433, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 42);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // com_StudentSex
            // 
            this.com_StudentSex.FormattingEnabled = true;
            this.com_StudentSex.Location = new System.Drawing.Point(483, 108);
            this.com_StudentSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_StudentSex.Name = "com_StudentSex";
            this.com_StudentSex.Size = new System.Drawing.Size(161, 26);
            this.com_StudentSex.TabIndex = 38;
            // 
            // lbl_SexOfStudent
            // 
            this.lbl_SexOfStudent.AutoSize = true;
            this.lbl_SexOfStudent.Location = new System.Drawing.Point(651, 112);
            this.lbl_SexOfStudent.Name = "lbl_SexOfStudent";
            this.lbl_SexOfStudent.Size = new System.Drawing.Size(68, 18);
            this.lbl_SexOfStudent.TabIndex = 37;
            this.lbl_SexOfStudent.Text = "جنسیت :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 36;
            this.button1.Text = "انتقال";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stdFamilySearch
            // 
            this.btn_stdFamilySearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_stdFamilySearch.Location = new System.Drawing.Point(433, 50);
            this.btn_stdFamilySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_stdFamilySearch.Name = "btn_stdFamilySearch";
            this.btn_stdFamilySearch.Size = new System.Drawing.Size(43, 42);
            this.btn_stdFamilySearch.TabIndex = 35;
            this.btn_stdFamilySearch.UseVisualStyleBackColor = true;
            this.btn_stdFamilySearch.Click += new System.EventHandler(this.btn_stdFamilySearch_Click);
            // 
            // btn_StdSearchName
            // 
            this.btn_StdSearchName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_StdSearchName.Location = new System.Drawing.Point(769, 100);
            this.btn_StdSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StdSearchName.Name = "btn_StdSearchName";
            this.btn_StdSearchName.Size = new System.Drawing.Size(43, 42);
            this.btn_StdSearchName.TabIndex = 34;
            this.btn_StdSearchName.UseVisualStyleBackColor = true;
            this.btn_StdSearchName.Click += new System.EventHandler(this.btn_StdSearchName_Click);
            // 
            // btn_StdNationalcodeSearch
            // 
            this.btn_StdNationalcodeSearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_StdNationalcodeSearch.Location = new System.Drawing.Point(769, 50);
            this.btn_StdNationalcodeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StdNationalcodeSearch.Name = "btn_StdNationalcodeSearch";
            this.btn_StdNationalcodeSearch.Size = new System.Drawing.Size(43, 42);
            this.btn_StdNationalcodeSearch.TabIndex = 33;
            this.btn_StdNationalcodeSearch.UseVisualStyleBackColor = true;
            this.btn_StdNationalcodeSearch.Click += new System.EventHandler(this.btn_StdNationalcodeSearch_Click);
            // 
            // txt_NationalSearch
            // 
            this.txt_NationalSearch.IsNumber = true;
            this.txt_NationalSearch.IsReal = false;
            this.txt_NationalSearch.Location = new System.Drawing.Point(819, 62);
            this.txt_NationalSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_NationalSearch.Name = "txt_NationalSearch";
            this.txt_NationalSearch.Size = new System.Drawing.Size(165, 31);
            this.txt_NationalSearch.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(991, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "کد ملی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(998, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "نام :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "نام خانوادگی :";
            // 
            // txt_NameSearch
            // 
            this.txt_NameSearch.Location = new System.Drawing.Point(819, 108);
            this.txt_NameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NameSearch.Name = "txt_NameSearch";
            this.txt_NameSearch.Size = new System.Drawing.Size(161, 26);
            this.txt_NameSearch.TabIndex = 30;
            // 
            // txt_FamilySearch
            // 
            this.txt_FamilySearch.Location = new System.Drawing.Point(483, 58);
            this.txt_FamilySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FamilySearch.Name = "txt_FamilySearch";
            this.txt_FamilySearch.Size = new System.Drawing.Size(161, 26);
            this.txt_FamilySearch.TabIndex = 31;
            // 
            // dgv_SearchStudent
            // 
            this.dgv_SearchStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber,
            this.ClmImage});
            this.dgv_SearchStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SearchStudent.Location = new System.Drawing.Point(0, 197);
            this.dgv_SearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_SearchStudent.Name = "dgv_SearchStudent";
            this.dgv_SearchStudent.RowHeadersWidth = 51;
            this.dgv_SearchStudent.Size = new System.Drawing.Size(1066, 427);
            this.dgv_SearchStudent.TabIndex = 3;
            this.dgv_SearchStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchStudent_CellContentClick);
            this.dgv_SearchStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchStudent_CellDoubleClick);
            this.dgv_SearchStudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SearchStudent_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // ClmImage
            // 
            this.ClmImage.HeaderText = "تصویر";
            this.ClmImage.MinimumWidth = 6;
            this.ClmImage.Name = "ClmImage";
            this.ClmImage.Width = 125;
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 624);
            this.Controls.Add(this.dgv_SearchStudent);
            this.Controls.Add(this.pnl_SearchStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchStudentForm";
            this.Load += new System.EventHandler(this.SearchStudentForm_Load);
            this.Controls.SetChildIndex(this.pnl_SearchStudent, 0);
            this.Controls.SetChildIndex(this.dgv_SearchStudent, 0);
            this.pnl_SearchStudent.ResumeLayout(false);
            this.pnl_SearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SearchStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Button btn_stdFamilySearch;
        private System.Windows.Forms.Button btn_StdSearchName;
        private System.Windows.Forms.Button btn_StdNationalcodeSearch;
        private BaseControl.BaseTextBox txt_NationalSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NameSearch;
        private System.Windows.Forms.TextBox txt_FamilySearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox com_StudentSex;
        private System.Windows.Forms.Label lbl_SexOfStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_SearchDegreeStd;
        private System.Windows.Forms.ComboBox com_StudentDegreeID_FK;
        private System.Windows.Forms.Label lbl_degreeOfStudent;
        private System.Windows.Forms.Button btn_StudentPrint;
        public System.Windows.Forms.DataGridView dgv_SearchStudent;
        private System.Windows.Forms.DataGridViewImageColumn ClmImage;
    }
}