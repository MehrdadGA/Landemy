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
            this.btn_DegreeDelete = new System.Windows.Forms.Button();
            this.btn_DegreePrint = new System.Windows.Forms.Button();
            this.btn_DegreeInsert = new System.Windows.Forms.Button();
            this.btn_DegreeEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DegreeTitle = new System.Windows.Forms.TextBox();
            this.txt_DegreeId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DegreeForm = new System.Windows.Forms.DataGridView();
            this.ColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_DegreeForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DegreeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_DegreeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DegreeDelete);
            this.panel1.Controls.Add(this.btn_DegreePrint);
            this.panel1.Controls.Add(this.btn_DegreeInsert);
            this.panel1.Controls.Add(this.btn_DegreeEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DegreeTitle);
            this.panel1.Controls.Add(this.txt_DegreeId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(741, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 479);
            this.panel1.TabIndex = 2;
            // 
            // btn_DegreeDelete
            // 
            this.btn_DegreeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DegreeDelete.Image = global::Landemy.Properties.Resources.Delete2Icon;
            this.btn_DegreeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeDelete.Location = new System.Drawing.Point(97, 315);
            this.btn_DegreeDelete.Name = "btn_DegreeDelete";
            this.btn_DegreeDelete.Size = new System.Drawing.Size(87, 40);
            this.btn_DegreeDelete.TabIndex = 5;
            this.btn_DegreeDelete.Text = "حذف";
            this.btn_DegreeDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeDelete.UseVisualStyleBackColor = true;
            // 
            // btn_DegreePrint
            // 
            this.btn_DegreePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DegreePrint.Image = global::Landemy.Properties.Resources.PrintIcon;
            this.btn_DegreePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreePrint.Location = new System.Drawing.Point(6, 315);
            this.btn_DegreePrint.Name = "btn_DegreePrint";
            this.btn_DegreePrint.Size = new System.Drawing.Size(87, 40);
            this.btn_DegreePrint.TabIndex = 4;
            this.btn_DegreePrint.Text = "پرینت";
            this.btn_DegreePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreePrint.UseVisualStyleBackColor = true;
            // 
            // btn_DegreeInsert
            // 
            this.btn_DegreeInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DegreeInsert.Image = global::Landemy.Properties.Resources.InsertIcon;
            this.btn_DegreeInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeInsert.Location = new System.Drawing.Point(97, 269);
            this.btn_DegreeInsert.Name = "btn_DegreeInsert";
            this.btn_DegreeInsert.Size = new System.Drawing.Size(87, 40);
            this.btn_DegreeInsert.TabIndex = 3;
            this.btn_DegreeInsert.Text = "جدید";
            this.btn_DegreeInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeInsert.UseVisualStyleBackColor = true;
            this.btn_DegreeInsert.Click += new System.EventHandler(this.btn_DegreeInsert_Click);
            // 
            // btn_DegreeEdit
            // 
            this.btn_DegreeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DegreeEdit.Image = global::Landemy.Properties.Resources.Update2Icon;
            this.btn_DegreeEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DegreeEdit.Location = new System.Drawing.Point(6, 269);
            this.btn_DegreeEdit.Name = "btn_DegreeEdit";
            this.btn_DegreeEdit.Size = new System.Drawing.Size(87, 40);
            this.btn_DegreeEdit.TabIndex = 2;
            this.btn_DegreeEdit.Text = "ویرایش";
            this.btn_DegreeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DegreeEdit.UseVisualStyleBackColor = true;
            this.btn_DegreeEdit.Click += new System.EventHandler(this.btn_DegreeEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان :";
            // 
            // txt_DegreeTitle
            // 
            this.txt_DegreeTitle.Location = new System.Drawing.Point(6, 56);
            this.txt_DegreeTitle.Name = "txt_DegreeTitle";
            this.txt_DegreeTitle.Size = new System.Drawing.Size(134, 22);
            this.txt_DegreeTitle.TabIndex = 0;
            // 
            // txt_DegreeId
            // 
            this.txt_DegreeId.Location = new System.Drawing.Point(6, 28);
            this.txt_DegreeId.Name = "txt_DegreeId";
            this.txt_DegreeId.Size = new System.Drawing.Size(134, 22);
            this.txt_DegreeId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_DegreeForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 479);
            this.panel2.TabIndex = 3;
            // 
            // dgv_DegreeForm
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dgv_DegreeForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DegreeForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DegreeForm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DegreeForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DegreeForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRowNumber});
            this.dgv_DegreeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DegreeForm.Location = new System.Drawing.Point(0, 0);
            this.dgv_DegreeForm.Name = "dgv_DegreeForm";
            this.dgv_DegreeForm.Size = new System.Drawing.Size(741, 479);
            this.dgv_DegreeForm.TabIndex = 0;
            this.dgv_DegreeForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DegreeForm_CellClick);
            this.dgv_DegreeForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_DegreeForm.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DegreeForm_CellFormatting);
            // 
            // ColumnRowNumber
            // 
            this.ColumnRowNumber.HeaderText = "ردیف";
            this.ColumnRowNumber.Name = "ColumnRowNumber";
            // 
            // erp_DegreeForm
            // 
            this.erp_DegreeForm.ContainerControl = this;
            // 
            // DegreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 533);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DegreeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_DegreeForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DegreeTitle;
        private System.Windows.Forms.TextBox txt_DegreeId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_DegreeForm;
        private System.Windows.Forms.Button btn_DegreeDelete;
        private System.Windows.Forms.Button btn_DegreePrint;
        private System.Windows.Forms.Button btn_DegreeInsert;
        private System.Windows.Forms.Button btn_DegreeEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRowNumber;
        private System.Windows.Forms.ErrorProvider erp_DegreeForm;
    }
}