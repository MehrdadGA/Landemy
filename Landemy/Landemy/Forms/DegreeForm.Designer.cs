namespace Landemy.Forms
{
    partial class DegreeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_DegreeInsert = new System.Windows.Forms.Button();
            this.btn_DegreeEdit = new System.Windows.Forms.Button();
            this.btn_DegreeDelete = new System.Windows.Forms.Button();
            this.btn_DegreePrint = new System.Windows.Forms.Button();
            this.txt_Degreetitle = new System.Windows.Forms.TextBox();
            this.lbl_DegreeTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Degree = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_Degree = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Degree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_DegreeInsert);
            this.panel1.Controls.Add(this.btn_DegreeEdit);
            this.panel1.Controls.Add(this.btn_DegreeDelete);
            this.panel1.Controls.Add(this.btn_DegreePrint);
            this.panel1.Controls.Add(this.txt_Degreetitle);
            this.panel1.Controls.Add(this.lbl_DegreeTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(702, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 442);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // btn_DegreeInsert
            // 
            this.btn_DegreeInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_DegreeInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeInsert.Location = new System.Drawing.Point(132, 315);
            this.btn_DegreeInsert.Name = "btn_DegreeInsert";
            this.btn_DegreeInsert.Size = new System.Drawing.Size(87, 41);
            this.btn_DegreeInsert.TabIndex = 3;
            this.btn_DegreeInsert.Text = "افزودن";
            this.btn_DegreeInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeInsert.UseVisualStyleBackColor = true;
            this.btn_DegreeInsert.Click += new System.EventHandler(this.btn_DegreeInsert_Click);
            // 
            // btn_DegreeEdit
            // 
            this.btn_DegreeEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_DegreeEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeEdit.Location = new System.Drawing.Point(35, 315);
            this.btn_DegreeEdit.Name = "btn_DegreeEdit";
            this.btn_DegreeEdit.Size = new System.Drawing.Size(87, 41);
            this.btn_DegreeEdit.TabIndex = 4;
            this.btn_DegreeEdit.Text = "ویرایش";
            this.btn_DegreeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeEdit.UseVisualStyleBackColor = true;
            this.btn_DegreeEdit.Click += new System.EventHandler(this.btn_DegreeEdit_Click);
            // 
            // btn_DegreeDelete
            // 
            this.btn_DegreeDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_DegreeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeDelete.Location = new System.Drawing.Point(132, 362);
            this.btn_DegreeDelete.Name = "btn_DegreeDelete";
            this.btn_DegreeDelete.Size = new System.Drawing.Size(87, 41);
            this.btn_DegreeDelete.TabIndex = 2;
            this.btn_DegreeDelete.Text = "حذف";
            this.btn_DegreeDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeDelete.UseVisualStyleBackColor = true;
            this.btn_DegreeDelete.Click += new System.EventHandler(this.btn_DegreeDelete_Click);
            // 
            // btn_DegreePrint
            // 
            this.btn_DegreePrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_DegreePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreePrint.Location = new System.Drawing.Point(35, 362);
            this.btn_DegreePrint.Name = "btn_DegreePrint";
            this.btn_DegreePrint.Size = new System.Drawing.Size(87, 41);
            this.btn_DegreePrint.TabIndex = 0;
            this.btn_DegreePrint.Text = "چاپ";
            this.btn_DegreePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreePrint.UseVisualStyleBackColor = true;
            // 
            // txt_Degreetitle
            // 
            this.txt_Degreetitle.Location = new System.Drawing.Point(10, 41);
            this.txt_Degreetitle.Name = "txt_Degreetitle";
            this.txt_Degreetitle.Size = new System.Drawing.Size(161, 22);
            this.txt_Degreetitle.TabIndex = 1;
            // 
            // lbl_DegreeTitle
            // 
            this.lbl_DegreeTitle.AutoSize = true;
            this.lbl_DegreeTitle.Location = new System.Drawing.Point(177, 44);
            this.lbl_DegreeTitle.Name = "lbl_DegreeTitle";
            this.lbl_DegreeTitle.Size = new System.Drawing.Size(42, 14);
            this.lbl_DegreeTitle.TabIndex = 0;
            this.lbl_DegreeTitle.Text = "عنوان :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Degree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 442);
            this.panel2.TabIndex = 0;
            // 
            // dgv_Degree
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Degree.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Degree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Degree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_Degree.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Degree.Location = new System.Drawing.Point(0, 0);
            this.dgv_Degree.Name = "dgv_Degree";
            this.dgv_Degree.Size = new System.Drawing.Size(703, 442);
            this.dgv_Degree.TabIndex = 5;
            this.dgv_Degree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Degree_CellClick);
            this.dgv_Degree.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Degree_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // erp_Degree
            // 
            this.erp_Degree.ContainerControl = this;
            // 
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DegreeForm";
            this.Text = "DegreeForm";
            this.Load += new System.EventHandler(this.DegreeForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Degree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Degreetitle;
        private System.Windows.Forms.Label lbl_DegreeTitle;
        private System.Windows.Forms.Button btn_DegreeInsert;
        private System.Windows.Forms.Button btn_DegreeEdit;
        private System.Windows.Forms.Button btn_DegreeDelete;
        private System.Windows.Forms.Button btn_DegreePrint;
        private System.Windows.Forms.DataGridView dgv_Degree;
        private System.Windows.Forms.ErrorProvider erp_Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.TextBox textBox1;
    }
}