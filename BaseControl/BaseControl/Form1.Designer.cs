namespace BaseControl
{
    partial class Form1
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
            this.myToolbar1 = new BaseControl.MyToolbar();
            this.SuspendLayout();
            // 
            // myToolbar1
            // 
            this.myToolbar1.Location = new System.Drawing.Point(180, 81);
            this.myToolbar1.Name = "myToolbar1";
            this.myToolbar1.Size = new System.Drawing.Size(723, 349);
            this.myToolbar1.TabIndex = 0;
            this.myToolbar1.Btn_OK += new BaseControl.MyToolbar.Btn_Click(this.myToolbar1_Btn_OK);
            this.myToolbar1.Btn_Cancel += new BaseControl.MyToolbar.Btn_Click(this.myToolbar1_Btn_Cancel);
            this.myToolbar1.Btn_New += new BaseControl.MyToolbar.Btn_Click(this.myToolbar1_Btn_New);
            this.myToolbar1.Btn_Edit += new BaseControl.MyToolbar.Btn_Click(this.myToolbar1_Btn_Edit);
            this.myToolbar1.Btn_Delete += new BaseControl.MyToolbar.Btn_Click(this.myToolbar1_Btn_Delete);
            this.myToolbar1.Load += new System.EventHandler(this.myToolbar1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.myToolbar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyToolbar myToolbar1;
    }
}

