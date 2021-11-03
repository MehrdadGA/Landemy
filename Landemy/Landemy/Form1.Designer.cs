namespace Landemy
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
            this.btn_masterShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_masterShow
            // 
            this.btn_masterShow.Location = new System.Drawing.Point(12, 189);
            this.btn_masterShow.Name = "btn_masterShow";
            this.btn_masterShow.Size = new System.Drawing.Size(75, 23);
            this.btn_masterShow.TabIndex = 1;
            this.btn_masterShow.Text = "button1";
            this.btn_masterShow.UseVisualStyleBackColor = true;
            this.btn_masterShow.Click += new System.EventHandler(this.btn_masterShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.btn_masterShow);
            this.Name = "Form1";
            this.Text = "";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btn_masterShow, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_masterShow;
    }
}

