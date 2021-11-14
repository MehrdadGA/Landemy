namespace Landemy.Forms
{
    partial class SearchTeacherForm
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
            this.pnl_SearchTeacherComponent = new System.Windows.Forms.Panel();
            this.btn_TeacherSearchPrint = new System.Windows.Forms.Button();
            this.btn_TeacherSearchDegree = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_degreeOfStudent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TeacherSearchSex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SexOfStudent = new System.Windows.Forms.Label();
            this.btn_TeacherNationalcodeSearch = new System.Windows.Forms.Button();
            this.btn_TeahcerSearchTransfer = new System.Windows.Forms.Button();
            this.btn_TaecherSearchName = new System.Windows.Forms.Button();
            this.btn_TeacherFamilySearch = new System.Windows.Forms.Button();
            this.pnl_SearchTeacherGrid = new System.Windows.Forms.Panel();
            this.dgv_SearchTeacherMore = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_SearchTeacherSex = new System.Windows.Forms.ComboBox();
            this.com_SearchTeacherDegree = new System.Windows.Forms.ComboBox();
            this.txt_SearchTeacherName = new System.Windows.Forms.TextBox();
            this.txt_SearchTeacherNationalCode = new System.Windows.Forms.TextBox();
            this.txt_SearchTeacherLastName = new System.Windows.Forms.TextBox();
            this.pnl_SearchTeacherComponent.SuspendLayout();
            this.pnl_SearchTeacherGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchTeacherMore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SearchTeacherComponent
            // 
            this.pnl_SearchTeacherComponent.Controls.Add(this.txt_SearchTeacherLastName);
            this.pnl_SearchTeacherComponent.Controls.Add(this.txt_SearchTeacherNationalCode);
            this.pnl_SearchTeacherComponent.Controls.Add(this.txt_SearchTeacherName);
            this.pnl_SearchTeacherComponent.Controls.Add(this.com_SearchTeacherDegree);
            this.pnl_SearchTeacherComponent.Controls.Add(this.com_SearchTeacherSex);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeacherSearchPrint);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeacherSearchDegree);
            this.pnl_SearchTeacherComponent.Controls.Add(this.label3);
            this.pnl_SearchTeacherComponent.Controls.Add(this.lbl_degreeOfStudent);
            this.pnl_SearchTeacherComponent.Controls.Add(this.label2);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeacherSearchSex);
            this.pnl_SearchTeacherComponent.Controls.Add(this.label1);
            this.pnl_SearchTeacherComponent.Controls.Add(this.lbl_SexOfStudent);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeacherNationalcodeSearch);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeahcerSearchTransfer);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TaecherSearchName);
            this.pnl_SearchTeacherComponent.Controls.Add(this.btn_TeacherFamilySearch);
            this.pnl_SearchTeacherComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SearchTeacherComponent.Location = new System.Drawing.Point(0, 29);
            this.pnl_SearchTeacherComponent.Name = "pnl_SearchTeacherComponent";
            this.pnl_SearchTeacherComponent.Size = new System.Drawing.Size(959, 180);
            this.pnl_SearchTeacherComponent.TabIndex = 2;
            this.pnl_SearchTeacherComponent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SearchTeacherComponent_Paint);
            // 
            // btn_TeacherSearchPrint
            // 
            this.btn_TeacherSearchPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_TeacherSearchPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TeacherSearchPrint.Location = new System.Drawing.Point(9, 99);
            this.btn_TeacherSearchPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherSearchPrint.Name = "btn_TeacherSearchPrint";
            this.btn_TeacherSearchPrint.Size = new System.Drawing.Size(99, 53);
            this.btn_TeacherSearchPrint.TabIndex = 60;
            this.btn_TeacherSearchPrint.Text = "چاپ";
            this.btn_TeacherSearchPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TeacherSearchPrint.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherSearchDegree
            // 
            this.btn_TeacherSearchDegree.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchDegree.Location = new System.Drawing.Point(656, 114);
            this.btn_TeacherSearchDegree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherSearchDegree.Name = "btn_TeacherSearchDegree";
            this.btn_TeacherSearchDegree.Size = new System.Drawing.Size(43, 42);
            this.btn_TeacherSearchDegree.TabIndex = 59;
            this.btn_TeacherSearchDegree.UseVisualStyleBackColor = true;
            this.btn_TeacherSearchDegree.Click += new System.EventHandler(this.btn_TeacherSearchDegree_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "نام خانوادگی :";
            // 
            // lbl_degreeOfStudent
            // 
            this.lbl_degreeOfStudent.AutoSize = true;
            this.lbl_degreeOfStudent.Location = new System.Drawing.Point(885, 126);
            this.lbl_degreeOfStudent.Name = "lbl_degreeOfStudent";
            this.lbl_degreeOfStudent.Size = new System.Drawing.Size(53, 18);
            this.lbl_degreeOfStudent.TabIndex = 57;
            this.lbl_degreeOfStudent.Text = "مدرک :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "نام :";
            // 
            // btn_TeacherSearchSex
            // 
            this.btn_TeacherSearchSex.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherSearchSex.Location = new System.Drawing.Point(307, 73);
            this.btn_TeacherSearchSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherSearchSex.Name = "btn_TeacherSearchSex";
            this.btn_TeacherSearchSex.Size = new System.Drawing.Size(43, 42);
            this.btn_TeacherSearchSex.TabIndex = 56;
            this.btn_TeacherSearchSex.UseVisualStyleBackColor = true;
            this.btn_TeacherSearchSex.Click += new System.EventHandler(this.btn_TeacherSearchSex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "کد ملی :";
            // 
            // lbl_SexOfStudent
            // 
            this.lbl_SexOfStudent.AutoSize = true;
            this.lbl_SexOfStudent.Location = new System.Drawing.Point(525, 85);
            this.lbl_SexOfStudent.Name = "lbl_SexOfStudent";
            this.lbl_SexOfStudent.Size = new System.Drawing.Size(68, 18);
            this.lbl_SexOfStudent.TabIndex = 54;
            this.lbl_SexOfStudent.Text = "جنسیت :";
            // 
            // btn_TeacherNationalcodeSearch
            // 
            this.btn_TeacherNationalcodeSearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherNationalcodeSearch.Location = new System.Drawing.Point(656, 10);
            this.btn_TeacherNationalcodeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherNationalcodeSearch.Name = "btn_TeacherNationalcodeSearch";
            this.btn_TeacherNationalcodeSearch.Size = new System.Drawing.Size(43, 42);
            this.btn_TeacherNationalcodeSearch.TabIndex = 50;
            this.btn_TeacherNationalcodeSearch.UseVisualStyleBackColor = true;
            this.btn_TeacherNationalcodeSearch.Click += new System.EventHandler(this.btn_StdNationalcodeSearch_Click);
            // 
            // btn_TeahcerSearchTransfer
            // 
            this.btn_TeahcerSearchTransfer.Location = new System.Drawing.Point(9, 39);
            this.btn_TeahcerSearchTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeahcerSearchTransfer.Name = "btn_TeahcerSearchTransfer";
            this.btn_TeahcerSearchTransfer.Size = new System.Drawing.Size(99, 53);
            this.btn_TeahcerSearchTransfer.TabIndex = 53;
            this.btn_TeahcerSearchTransfer.Text = "انتقال";
            this.btn_TeahcerSearchTransfer.UseVisualStyleBackColor = true;
            // 
            // btn_TaecherSearchName
            // 
            this.btn_TaecherSearchName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TaecherSearchName.Location = new System.Drawing.Point(656, 60);
            this.btn_TaecherSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TaecherSearchName.Name = "btn_TaecherSearchName";
            this.btn_TaecherSearchName.Size = new System.Drawing.Size(43, 42);
            this.btn_TaecherSearchName.TabIndex = 51;
            this.btn_TaecherSearchName.UseVisualStyleBackColor = true;
            this.btn_TaecherSearchName.Click += new System.EventHandler(this.btn_TaecherSearchName_Click);
            // 
            // btn_TeacherFamilySearch
            // 
            this.btn_TeacherFamilySearch.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_TeacherFamilySearch.Location = new System.Drawing.Point(307, 23);
            this.btn_TeacherFamilySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeacherFamilySearch.Name = "btn_TeacherFamilySearch";
            this.btn_TeacherFamilySearch.Size = new System.Drawing.Size(43, 42);
            this.btn_TeacherFamilySearch.TabIndex = 52;
            this.btn_TeacherFamilySearch.UseVisualStyleBackColor = true;
            this.btn_TeacherFamilySearch.Click += new System.EventHandler(this.btn_TeacherFamilySearch_Click);
            // 
            // pnl_SearchTeacherGrid
            // 
            this.pnl_SearchTeacherGrid.Controls.Add(this.dgv_SearchTeacherMore);
            this.pnl_SearchTeacherGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_SearchTeacherGrid.Location = new System.Drawing.Point(0, 205);
            this.pnl_SearchTeacherGrid.Name = "pnl_SearchTeacherGrid";
            this.pnl_SearchTeacherGrid.Size = new System.Drawing.Size(959, 387);
            this.pnl_SearchTeacherGrid.TabIndex = 0;
            // 
            // dgv_SearchTeacherMore
            // 
            this.dgv_SearchTeacherMore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchTeacherMore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_SearchTeacherMore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SearchTeacherMore.Location = new System.Drawing.Point(0, 0);
            this.dgv_SearchTeacherMore.Name = "dgv_SearchTeacherMore";
            this.dgv_SearchTeacherMore.RowHeadersWidth = 51;
            this.dgv_SearchTeacherMore.RowTemplate.Height = 24;
            this.dgv_SearchTeacherMore.Size = new System.Drawing.Size(959, 387);
            this.dgv_SearchTeacherMore.TabIndex = 0;
            this.dgv_SearchTeacherMore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchTeacherMore_CellContentClick);
            this.dgv_SearchTeacherMore.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchTeacherMore_CellDoubleClick);
            this.dgv_SearchTeacherMore.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SearchTeacherMore_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // com_SearchTeacherSex
            // 
            this.com_SearchTeacherSex.FormattingEnabled = true;
            this.com_SearchTeacherSex.Location = new System.Drawing.Point(369, 82);
            this.com_SearchTeacherSex.Name = "com_SearchTeacherSex";
            this.com_SearchTeacherSex.Size = new System.Drawing.Size(150, 26);
            this.com_SearchTeacherSex.TabIndex = 61;
            // 
            // com_SearchTeacherDegree
            // 
            this.com_SearchTeacherDegree.FormattingEnabled = true;
            this.com_SearchTeacherDegree.Location = new System.Drawing.Point(714, 123);
            this.com_SearchTeacherDegree.Name = "com_SearchTeacherDegree";
            this.com_SearchTeacherDegree.Size = new System.Drawing.Size(153, 26);
            this.com_SearchTeacherDegree.TabIndex = 62;
            // 
            // txt_SearchTeacherName
            // 
            this.txt_SearchTeacherName.Location = new System.Drawing.Point(714, 69);
            this.txt_SearchTeacherName.Name = "txt_SearchTeacherName";
            this.txt_SearchTeacherName.Size = new System.Drawing.Size(153, 26);
            this.txt_SearchTeacherName.TabIndex = 63;
            // 
            // txt_SearchTeacherNationalCode
            // 
            this.txt_SearchTeacherNationalCode.Location = new System.Drawing.Point(714, 32);
            this.txt_SearchTeacherNationalCode.Name = "txt_SearchTeacherNationalCode";
            this.txt_SearchTeacherNationalCode.Size = new System.Drawing.Size(153, 26);
            this.txt_SearchTeacherNationalCode.TabIndex = 64;
            // 
            // txt_SearchTeacherLastName
            // 
            this.txt_SearchTeacherLastName.Location = new System.Drawing.Point(369, 32);
            this.txt_SearchTeacherLastName.Name = "txt_SearchTeacherLastName";
            this.txt_SearchTeacherLastName.Size = new System.Drawing.Size(150, 26);
            this.txt_SearchTeacherLastName.TabIndex = 65;
            // 
            // SearchTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 592);
            this.Controls.Add(this.pnl_SearchTeacherGrid);
            this.Controls.Add(this.pnl_SearchTeacherComponent);
            this.Name = "SearchTeacherForm";
            this.Load += new System.EventHandler(this.SearchTeacherForm_Load);
            this.Controls.SetChildIndex(this.pnl_SearchTeacherComponent, 0);
            this.Controls.SetChildIndex(this.pnl_SearchTeacherGrid, 0);
            this.pnl_SearchTeacherComponent.ResumeLayout(false);
            this.pnl_SearchTeacherComponent.PerformLayout();
            this.pnl_SearchTeacherGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchTeacherMore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SearchTeacherComponent;
        private System.Windows.Forms.Panel pnl_SearchTeacherGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.Button btn_TeacherSearchPrint;
        private System.Windows.Forms.Button btn_TeacherSearchDegree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_degreeOfStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TeacherSearchSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SexOfStudent;
        private System.Windows.Forms.Button btn_TeacherNationalcodeSearch;
        private System.Windows.Forms.Button btn_TeahcerSearchTransfer;
        private System.Windows.Forms.Button btn_TaecherSearchName;
        private System.Windows.Forms.Button btn_TeacherFamilySearch;
        public System.Windows.Forms.DataGridView dgv_SearchTeacherMore;
        private System.Windows.Forms.TextBox txt_SearchTeacherLastName;
        private System.Windows.Forms.TextBox txt_SearchTeacherNationalCode;
        private System.Windows.Forms.TextBox txt_SearchTeacherName;
        private System.Windows.Forms.ComboBox com_SearchTeacherDegree;
        private System.Windows.Forms.ComboBox com_SearchTeacherSex;
    }
}