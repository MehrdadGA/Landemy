namespace Landemy.Forms
{
    partial class TeacherForm
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
            this.pnl_TeacherTools = new System.Windows.Forms.Panel();
            this.com_TeacherDegree = new System.Windows.Forms.ComboBox();
            this.lbl_TeacherDegree = new System.Windows.Forms.Label();
            this.datePicker1 = new PersianDate.DatePicker();
            this.btn_TeacherSavePic = new System.Windows.Forms.Button();
            this.btn_TeacherAddPic = new System.Windows.Forms.Button();
            this.com_TeahcerSex = new System.Windows.Forms.ComboBox();
            this.pic_Teacher = new System.Windows.Forms.PictureBox();
            this.txt_TeacherAddress = new System.Windows.Forms.TextBox();
            this.txt_TeacherPhone = new System.Windows.Forms.TextBox();
            this.txt_TeacherLastName = new System.Windows.Forms.TextBox();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.txt_TeacherNationalCode = new System.Windows.Forms.TextBox();
            this.btn_TeacherEdit = new System.Windows.Forms.Button();
            this.btn_TeacherPrint = new System.Windows.Forms.Button();
            this.btn_TeacherDelete = new System.Windows.Forms.Button();
            this.btn_TeacherInsert = new System.Windows.Forms.Button();
            this.lbl_TeahcerAddress = new System.Windows.Forms.Label();
            this.lbl_TeacherPhone = new System.Windows.Forms.Label();
            this.lbl_TeacherSex = new System.Windows.Forms.Label();
            this.lbl_TeacherDateOfBirth = new System.Windows.Forms.Label();
            this.lbl_TeacherLastName = new System.Windows.Forms.Label();
            this.lbl_TeacherName = new System.Windows.Forms.Label();
            this.lbl_TeacherNationalCode = new System.Windows.Forms.Label();
            this.pnl_TeacherGrid = new System.Windows.Forms.Panel();
            this.grp_TeacherSearch = new System.Windows.Forms.GroupBox();
            this.btn_TeacherSearchLastName = new System.Windows.Forms.Button();
            this.btn_TeacheSearchName = new System.Windows.Forms.Button();
            this.btn_TeacherSearchNationalCode = new System.Windows.Forms.Button();
            this.txt_TeacherSearchLastName = new System.Windows.Forms.TextBox();
            this.txt_TeacherSearchNationalCode = new System.Windows.Forms.TextBox();
            this.txt_TeacherSearchName = new System.Windows.Forms.TextBox();
            this.lbl_TeacherSearchNationalCode = new System.Windows.Forms.Label();
            this.lbl_TacherSearchName = new System.Windows.Forms.Label();
            this.lbl_TeacherSearchLastName = new System.Windows.Forms.Label();
            this.dgv_Teacher = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_teacher = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_TeacherId = new System.Windows.Forms.TextBox();
            this.pnl_TeacherTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Teacher)).BeginInit();
            this.pnl_TeacherGrid.SuspendLayout();
            this.grp_TeacherSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_TeacherTools
            // 
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherId);
            this.pnl_TeacherTools.Controls.Add(this.com_TeacherDegree);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherDegree);
            this.pnl_TeacherTools.Controls.Add(this.datePicker1);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherSavePic);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherAddPic);
            this.pnl_TeacherTools.Controls.Add(this.com_TeahcerSex);
            this.pnl_TeacherTools.Controls.Add(this.pic_Teacher);
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherAddress);
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherPhone);
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherLastName);
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherName);
            this.pnl_TeacherTools.Controls.Add(this.txt_TeacherNationalCode);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherEdit);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherPrint);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherDelete);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherInsert);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeahcerAddress);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherPhone);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherSex);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherDateOfBirth);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherLastName);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherName);
            this.pnl_TeacherTools.Controls.Add(this.lbl_TeacherNationalCode);
            this.pnl_TeacherTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_TeacherTools.Location = new System.Drawing.Point(758, 29);
            this.pnl_TeacherTools.Name = "pnl_TeacherTools";
            this.pnl_TeacherTools.Size = new System.Drawing.Size(319, 572);
            this.pnl_TeacherTools.TabIndex = 3;
            // 
            // com_TeacherDegree
            // 
            this.com_TeacherDegree.FormattingEnabled = true;
            this.com_TeacherDegree.Location = new System.Drawing.Point(124, 140);
            this.com_TeacherDegree.Name = "com_TeacherDegree";
            this.com_TeacherDegree.Size = new System.Drawing.Size(101, 22);
            this.com_TeacherDegree.TabIndex = 21;
            // 
            // lbl_TeacherDegree
            // 
            this.lbl_TeacherDegree.AutoSize = true;
            this.lbl_TeacherDegree.Location = new System.Drawing.Point(230, 143);
            this.lbl_TeacherDegree.Name = "lbl_TeacherDegree";
            this.lbl_TeacherDegree.Size = new System.Drawing.Size(43, 14);
            this.lbl_TeacherDegree.TabIndex = 20;
            this.lbl_TeacherDegree.Text = "مدرک :";
            this.lbl_TeacherDegree.Click += new System.EventHandler(this.lbl_TeacherDegree_Click);
            // 
            // datePicker1
            // 
            this.datePicker1.Date = "1400/08/17";
            this.datePicker1.FocusColor = System.Drawing.Color.Yellow;
            this.datePicker1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.datePicker1.Location = new System.Drawing.Point(104, 177);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker1.Size = new System.Drawing.Size(120, 24);
            this.datePicker1.TabIndex = 4;
            // 
            // btn_TeacherSavePic
            // 
            this.btn_TeacherSavePic.Location = new System.Drawing.Point(8, 177);
            this.btn_TeacherSavePic.Name = "btn_TeacherSavePic";
            this.btn_TeacherSavePic.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherSavePic.TabIndex = 19;
            this.btn_TeacherSavePic.Text = "ذخیره تصویر";
            this.btn_TeacherSavePic.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherAddPic
            // 
            this.btn_TeacherAddPic.Location = new System.Drawing.Point(8, 130);
            this.btn_TeacherAddPic.Name = "btn_TeacherAddPic";
            this.btn_TeacherAddPic.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherAddPic.TabIndex = 18;
            this.btn_TeacherAddPic.Text = "افزودن تصویر";
            this.btn_TeacherAddPic.UseVisualStyleBackColor = true;
            // 
            // com_TeahcerSex
            // 
            this.com_TeahcerSex.FormattingEnabled = true;
            this.com_TeahcerSex.Location = new System.Drawing.Point(124, 211);
            this.com_TeahcerSex.Name = "com_TeahcerSex";
            this.com_TeahcerSex.Size = new System.Drawing.Size(100, 22);
            this.com_TeahcerSex.TabIndex = 2;
            // 
            // pic_Teacher
            // 
            this.pic_Teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Teacher.Location = new System.Drawing.Point(8, 25);
            this.pic_Teacher.Name = "pic_Teacher";
            this.pic_Teacher.Size = new System.Drawing.Size(100, 99);
            this.pic_Teacher.TabIndex = 17;
            this.pic_Teacher.TabStop = false;
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Location = new System.Drawing.Point(124, 286);
            this.txt_TeacherAddress.Multiline = true;
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.Size = new System.Drawing.Size(100, 102);
            this.txt_TeacherAddress.TabIndex = 16;
            // 
            // txt_TeacherPhone
            // 
            this.txt_TeacherPhone.Location = new System.Drawing.Point(124, 251);
            this.txt_TeacherPhone.Name = "txt_TeacherPhone";
            this.txt_TeacherPhone.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherPhone.TabIndex = 15;
            // 
            // txt_TeacherLastName
            // 
            this.txt_TeacherLastName.Location = new System.Drawing.Point(124, 102);
            this.txt_TeacherLastName.Name = "txt_TeacherLastName";
            this.txt_TeacherLastName.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherLastName.TabIndex = 14;
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(124, 62);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherName.TabIndex = 13;
            // 
            // txt_TeacherNationalCode
            // 
            this.txt_TeacherNationalCode.Location = new System.Drawing.Point(124, 25);
            this.txt_TeacherNationalCode.Name = "txt_TeacherNationalCode";
            this.txt_TeacherNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherNationalCode.TabIndex = 12;
            // 
            // btn_TeacherEdit
            // 
            this.btn_TeacherEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_TeacherEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherEdit.Location = new System.Drawing.Point(124, 467);
            this.btn_TeacherEdit.Name = "btn_TeacherEdit";
            this.btn_TeacherEdit.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherEdit.TabIndex = 11;
            this.btn_TeacherEdit.Text = "ویرایش";
            this.btn_TeacherEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherEdit.UseVisualStyleBackColor = true;
            this.btn_TeacherEdit.Click += new System.EventHandler(this.btn_TeacherEdit_Click);
            // 
            // btn_TeacherPrint
            // 
            this.btn_TeacherPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_TeacherPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherPrint.Location = new System.Drawing.Point(124, 514);
            this.btn_TeacherPrint.Name = "btn_TeacherPrint";
            this.btn_TeacherPrint.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherPrint.TabIndex = 10;
            this.btn_TeacherPrint.Text = "چاپ";
            this.btn_TeacherPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherPrint.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherDelete
            // 
            this.btn_TeacherDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_TeacherDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherDelete.Location = new System.Drawing.Point(217, 514);
            this.btn_TeacherDelete.Name = "btn_TeacherDelete";
            this.btn_TeacherDelete.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherDelete.TabIndex = 9;
            this.btn_TeacherDelete.Text = "حذف";
            this.btn_TeacherDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherDelete.UseVisualStyleBackColor = true;
            this.btn_TeacherDelete.Click += new System.EventHandler(this.btn_TeacherDelete_Click);
            // 
            // btn_TeacherInsert
            // 
            this.btn_TeacherInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_TeacherInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherInsert.Location = new System.Drawing.Point(217, 467);
            this.btn_TeacherInsert.Name = "btn_TeacherInsert";
            this.btn_TeacherInsert.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherInsert.TabIndex = 8;
            this.btn_TeacherInsert.Text = "افزودن";
            this.btn_TeacherInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherInsert.UseVisualStyleBackColor = true;
            this.btn_TeacherInsert.Click += new System.EventHandler(this.btn_TeacherInsert_Click);
            // 
            // lbl_TeahcerAddress
            // 
            this.lbl_TeahcerAddress.AutoSize = true;
            this.lbl_TeahcerAddress.Location = new System.Drawing.Point(230, 289);
            this.lbl_TeahcerAddress.Name = "lbl_TeahcerAddress";
            this.lbl_TeahcerAddress.Size = new System.Drawing.Size(43, 14);
            this.lbl_TeahcerAddress.TabIndex = 7;
            this.lbl_TeahcerAddress.Text = "آدرس :";
            // 
            // lbl_TeacherPhone
            // 
            this.lbl_TeacherPhone.AutoSize = true;
            this.lbl_TeacherPhone.Location = new System.Drawing.Point(230, 254);
            this.lbl_TeacherPhone.Name = "lbl_TeacherPhone";
            this.lbl_TeacherPhone.Size = new System.Drawing.Size(37, 14);
            this.lbl_TeacherPhone.TabIndex = 6;
            this.lbl_TeacherPhone.Text = "تلفن :";
            // 
            // lbl_TeacherSex
            // 
            this.lbl_TeacherSex.AutoSize = true;
            this.lbl_TeacherSex.Location = new System.Drawing.Point(230, 214);
            this.lbl_TeacherSex.Name = "lbl_TeacherSex";
            this.lbl_TeacherSex.Size = new System.Drawing.Size(55, 14);
            this.lbl_TeacherSex.TabIndex = 5;
            this.lbl_TeacherSex.Text = "جنسیت :";
            // 
            // lbl_TeacherDateOfBirth
            // 
            this.lbl_TeacherDateOfBirth.AutoSize = true;
            this.lbl_TeacherDateOfBirth.Location = new System.Drawing.Point(230, 177);
            this.lbl_TeacherDateOfBirth.Name = "lbl_TeacherDateOfBirth";
            this.lbl_TeacherDateOfBirth.Size = new System.Drawing.Size(59, 14);
            this.lbl_TeacherDateOfBirth.TabIndex = 4;
            this.lbl_TeacherDateOfBirth.Text = "تاریخ تولد :";
            // 
            // lbl_TeacherLastName
            // 
            this.lbl_TeacherLastName.AutoSize = true;
            this.lbl_TeacherLastName.Location = new System.Drawing.Point(230, 105);
            this.lbl_TeacherLastName.Name = "lbl_TeacherLastName";
            this.lbl_TeacherLastName.Size = new System.Drawing.Size(80, 14);
            this.lbl_TeacherLastName.TabIndex = 3;
            this.lbl_TeacherLastName.Text = "نام خانوادگی :";
            // 
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(230, 65);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(29, 14);
            this.lbl_TeacherName.TabIndex = 2;
            this.lbl_TeacherName.Text = "نام :";
            // 
            // lbl_TeacherNationalCode
            // 
            this.lbl_TeacherNationalCode.AutoSize = true;
            this.lbl_TeacherNationalCode.Location = new System.Drawing.Point(230, 28);
            this.lbl_TeacherNationalCode.Name = "lbl_TeacherNationalCode";
            this.lbl_TeacherNationalCode.Size = new System.Drawing.Size(54, 14);
            this.lbl_TeacherNationalCode.TabIndex = 1;
            this.lbl_TeacherNationalCode.Text = "کد ملی :";
            // 
            // pnl_TeacherGrid
            // 
            this.pnl_TeacherGrid.Controls.Add(this.grp_TeacherSearch);
            this.pnl_TeacherGrid.Controls.Add(this.dgv_Teacher);
            this.pnl_TeacherGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_TeacherGrid.Location = new System.Drawing.Point(0, 29);
            this.pnl_TeacherGrid.Name = "pnl_TeacherGrid";
            this.pnl_TeacherGrid.Size = new System.Drawing.Size(760, 572);
            this.pnl_TeacherGrid.TabIndex = 0;
            // 
            // grp_TeacherSearch
            // 
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacherSearchLastName);
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacheSearchName);
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacherSearchNationalCode);
            this.grp_TeacherSearch.Controls.Add(this.txt_TeacherSearchLastName);
            this.grp_TeacherSearch.Controls.Add(this.txt_TeacherSearchNationalCode);
            this.grp_TeacherSearch.Controls.Add(this.txt_TeacherSearchName);
            this.grp_TeacherSearch.Controls.Add(this.lbl_TeacherSearchNationalCode);
            this.grp_TeacherSearch.Controls.Add(this.lbl_TacherSearchName);
            this.grp_TeacherSearch.Controls.Add(this.lbl_TeacherSearchLastName);
            this.grp_TeacherSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_TeacherSearch.Location = new System.Drawing.Point(0, 496);
            this.grp_TeacherSearch.Name = "grp_TeacherSearch";
            this.grp_TeacherSearch.Size = new System.Drawing.Size(760, 76);
            this.grp_TeacherSearch.TabIndex = 1;
            this.grp_TeacherSearch.TabStop = false;
            this.grp_TeacherSearch.Text = "جستجو";
            // 
            // btn_TeacherSearchLastName
            // 
            this.btn_TeacherSearchLastName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchLastName.Location = new System.Drawing.Point(92, 27);
            this.btn_TeacherSearchLastName.Name = "btn_TeacherSearchLastName";
            this.btn_TeacherSearchLastName.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacherSearchLastName.TabIndex = 2;
            this.btn_TeacherSearchLastName.UseVisualStyleBackColor = true;
            this.btn_TeacherSearchLastName.Click += new System.EventHandler(this.btn_TeacherSearchLastName_Click);
            // 
            // btn_TeacheSearchName
            // 
            this.btn_TeacheSearchName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacheSearchName.Location = new System.Drawing.Point(339, 27);
            this.btn_TeacheSearchName.Name = "btn_TeacheSearchName";
            this.btn_TeacheSearchName.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacheSearchName.TabIndex = 3;
            this.btn_TeacheSearchName.UseVisualStyleBackColor = true;
            this.btn_TeacheSearchName.Click += new System.EventHandler(this.btn_TeacheSearchName_Click);
            // 
            // btn_TeacherSearchNationalCode
            // 
            this.btn_TeacherSearchNationalCode.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchNationalCode.Location = new System.Drawing.Point(548, 27);
            this.btn_TeacherSearchNationalCode.Name = "btn_TeacherSearchNationalCode";
            this.btn_TeacherSearchNationalCode.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacherSearchNationalCode.TabIndex = 4;
            this.btn_TeacherSearchNationalCode.UseVisualStyleBackColor = true;
            this.btn_TeacherSearchNationalCode.Click += new System.EventHandler(this.btn_TeacherSearchNationalCode_Click);
            // 
            // txt_TeacherSearchLastName
            // 
            this.txt_TeacherSearchLastName.Location = new System.Drawing.Point(136, 33);
            this.txt_TeacherSearchLastName.Name = "txt_TeacherSearchLastName";
            this.txt_TeacherSearchLastName.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherSearchLastName.TabIndex = 5;
            // 
            // txt_TeacherSearchNationalCode
            // 
            this.txt_TeacherSearchNationalCode.Location = new System.Drawing.Point(592, 33);
            this.txt_TeacherSearchNationalCode.Name = "txt_TeacherSearchNationalCode";
            this.txt_TeacherSearchNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherSearchNationalCode.TabIndex = 4;
            // 
            // txt_TeacherSearchName
            // 
            this.txt_TeacherSearchName.Location = new System.Drawing.Point(383, 33);
            this.txt_TeacherSearchName.Name = "txt_TeacherSearchName";
            this.txt_TeacherSearchName.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherSearchName.TabIndex = 3;
            // 
            // lbl_TeacherSearchNationalCode
            // 
            this.lbl_TeacherSearchNationalCode.AutoSize = true;
            this.lbl_TeacherSearchNationalCode.Location = new System.Drawing.Point(698, 36);
            this.lbl_TeacherSearchNationalCode.Name = "lbl_TeacherSearchNationalCode";
            this.lbl_TeacherSearchNationalCode.Size = new System.Drawing.Size(54, 14);
            this.lbl_TeacherSearchNationalCode.TabIndex = 2;
            this.lbl_TeacherSearchNationalCode.Text = "کد ملی :";
            // 
            // lbl_TacherSearchName
            // 
            this.lbl_TacherSearchName.AutoSize = true;
            this.lbl_TacherSearchName.Location = new System.Drawing.Point(489, 36);
            this.lbl_TacherSearchName.Name = "lbl_TacherSearchName";
            this.lbl_TacherSearchName.Size = new System.Drawing.Size(29, 14);
            this.lbl_TacherSearchName.TabIndex = 1;
            this.lbl_TacherSearchName.Text = "نام :";
            // 
            // lbl_TeacherSearchLastName
            // 
            this.lbl_TeacherSearchLastName.AutoSize = true;
            this.lbl_TeacherSearchLastName.Location = new System.Drawing.Point(242, 36);
            this.lbl_TeacherSearchLastName.Name = "lbl_TeacherSearchLastName";
            this.lbl_TeacherSearchLastName.Size = new System.Drawing.Size(80, 14);
            this.lbl_TeacherSearchLastName.TabIndex = 0;
            this.lbl_TeacherSearchLastName.Text = "نام خانوادگی :";
            // 
            // dgv_Teacher
            // 
            this.dgv_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_Teacher.Location = new System.Drawing.Point(0, 0);
            this.dgv_Teacher.Name = "dgv_Teacher";
            this.dgv_Teacher.Size = new System.Drawing.Size(760, 572);
            this.dgv_Teacher.TabIndex = 0;
            this.dgv_Teacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Teacher_CellClick);
            this.dgv_Teacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Teacher_CellContentClick);
            this.dgv_Teacher.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Teacher_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // erp_teacher
            // 
            this.erp_teacher.ContainerControl = this;
            // 
            // txt_TeacherId
            // 
            this.txt_TeacherId.Location = new System.Drawing.Point(207, 413);
            this.txt_TeacherId.Name = "txt_TeacherId";
            this.txt_TeacherId.Size = new System.Drawing.Size(100, 22);
            this.txt_TeacherId.TabIndex = 22;
            this.txt_TeacherId.Visible = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 601);
            this.Controls.Add(this.pnl_TeacherGrid);
            this.Controls.Add(this.pnl_TeacherTools);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.Controls.SetChildIndex(this.pnl_TeacherTools, 0);
            this.Controls.SetChildIndex(this.pnl_TeacherGrid, 0);
            this.pnl_TeacherTools.ResumeLayout(false);
            this.pnl_TeacherTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Teacher)).EndInit();
            this.pnl_TeacherGrid.ResumeLayout(false);
            this.grp_TeacherSearch.ResumeLayout(false);
            this.grp_TeacherSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_teacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_TeacherTools;
        private System.Windows.Forms.Panel pnl_TeacherGrid;
        private System.Windows.Forms.DataGridView dgv_Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Button btn_TeacherEdit;
        private System.Windows.Forms.Button btn_TeacherPrint;
        private System.Windows.Forms.Button btn_TeacherDelete;
        private System.Windows.Forms.Button btn_TeacherInsert;
        private System.Windows.Forms.Label lbl_TeahcerAddress;
        private System.Windows.Forms.Label lbl_TeacherPhone;
        private System.Windows.Forms.Label lbl_TeacherSex;
        private System.Windows.Forms.Label lbl_TeacherDateOfBirth;
        private System.Windows.Forms.Label lbl_TeacherLastName;
        private System.Windows.Forms.Label lbl_TeacherName;
        private System.Windows.Forms.Label lbl_TeacherNationalCode;
        private System.Windows.Forms.PictureBox pic_Teacher;
        private System.Windows.Forms.TextBox txt_TeacherAddress;
        private System.Windows.Forms.TextBox txt_TeacherPhone;
        private System.Windows.Forms.TextBox txt_TeacherLastName;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.TextBox txt_TeacherNationalCode;
        private System.Windows.Forms.Button btn_TeacherSavePic;
        private System.Windows.Forms.Button btn_TeacherAddPic;
        private System.Windows.Forms.GroupBox grp_TeacherSearch;
        private System.Windows.Forms.Label lbl_TeacherSearchNationalCode;
        private System.Windows.Forms.Label lbl_TacherSearchName;
        private System.Windows.Forms.Label lbl_TeacherSearchLastName;
        private System.Windows.Forms.Button btn_TeacherSearchLastName;
        private System.Windows.Forms.Button btn_TeacheSearchName;
        private System.Windows.Forms.Button btn_TeacherSearchNationalCode;
        private System.Windows.Forms.TextBox txt_TeacherSearchLastName;
        private System.Windows.Forms.TextBox txt_TeacherSearchNationalCode;
        private System.Windows.Forms.TextBox txt_TeacherSearchName;
        private System.Windows.Forms.ComboBox com_TeahcerSex;
        private PersianDate.DatePicker datePicker1;
        private System.Windows.Forms.ComboBox com_TeacherDegree;
        private System.Windows.Forms.Label lbl_TeacherDegree;
        private System.Windows.Forms.ErrorProvider erp_teacher;
        private System.Windows.Forms.TextBox txt_TeacherId;
    }
}