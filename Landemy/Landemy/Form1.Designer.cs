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
            this.btn_DegreeShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DegreeShow
            // 
            this.btn_DegreeShow.Location = new System.Drawing.Point(21, 60);
            this.btn_DegreeShow.Name = "btn_DegreeShow";
            this.btn_DegreeShow.Size = new System.Drawing.Size(75, 23);
            this.btn_DegreeShow.TabIndex = 1;
            this.btn_DegreeShow.Text = "مدارک";
            this.btn_DegreeShow.UseVisualStyleBackColor = true;
            this.btn_DegreeShow.Click += new System.EventHandler(this.btn_masterShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btn_DegreeShow);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btn_DegreeShow, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DegreeShow;
    }
}

