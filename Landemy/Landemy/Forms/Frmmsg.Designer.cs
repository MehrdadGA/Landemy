namespace Landemy.Forms
{
    partial class Frmmsg
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
            this.lbl_Msgbox = new System.Windows.Forms.Label();
            this.btn_Msgbox = new System.Windows.Forms.Button();
            this.btn_msgCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Msgbox
            // 
            this.lbl_Msgbox.AutoSize = true;
            this.lbl_Msgbox.Location = new System.Drawing.Point(381, 70);
            this.lbl_Msgbox.Name = "lbl_Msgbox";
            this.lbl_Msgbox.Size = new System.Drawing.Size(38, 14);
            this.lbl_Msgbox.TabIndex = 2;
            this.lbl_Msgbox.Text = "label1";
            // 
            // btn_Msgbox
            // 
            this.btn_Msgbox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Msgbox.Location = new System.Drawing.Point(12, 138);
            this.btn_Msgbox.Name = "btn_Msgbox";
            this.btn_Msgbox.Size = new System.Drawing.Size(75, 36);
            this.btn_Msgbox.TabIndex = 3;
            this.btn_Msgbox.Text = "تایید";
            this.btn_Msgbox.UseVisualStyleBackColor = true;
            this.btn_Msgbox.Click += new System.EventHandler(this.btn_Msgbox_Click);
            // 
            // btn_msgCancle
            // 
            this.btn_msgCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_msgCancle.Location = new System.Drawing.Point(93, 138);
            this.btn_msgCancle.Name = "btn_msgCancle";
            this.btn_msgCancle.Size = new System.Drawing.Size(75, 36);
            this.btn_msgCancle.TabIndex = 4;
            this.btn_msgCancle.Text = "لغو";
            this.btn_msgCancle.UseVisualStyleBackColor = true;
            // 
            // Frmmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 186);
            this.Controls.Add(this.btn_msgCancle);
            this.Controls.Add(this.btn_Msgbox);
            this.Controls.Add(this.lbl_Msgbox);
            this.Name = "Frmmsg";
            this.Text = "Frmmsg";
            this.Load += new System.EventHandler(this.Frmmsg_Load);
            this.Controls.SetChildIndex(this.lbl_Msgbox, 0);
            this.Controls.SetChildIndex(this.btn_Msgbox, 0);
            this.Controls.SetChildIndex(this.btn_msgCancle, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Msgbox;
        public System.Windows.Forms.Label lbl_Msgbox;
        private System.Windows.Forms.Button btn_msgCancle;
    }
}