namespace Landemy.Forms
{
    partial class StudentForm
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
            this.grp_SearchStudent = new System.Windows.Forms.GroupBox();
            this.btn_stdFamilySearch = new System.Windows.Forms.Button();
            this.btn_StdSearchName = new System.Windows.Forms.Button();
            this.btn_StdNationalcodeSearch = new System.Windows.Forms.Button();
            this.txt_NationalSearch = new BaseControl.BaseTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NameSearch = new System.Windows.Forms.TextBox();
            this.txt_FamilySearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_StudentNationalCode = new BaseControl.BaseTextBox();
            this.btn_StudentPicSave = new System.Windows.Forms.Button();
            this.datePicker = new PersianDate.DatePicker();
            this.baseTextBox2 = new BaseControl.BaseTextBox();
            this.btn_StudentOpenPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_StudentInsert = new System.Windows.Forms.Button();
            this.btn_StudentEdit = new System.Windows.Forms.Button();
            this.btn_StudentDelete = new System.Windows.Forms.Button();
            this.btn_StudentPrint = new System.Windows.Forms.Button();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.com_StudentSex = new System.Windows.Forms.ComboBox();
            this.com_StudentDegreeID_FK = new System.Windows.Forms.ComboBox();
            this.txt_StudentLastName = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.lbl_PhoneStudent = new System.Windows.Forms.Label();
            this.lbl_AddressStudent = new System.Windows.Forms.Label();
            this.lbl_DateofBirthStudent = new System.Windows.Forms.Label();
            this.lbl_SexOfStudent = new System.Windows.Forms.Label();
            this.lbl_degreeOfStudent = new System.Windows.Forms.Label();
            this.lbl_LastNameStudent = new System.Windows.Forms.Label();
            this.lbl_FirstNameStudent = new System.Windows.Forms.Label();
            this.lbl_NationalCodeStudent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePicker1 = new PersianDate.DatePicker();
            this.erp_Student = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_SearchStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_SearchStudent
            // 
            this.grp_SearchStudent.Controls.Add(this.btn_stdFamilySearch);
            this.grp_SearchStudent.Controls.Add(this.btn_StdSearchName);
            this.grp_SearchStudent.Controls.Add(this.btn_StdNationalcodeSearch);
            this.grp_SearchStudent.Controls.Add(this.txt_NationalSearch);
            this.grp_SearchStudent.Controls.Add(this.label1);
            this.grp_SearchStudent.Controls.Add(this.label2);
            this.grp_SearchStudent.Controls.Add(this.label3);
            this.grp_SearchStudent.Controls.Add(this.txt_NameSearch);
            this.grp_SearchStudent.Controls.Add(this.txt_FamilySearch);
            this.grp_SearchStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_SearchStudent.Location = new System.Drawing.Point(0, 521);
            this.grp_SearchStudent.Name = "grp_SearchStudent";
            this.grp_SearchStudent.Size = new System.Drawing.Size(1066, 96);
            this.grp_SearchStudent.TabIndex = 2;
            this.grp_SearchStudent.TabStop = false;
            this.grp_SearchStudent.Text = "جستجو";
            // 
            // btn_stdFamilySearch
            // 
            this.btn_stdFamilySearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_stdFamilySearch.Location = new System.Drawing.Point(249, 20);
            this.btn_stdFamilySearch.Name = "btn_stdFamilySearch";
            this.btn_stdFamilySearch.Size = new System.Drawing.Size(38, 33);
            this.btn_stdFamilySearch.TabIndex = 26;
            this.btn_stdFamilySearch.UseVisualStyleBackColor = true;
            this.btn_stdFamilySearch.Click += new System.EventHandler(this.btn_stdFamilySearch_Click);
            // 
            // btn_StdSearchName
            // 
            this.btn_StdSearchName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_StdSearchName.Location = new System.Drawing.Point(528, 20);
            this.btn_StdSearchName.Name = "btn_StdSearchName";
            this.btn_StdSearchName.Size = new System.Drawing.Size(38, 33);
            this.btn_StdSearchName.TabIndex = 25;
            this.btn_StdSearchName.UseVisualStyleBackColor = true;
            this.btn_StdSearchName.Click += new System.EventHandler(this.btn_StdSearchName_Click);
            // 
            // btn_StdNationalcodeSearch
            // 
            this.btn_StdNationalcodeSearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_StdNationalcodeSearch.Location = new System.Drawing.Point(789, 20);
            this.btn_StdNationalcodeSearch.Name = "btn_StdNationalcodeSearch";
            this.btn_StdNationalcodeSearch.Size = new System.Drawing.Size(38, 33);
            this.btn_StdNationalcodeSearch.TabIndex = 24;
            this.btn_StdNationalcodeSearch.UseVisualStyleBackColor = true;
            this.btn_StdNationalcodeSearch.Click += new System.EventHandler(this.btn_StdNationalcodeSearch_Click);
            // 
            // txt_NationalSearch
            // 
            this.txt_NationalSearch.IsNumber = true;
            this.txt_NationalSearch.IsReal = false;
            this.txt_NationalSearch.Location = new System.Drawing.Point(833, 21);
            this.txt_NationalSearch.Name = "txt_NationalSearch";
            this.txt_NationalSearch.Size = new System.Drawing.Size(164, 22);
            this.txt_NationalSearch.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد ملی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام خانوادگی :";
            // 
            // txt_NameSearch
            // 
            this.txt_NameSearch.Location = new System.Drawing.Point(572, 26);
            this.txt_NameSearch.Name = "txt_NameSearch";
            this.txt_NameSearch.Size = new System.Drawing.Size(141, 22);
            this.txt_NameSearch.TabIndex = 11;
            // 
            // txt_FamilySearch
            // 
            this.txt_FamilySearch.Location = new System.Drawing.Point(293, 26);
            this.txt_FamilySearch.Name = "txt_FamilySearch";
            this.txt_FamilySearch.Size = new System.Drawing.Size(141, 22);
            this.txt_FamilySearch.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_StudentNationalCode);
            this.panel1.Controls.Add(this.btn_StudentPicSave);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.baseTextBox2);
            this.panel1.Controls.Add(this.btn_StudentOpenPic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_StudentInsert);
            this.panel1.Controls.Add(this.btn_StudentEdit);
            this.panel1.Controls.Add(this.btn_StudentDelete);
            this.panel1.Controls.Add(this.btn_StudentPrint);
            this.panel1.Controls.Add(this.txt_StudentAddress);
            this.panel1.Controls.Add(this.com_StudentSex);
            this.panel1.Controls.Add(this.com_StudentDegreeID_FK);
            this.panel1.Controls.Add(this.txt_StudentLastName);
            this.panel1.Controls.Add(this.txtStudentFirstName);
            this.panel1.Controls.Add(this.lbl_PhoneStudent);
            this.panel1.Controls.Add(this.lbl_AddressStudent);
            this.panel1.Controls.Add(this.lbl_DateofBirthStudent);
            this.panel1.Controls.Add(this.lbl_SexOfStudent);
            this.panel1.Controls.Add(this.lbl_degreeOfStudent);
            this.panel1.Controls.Add(this.lbl_LastNameStudent);
            this.panel1.Controls.Add(this.lbl_FirstNameStudent);
            this.panel1.Controls.Add(this.lbl_NationalCodeStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(687, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_StudentNationalCode
            // 
            this.txt_StudentNationalCode.IsNumber = true;
            this.txt_StudentNationalCode.IsReal = false;
            this.txt_StudentNationalCode.Location = new System.Drawing.Point(146, 9);
            this.txt_StudentNationalCode.Name = "txt_StudentNationalCode";
            this.txt_StudentNationalCode.Size = new System.Drawing.Size(141, 20);
            this.txt_StudentNationalCode.TabIndex = 23;
            // 
            // btn_StudentPicSave
            // 
            this.btn_StudentPicSave.Location = new System.Drawing.Point(31, 147);
            this.btn_StudentPicSave.Name = "btn_StudentPicSave";
            this.btn_StudentPicSave.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentPicSave.TabIndex = 26;
            this.btn_StudentPicSave.Text = "ذخیره تصویر";
            this.btn_StudentPicSave.UseVisualStyleBackColor = true;
            this.btn_StudentPicSave.Click += new System.EventHandler(this.btn_StudentPicSave_Click);
            // 
            // datePicker
            // 
            this.datePicker.Date = "1400/08/16";
            this.datePicker.FocusColor = System.Drawing.Color.Yellow;
            this.datePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.datePicker.Location = new System.Drawing.Point(146, 173);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(141, 24);
            this.datePicker.TabIndex = 25;
            // 
            // baseTextBox2
            // 
            this.baseTextBox2.IsNumber = true;
            this.baseTextBox2.IsReal = false;
            this.baseTextBox2.Location = new System.Drawing.Point(146, 215);
            this.baseTextBox2.Name = "baseTextBox2";
            this.baseTextBox2.Size = new System.Drawing.Size(141, 22);
            this.baseTextBox2.TabIndex = 24;
            // 
            // btn_StudentOpenPic
            // 
            this.btn_StudentOpenPic.Location = new System.Drawing.Point(31, 100);
            this.btn_StudentOpenPic.Name = "btn_StudentOpenPic";
            this.btn_StudentOpenPic.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentOpenPic.TabIndex = 22;
            this.btn_StudentOpenPic.Text = "افزودن تصویر";
            this.btn_StudentOpenPic.UseVisualStyleBackColor = true;
            this.btn_StudentOpenPic.Click += new System.EventHandler(this.btn_StudentOpenPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_StudentInsert
            // 
            this.btn_StudentInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_StudentInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StudentInsert.Location = new System.Drawing.Point(274, 393);
            this.btn_StudentInsert.Name = "btn_StudentInsert";
            this.btn_StudentInsert.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentInsert.TabIndex = 19;
            this.btn_StudentInsert.Text = "افزودن";
            this.btn_StudentInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StudentInsert.UseVisualStyleBackColor = true;
            this.btn_StudentInsert.Click += new System.EventHandler(this.btn_StudentInsert_Click_1);
            // 
            // btn_StudentEdit
            // 
            this.btn_StudentEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_StudentEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StudentEdit.Location = new System.Drawing.Point(177, 393);
            this.btn_StudentEdit.Name = "btn_StudentEdit";
            this.btn_StudentEdit.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentEdit.TabIndex = 20;
            this.btn_StudentEdit.Text = "ویرایش";
            this.btn_StudentEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StudentEdit.UseVisualStyleBackColor = true;
            this.btn_StudentEdit.Click += new System.EventHandler(this.btn_StudentEdit_Click);
            // 
            // btn_StudentDelete
            // 
            this.btn_StudentDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_StudentDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StudentDelete.Location = new System.Drawing.Point(274, 440);
            this.btn_StudentDelete.Name = "btn_StudentDelete";
            this.btn_StudentDelete.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentDelete.TabIndex = 18;
            this.btn_StudentDelete.Text = "حذف";
            this.btn_StudentDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StudentDelete.UseVisualStyleBackColor = true;
            this.btn_StudentDelete.Click += new System.EventHandler(this.btn_StudentDelete_Click);
            // 
            // btn_StudentPrint
            // 
            this.btn_StudentPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_StudentPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StudentPrint.Location = new System.Drawing.Point(177, 440);
            this.btn_StudentPrint.Name = "btn_StudentPrint";
            this.btn_StudentPrint.Size = new System.Drawing.Size(87, 41);
            this.btn_StudentPrint.TabIndex = 17;
            this.btn_StudentPrint.Text = "چاپ";
            this.btn_StudentPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StudentPrint.UseVisualStyleBackColor = true;
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Location = new System.Drawing.Point(153, 265);
            this.txt_StudentAddress.Multiline = true;
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.Size = new System.Drawing.Size(134, 112);
            this.txt_StudentAddress.TabIndex = 16;
            // 
            // com_StudentSex
            // 
            this.com_StudentSex.FormattingEnabled = true;
            this.com_StudentSex.Location = new System.Drawing.Point(146, 142);
            this.com_StudentSex.Name = "com_StudentSex";
            this.com_StudentSex.Size = new System.Drawing.Size(141, 22);
            this.com_StudentSex.TabIndex = 14;
            // 
            // com_StudentDegreeID_FK
            // 
            this.com_StudentDegreeID_FK.FormattingEnabled = true;
            this.com_StudentDegreeID_FK.Location = new System.Drawing.Point(146, 110);
            this.com_StudentDegreeID_FK.Name = "com_StudentDegreeID_FK";
            this.com_StudentDegreeID_FK.Size = new System.Drawing.Size(141, 22);
            this.com_StudentDegreeID_FK.TabIndex = 13;
            // 
            // txt_StudentLastName
            // 
            this.txt_StudentLastName.Location = new System.Drawing.Point(146, 71);
            this.txt_StudentLastName.Name = "txt_StudentLastName";
            this.txt_StudentLastName.Size = new System.Drawing.Size(141, 22);
            this.txt_StudentLastName.TabIndex = 12;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(146, 39);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(141, 22);
            this.txtStudentFirstName.TabIndex = 11;
            // 
            // lbl_PhoneStudent
            // 
            this.lbl_PhoneStudent.AutoSize = true;
            this.lbl_PhoneStudent.Location = new System.Drawing.Point(293, 223);
            this.lbl_PhoneStudent.Name = "lbl_PhoneStudent";
            this.lbl_PhoneStudent.Size = new System.Drawing.Size(37, 14);
            this.lbl_PhoneStudent.TabIndex = 8;
            this.lbl_PhoneStudent.Text = "تلفن :";
            // 
            // lbl_AddressStudent
            // 
            this.lbl_AddressStudent.AutoSize = true;
            this.lbl_AddressStudent.Location = new System.Drawing.Point(293, 268);
            this.lbl_AddressStudent.Name = "lbl_AddressStudent";
            this.lbl_AddressStudent.Size = new System.Drawing.Size(43, 14);
            this.lbl_AddressStudent.TabIndex = 7;
            this.lbl_AddressStudent.Text = "آدرس :";
            // 
            // lbl_DateofBirthStudent
            // 
            this.lbl_DateofBirthStudent.AutoSize = true;
            this.lbl_DateofBirthStudent.Location = new System.Drawing.Point(293, 183);
            this.lbl_DateofBirthStudent.Name = "lbl_DateofBirthStudent";
            this.lbl_DateofBirthStudent.Size = new System.Drawing.Size(59, 14);
            this.lbl_DateofBirthStudent.TabIndex = 6;
            this.lbl_DateofBirthStudent.Text = "تاریخ تولد :";
            // 
            // lbl_SexOfStudent
            // 
            this.lbl_SexOfStudent.AutoSize = true;
            this.lbl_SexOfStudent.Location = new System.Drawing.Point(293, 145);
            this.lbl_SexOfStudent.Name = "lbl_SexOfStudent";
            this.lbl_SexOfStudent.Size = new System.Drawing.Size(55, 14);
            this.lbl_SexOfStudent.TabIndex = 5;
            this.lbl_SexOfStudent.Text = "جنسیت :";
            // 
            // lbl_degreeOfStudent
            // 
            this.lbl_degreeOfStudent.AutoSize = true;
            this.lbl_degreeOfStudent.Location = new System.Drawing.Point(293, 113);
            this.lbl_degreeOfStudent.Name = "lbl_degreeOfStudent";
            this.lbl_degreeOfStudent.Size = new System.Drawing.Size(43, 14);
            this.lbl_degreeOfStudent.TabIndex = 4;
            this.lbl_degreeOfStudent.Text = "مدرک :";
            // 
            // lbl_LastNameStudent
            // 
            this.lbl_LastNameStudent.AutoSize = true;
            this.lbl_LastNameStudent.Location = new System.Drawing.Point(293, 79);
            this.lbl_LastNameStudent.Name = "lbl_LastNameStudent";
            this.lbl_LastNameStudent.Size = new System.Drawing.Size(80, 14);
            this.lbl_LastNameStudent.TabIndex = 3;
            this.lbl_LastNameStudent.Text = "نام خانوادگی :";
            // 
            // lbl_FirstNameStudent
            // 
            this.lbl_FirstNameStudent.AutoSize = true;
            this.lbl_FirstNameStudent.Location = new System.Drawing.Point(293, 42);
            this.lbl_FirstNameStudent.Name = "lbl_FirstNameStudent";
            this.lbl_FirstNameStudent.Size = new System.Drawing.Size(29, 14);
            this.lbl_FirstNameStudent.TabIndex = 2;
            this.lbl_FirstNameStudent.Text = "نام :";
            // 
            // lbl_NationalCodeStudent
            // 
            this.lbl_NationalCodeStudent.AutoSize = true;
            this.lbl_NationalCodeStudent.Location = new System.Drawing.Point(293, 9);
            this.lbl_NationalCodeStudent.Name = "lbl_NationalCodeStudent";
            this.lbl_NationalCodeStudent.Size = new System.Drawing.Size(54, 14);
            this.lbl_NationalCodeStudent.TabIndex = 1;
            this.lbl_NationalCodeStudent.Text = "کد ملی :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Student);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 492);
            this.panel2.TabIndex = 0;
            // 
            // dgv_Student
            // 
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_Student.Location = new System.Drawing.Point(3, 0);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.Size = new System.Drawing.Size(685, 492);
            this.dgv_Student.TabIndex = 0;
            this.dgv_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellClick);
            this.dgv_Student.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Student_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // datePicker1
            // 
            this.datePicker1.Date = "1400/08/16";
            this.datePicker1.FocusColor = System.Drawing.Color.Yellow;
            this.datePicker1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.datePicker1.Location = new System.Drawing.Point(150, 173);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker1.Size = new System.Drawing.Size(137, 24);
            this.datePicker1.TabIndex = 25;
            // 
            // erp_Student
            // 
            this.erp_Student.ContainerControl = this;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_SearchStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.Controls.SetChildIndex(this.grp_SearchStudent, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.grp_SearchStudent.ResumeLayout(false);
            this.grp_SearchStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_SearchStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.ComboBox com_StudentSex;
        private System.Windows.Forms.ComboBox com_StudentDegreeID_FK;
        private System.Windows.Forms.TextBox txt_StudentLastName;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label lbl_PhoneStudent;
        private System.Windows.Forms.Label lbl_AddressStudent;
        private System.Windows.Forms.Label lbl_DateofBirthStudent;
        private System.Windows.Forms.Label lbl_SexOfStudent;
        private System.Windows.Forms.Label lbl_degreeOfStudent;
        private System.Windows.Forms.Label lbl_LastNameStudent;
        private System.Windows.Forms.Label lbl_FirstNameStudent;
        private System.Windows.Forms.Label lbl_NationalCodeStudent;
        private System.Windows.Forms.Button btn_StudentInsert;
        private System.Windows.Forms.Button btn_StudentEdit;
        private System.Windows.Forms.Button btn_StudentDelete;
        private System.Windows.Forms.Button btn_StudentPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_StudentOpenPic;
        private BaseControl.BaseTextBox baseTextBox2;
        private BaseControl.BaseTextBox txt_StudentNationalCode;
        private PersianDate.DatePicker datePicker;
        private PersianDate.DatePicker datePicker1;
        private System.Windows.Forms.ErrorProvider erp_Student;
        private System.Windows.Forms.Button btn_StudentPicSave;
        private System.Windows.Forms.Button btn_StdNationalcodeSearch;
        private BaseControl.BaseTextBox txt_NationalSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NameSearch;
        private System.Windows.Forms.TextBox txt_FamilySearch;
        private System.Windows.Forms.Button btn_stdFamilySearch;
        private System.Windows.Forms.Button btn_StdSearchName;
    }
}