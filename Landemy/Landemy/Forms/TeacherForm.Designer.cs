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
            this.pnl_TeacherTools = new System.Windows.Forms.Panel();
            this.pnl_TeacherGrid = new System.Windows.Forms.Panel();
            this.dgv_Teacher = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TeacherNationalCode = new System.Windows.Forms.Label();
            this.lbl_TeacherName = new System.Windows.Forms.Label();
            this.lbl_TeacherLastName = new System.Windows.Forms.Label();
            this.lbl_TeacherDateOfBirth = new System.Windows.Forms.Label();
            this.lbl_TeacherSex = new System.Windows.Forms.Label();
            this.lbl_TeacherPhone = new System.Windows.Forms.Label();
            this.lbl_TeahcerAddress = new System.Windows.Forms.Label();
            this.btn_TeacherInsert = new System.Windows.Forms.Button();
            this.btn_TeacherDelete = new System.Windows.Forms.Button();
            this.btn_TeacherPrint = new System.Windows.Forms.Button();
            this.btn_TeacherEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TeacherAddPic = new System.Windows.Forms.Button();
            this.btn_TeacherSavePic = new System.Windows.Forms.Button();
            this.grp_TeacherSearch = new System.Windows.Forms.GroupBox();
            this.lbl_TeacherSearchLastName = new System.Windows.Forms.Label();
            this.lbl_TacherSearchName = new System.Windows.Forms.Label();
            this.lbl_TeacherSearchNationalCode = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btn_TeacherSearchLastName = new System.Windows.Forms.Button();
            this.btn_TeacheSearchName = new System.Windows.Forms.Button();
            this.btn_TeacherSearchNationalCode = new System.Windows.Forms.Button();
            this.pnl_TeacherTools.SuspendLayout();
            this.pnl_TeacherGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_TeacherSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TeacherTools
            // 
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherSavePic);
            this.pnl_TeacherTools.Controls.Add(this.btn_TeacherAddPic);
            this.pnl_TeacherTools.Controls.Add(this.pictureBox1);
            this.pnl_TeacherTools.Controls.Add(this.textBox5);
            this.pnl_TeacherTools.Controls.Add(this.textBox4);
            this.pnl_TeacherTools.Controls.Add(this.textBox3);
            this.pnl_TeacherTools.Controls.Add(this.textBox2);
            this.pnl_TeacherTools.Controls.Add(this.textBox1);
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
            // dgv_Teacher
            // 
            this.dgv_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_Teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Teacher.Location = new System.Drawing.Point(0, 0);
            this.dgv_Teacher.Name = "dgv_Teacher";
            this.dgv_Teacher.Size = new System.Drawing.Size(760, 572);
            this.dgv_Teacher.TabIndex = 0;
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.Name = "ColumnRowNumber";
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
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(230, 65);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(29, 14);
            this.lbl_TeacherName.TabIndex = 2;
            this.lbl_TeacherName.Text = "نام :";
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
            // lbl_TeacherDateOfBirth
            // 
            this.lbl_TeacherDateOfBirth.AutoSize = true;
            this.lbl_TeacherDateOfBirth.Location = new System.Drawing.Point(230, 140);
            this.lbl_TeacherDateOfBirth.Name = "lbl_TeacherDateOfBirth";
            this.lbl_TeacherDateOfBirth.Size = new System.Drawing.Size(59, 14);
            this.lbl_TeacherDateOfBirth.TabIndex = 4;
            this.lbl_TeacherDateOfBirth.Text = "تاریخ تولد :";
            // 
            // lbl_TeacherSex
            // 
            this.lbl_TeacherSex.AutoSize = true;
            this.lbl_TeacherSex.Location = new System.Drawing.Point(230, 177);
            this.lbl_TeacherSex.Name = "lbl_TeacherSex";
            this.lbl_TeacherSex.Size = new System.Drawing.Size(55, 14);
            this.lbl_TeacherSex.TabIndex = 5;
            this.lbl_TeacherSex.Text = "جنسیت :";
            // 
            // lbl_TeacherPhone
            // 
            this.lbl_TeacherPhone.AutoSize = true;
            this.lbl_TeacherPhone.Location = new System.Drawing.Point(230, 217);
            this.lbl_TeacherPhone.Name = "lbl_TeacherPhone";
            this.lbl_TeacherPhone.Size = new System.Drawing.Size(37, 14);
            this.lbl_TeacherPhone.TabIndex = 6;
            this.lbl_TeacherPhone.Text = "تلفن :";
            // 
            // lbl_TeahcerAddress
            // 
            this.lbl_TeahcerAddress.AutoSize = true;
            this.lbl_TeahcerAddress.Location = new System.Drawing.Point(230, 252);
            this.lbl_TeahcerAddress.Name = "lbl_TeahcerAddress";
            this.lbl_TeahcerAddress.Size = new System.Drawing.Size(43, 14);
            this.lbl_TeahcerAddress.TabIndex = 7;
            this.lbl_TeahcerAddress.Text = "آدرس :";
            // 
            // btn_TeacherInsert
            // 
            this.btn_TeacherInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_TeacherInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherInsert.Location = new System.Drawing.Point(220, 357);
            this.btn_TeacherInsert.Name = "btn_TeacherInsert";
            this.btn_TeacherInsert.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherInsert.TabIndex = 8;
            this.btn_TeacherInsert.Text = "افزودن";
            this.btn_TeacherInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherInsert.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherDelete
            // 
            this.btn_TeacherDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_TeacherDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherDelete.Location = new System.Drawing.Point(220, 404);
            this.btn_TeacherDelete.Name = "btn_TeacherDelete";
            this.btn_TeacherDelete.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherDelete.TabIndex = 9;
            this.btn_TeacherDelete.Text = "حذف";
            this.btn_TeacherDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherDelete.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherPrint
            // 
            this.btn_TeacherPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_TeacherPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherPrint.Location = new System.Drawing.Point(127, 404);
            this.btn_TeacherPrint.Name = "btn_TeacherPrint";
            this.btn_TeacherPrint.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherPrint.TabIndex = 10;
            this.btn_TeacherPrint.Text = "چاپ";
            this.btn_TeacherPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherPrint.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherEdit
            // 
            this.btn_TeacherEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_TeacherEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherEdit.Location = new System.Drawing.Point(127, 357);
            this.btn_TeacherEdit.Name = "btn_TeacherEdit";
            this.btn_TeacherEdit.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherEdit.TabIndex = 11;
            this.btn_TeacherEdit.Text = "ویرایش";
            this.btn_TeacherEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherEdit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 249);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 102);
            this.textBox5.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TeacherAddPic
            // 
            this.btn_TeacherAddPic.Location = new System.Drawing.Point(21, 130);
            this.btn_TeacherAddPic.Name = "btn_TeacherAddPic";
            this.btn_TeacherAddPic.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherAddPic.TabIndex = 18;
            this.btn_TeacherAddPic.Text = "افزودن تصویر";
            this.btn_TeacherAddPic.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherSavePic
            // 
            this.btn_TeacherSavePic.Location = new System.Drawing.Point(21, 177);
            this.btn_TeacherSavePic.Name = "btn_TeacherSavePic";
            this.btn_TeacherSavePic.Size = new System.Drawing.Size(87, 41);
            this.btn_TeacherSavePic.TabIndex = 19;
            this.btn_TeacherSavePic.Text = "ذخیره تصویر";
            this.btn_TeacherSavePic.UseVisualStyleBackColor = true;
            // 
            // grp_TeacherSearch
            // 
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacherSearchLastName);
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacheSearchName);
            this.grp_TeacherSearch.Controls.Add(this.btn_TeacherSearchNationalCode);
            this.grp_TeacherSearch.Controls.Add(this.textBox8);
            this.grp_TeacherSearch.Controls.Add(this.textBox7);
            this.grp_TeacherSearch.Controls.Add(this.textBox6);
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
            // lbl_TeacherSearchLastName
            // 
            this.lbl_TeacherSearchLastName.AutoSize = true;
            this.lbl_TeacherSearchLastName.Location = new System.Drawing.Point(242, 36);
            this.lbl_TeacherSearchLastName.Name = "lbl_TeacherSearchLastName";
            this.lbl_TeacherSearchLastName.Size = new System.Drawing.Size(80, 14);
            this.lbl_TeacherSearchLastName.TabIndex = 0;
            this.lbl_TeacherSearchLastName.Text = "نام خانوادگی :";
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
            // lbl_TeacherSearchNationalCode
            // 
            this.lbl_TeacherSearchNationalCode.AutoSize = true;
            this.lbl_TeacherSearchNationalCode.Location = new System.Drawing.Point(698, 36);
            this.lbl_TeacherSearchNationalCode.Name = "lbl_TeacherSearchNationalCode";
            this.lbl_TeacherSearchNationalCode.Size = new System.Drawing.Size(54, 14);
            this.lbl_TeacherSearchNationalCode.TabIndex = 2;
            this.lbl_TeacherSearchNationalCode.Text = "کد ملی :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(383, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(592, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(136, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 5;
            // 
            // btn_TeacherSearchLastName
            // 
            this.btn_TeacherSearchLastName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchLastName.Location = new System.Drawing.Point(92, 27);
            this.btn_TeacherSearchLastName.Name = "btn_TeacherSearchLastName";
            this.btn_TeacherSearchLastName.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacherSearchLastName.TabIndex = 2;
            this.btn_TeacherSearchLastName.UseVisualStyleBackColor = true;
            // 
            // btn_TeacheSearchName
            // 
            this.btn_TeacheSearchName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacheSearchName.Location = new System.Drawing.Point(339, 27);
            this.btn_TeacheSearchName.Name = "btn_TeacheSearchName";
            this.btn_TeacheSearchName.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacheSearchName.TabIndex = 3;
            this.btn_TeacheSearchName.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherSearchNationalCode
            // 
            this.btn_TeacherSearchNationalCode.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchNationalCode.Location = new System.Drawing.Point(548, 27);
            this.btn_TeacherSearchNationalCode.Name = "btn_TeacherSearchNationalCode";
            this.btn_TeacherSearchNationalCode.Size = new System.Drawing.Size(38, 33);
            this.btn_TeacherSearchNationalCode.TabIndex = 4;
            this.btn_TeacherSearchNationalCode.UseVisualStyleBackColor = true;
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
            this.pnl_TeacherGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_TeacherSearch.ResumeLayout(false);
            this.grp_TeacherSearch.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_TeacherSavePic;
        private System.Windows.Forms.Button btn_TeacherAddPic;
        private System.Windows.Forms.GroupBox grp_TeacherSearch;
        private System.Windows.Forms.Label lbl_TeacherSearchNationalCode;
        private System.Windows.Forms.Label lbl_TacherSearchName;
        private System.Windows.Forms.Label lbl_TeacherSearchLastName;
        private System.Windows.Forms.Button btn_TeacherSearchLastName;
        private System.Windows.Forms.Button btn_TeacheSearchName;
        private System.Windows.Forms.Button btn_TeacherSearchNationalCode;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
    }
}