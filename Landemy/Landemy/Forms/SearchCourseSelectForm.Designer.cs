namespace Landemy.Forms
{
    partial class SearchCourseSelectForm
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
            this.btn_CourseSelectPrint = new System.Windows.Forms.Button();
            this.btn_CourseSelectCourseGroup = new System.Windows.Forms.Button();
            this.btn_CourseSelectYear = new System.Windows.Forms.Button();
            this.btn_CourseSelectCourseName = new System.Windows.Forms.Button();
            this.btn_CourseSelectTeacher = new System.Windows.Forms.Button();
            this.txt_CourseSelectTeacher = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectYear = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectCourseGroup = new System.Windows.Forms.TextBox();
            this.txt_CourseSelectCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_SearchCourseSelect = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCourseSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CourseSelectPrint);
            this.panel1.Controls.Add(this.btn_CourseSelectCourseGroup);
            this.panel1.Controls.Add(this.btn_CourseSelectYear);
            this.panel1.Controls.Add(this.btn_CourseSelectCourseName);
            this.panel1.Controls.Add(this.btn_CourseSelectTeacher);
            this.panel1.Controls.Add(this.txt_CourseSelectTeacher);
            this.panel1.Controls.Add(this.txt_CourseSelectYear);
            this.panel1.Controls.Add(this.txt_CourseSelectCourseGroup);
            this.panel1.Controls.Add(this.txt_CourseSelectCourseName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 139);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_CourseSelectPrint
            // 
            this.btn_CourseSelectPrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_CourseSelectPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CourseSelectPrint.Location = new System.Drawing.Point(12, 95);
            this.btn_CourseSelectPrint.Name = "btn_CourseSelectPrint";
            this.btn_CourseSelectPrint.Size = new System.Drawing.Size(80, 37);
            this.btn_CourseSelectPrint.TabIndex = 51;
            this.btn_CourseSelectPrint.Text = "چاپ";
            this.btn_CourseSelectPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CourseSelectPrint.UseVisualStyleBackColor = true;
            // 
            // btn_CourseSelectCourseGroup
            // 
            this.btn_CourseSelectCourseGroup.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectCourseGroup.Location = new System.Drawing.Point(78, 29);
            this.btn_CourseSelectCourseGroup.Name = "btn_CourseSelectCourseGroup";
            this.btn_CourseSelectCourseGroup.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectCourseGroup.TabIndex = 50;
            this.btn_CourseSelectCourseGroup.UseVisualStyleBackColor = true;
            this.btn_CourseSelectCourseGroup.Click += new System.EventHandler(this.btn_CourseSelectCourseGroup_Click);
            // 
            // btn_CourseSelectYear
            // 
            this.btn_CourseSelectYear.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectYear.Location = new System.Drawing.Point(376, 29);
            this.btn_CourseSelectYear.Name = "btn_CourseSelectYear";
            this.btn_CourseSelectYear.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectYear.TabIndex = 49;
            this.btn_CourseSelectYear.UseVisualStyleBackColor = true;
            this.btn_CourseSelectYear.Click += new System.EventHandler(this.btn_CourseSelectYear_Click);
            // 
            // btn_CourseSelectCourseName
            // 
            this.btn_CourseSelectCourseName.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectCourseName.Location = new System.Drawing.Point(645, 29);
            this.btn_CourseSelectCourseName.Name = "btn_CourseSelectCourseName";
            this.btn_CourseSelectCourseName.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectCourseName.TabIndex = 48;
            this.btn_CourseSelectCourseName.UseVisualStyleBackColor = true;
            this.btn_CourseSelectCourseName.Click += new System.EventHandler(this.btn_CourseSelectCourseName_Click);
            // 
            // btn_CourseSelectTeacher
            // 
            this.btn_CourseSelectTeacher.Image = global::Landemy.Properties.Resources.SearchIcon;
            this.btn_CourseSelectTeacher.Location = new System.Drawing.Point(932, 29);
            this.btn_CourseSelectTeacher.Name = "btn_CourseSelectTeacher";
            this.btn_CourseSelectTeacher.Size = new System.Drawing.Size(43, 42);
            this.btn_CourseSelectTeacher.TabIndex = 47;
            this.btn_CourseSelectTeacher.UseVisualStyleBackColor = true;
            this.btn_CourseSelectTeacher.Click += new System.EventHandler(this.btn_CourseSelectTeacher_Click);
            // 
            // txt_CourseSelectTeacher
            // 
            this.txt_CourseSelectTeacher.Location = new System.Drawing.Point(981, 38);
            this.txt_CourseSelectTeacher.Name = "txt_CourseSelectTeacher";
            this.txt_CourseSelectTeacher.Size = new System.Drawing.Size(129, 26);
            this.txt_CourseSelectTeacher.TabIndex = 7;
            // 
            // txt_CourseSelectYear
            // 
            this.txt_CourseSelectYear.Location = new System.Drawing.Point(425, 38);
            this.txt_CourseSelectYear.Name = "txt_CourseSelectYear";
            this.txt_CourseSelectYear.Size = new System.Drawing.Size(129, 26);
            this.txt_CourseSelectYear.TabIndex = 6;
            // 
            // txt_CourseSelectCourseGroup
            // 
            this.txt_CourseSelectCourseGroup.Location = new System.Drawing.Point(127, 38);
            this.txt_CourseSelectCourseGroup.Name = "txt_CourseSelectCourseGroup";
            this.txt_CourseSelectCourseGroup.Size = new System.Drawing.Size(129, 26);
            this.txt_CourseSelectCourseGroup.TabIndex = 5;
            // 
            // txt_CourseSelectCourseName
            // 
            this.txt_CourseSelectCourseName.Location = new System.Drawing.Point(694, 38);
            this.txt_CourseSelectCourseName.Name = "txt_CourseSelectCourseName";
            this.txt_CourseSelectCourseName.Size = new System.Drawing.Size(129, 26);
            this.txt_CourseSelectCourseName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "سال :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام درس :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "استاد :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "گروه درسی :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgv_SearchCourseSelect);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 167);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1172, 489);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dgv_SearchCourseSelect
            // 
            this.dgv_SearchCourseSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchCourseSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_SearchCourseSelect.Location = new System.Drawing.Point(0, 3);
            this.dgv_SearchCourseSelect.Name = "dgv_SearchCourseSelect";
            this.dgv_SearchCourseSelect.RowHeadersWidth = 51;
            this.dgv_SearchCourseSelect.Size = new System.Drawing.Size(1169, 486);
            this.dgv_SearchCourseSelect.TabIndex = 52;
            this.dgv_SearchCourseSelect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchCourseSelect_CellDoubleClick);
            this.dgv_SearchCourseSelect.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SearchCourseSelect_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.MinimumWidth = 6;
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            this.ColumnRowNumber.Width = 125;
            // 
            // SearchCourseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 656);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "SearchCourseSelectForm";
            this.Load += new System.EventHandler(this.SearchCourseSelectForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCourseSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CourseSelectTeacher;
        private System.Windows.Forms.TextBox txt_CourseSelectYear;
        private System.Windows.Forms.TextBox txt_CourseSelectCourseGroup;
        private System.Windows.Forms.TextBox txt_CourseSelectCourseName;
        private System.Windows.Forms.Button btn_CourseSelectPrint;
        private System.Windows.Forms.Button btn_CourseSelectCourseGroup;
        private System.Windows.Forms.Button btn_CourseSelectYear;
        private System.Windows.Forms.Button btn_CourseSelectCourseName;
        private System.Windows.Forms.Button btn_CourseSelectTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        public System.Windows.Forms.DataGridView dgv_SearchCourseSelect;
    }
}