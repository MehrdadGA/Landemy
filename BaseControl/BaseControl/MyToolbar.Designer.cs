namespace BaseControl
{
    partial class MyToolbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.pnl_Button.SuspendLayout();
            this.pnl_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Button.Controls.Add(this.btn_Insert);
            this.pnl_Button.Controls.Add(this.btn_Edit);
            this.pnl_Button.Controls.Add(this.btn_Delete);
            this.pnl_Button.Location = new System.Drawing.Point(389, 89);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnl_Button.Size = new System.Drawing.Size(223, 133);
            this.pnl_Button.TabIndex = 0;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Image = global::BaseControl.Properties.Resources.InsertIcon;
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.Location = new System.Drawing.Point(114, 4);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(99, 53);
            this.btn_Insert.TabIndex = 30;
            this.btn_Insert.Text = "افزودن";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = global::BaseControl.Properties.Resources.Update2Icon;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.Location = new System.Drawing.Point(3, 4);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 53);
            this.btn_Edit.TabIndex = 31;
            this.btn_Edit.Text = "ویرایش";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::BaseControl.Properties.Resources.Delete2Icon;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(114, 65);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 53);
            this.btn_Delete.TabIndex = 29;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pnl_Action
            // 
            this.pnl_Action.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Action.Controls.Add(this.btn_OK);
            this.pnl_Action.Controls.Add(this.btn_Cancel);
            this.pnl_Action.Location = new System.Drawing.Point(202, 129);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(181, 53);
            this.pnl_Action.TabIndex = 32;
            this.pnl_Action.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(15, 7);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(96, 7);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "تایید";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // MyToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_Button);
            this.Name = "MyToolbar";
            this.Size = new System.Drawing.Size(723, 349);
            this.Load += new System.EventHandler(this.MyToolbar_Load);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Action.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
