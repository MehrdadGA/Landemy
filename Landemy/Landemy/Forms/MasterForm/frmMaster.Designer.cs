namespace Landemy.Forms.MasterForm
{
    partial class frmMaster
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
            this.pnl_MasterForm = new System.Windows.Forms.Panel();
            this.lbl_FormName = new System.Windows.Forms.Label();
            this.ptb_Background = new System.Windows.Forms.PictureBox();
            this.ptb_CloseIcon = new System.Windows.Forms.PictureBox();
            this.pnl_MasterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_CloseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_MasterForm
            // 
            this.pnl_MasterForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_MasterForm.Controls.Add(this.lbl_FormName);
            this.pnl_MasterForm.Controls.Add(this.ptb_CloseIcon);
            this.pnl_MasterForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MasterForm.Location = new System.Drawing.Point(0, 0);
            this.pnl_MasterForm.Name = "pnl_MasterForm";
            this.pnl_MasterForm.Size = new System.Drawing.Size(929, 54);
            this.pnl_MasterForm.TabIndex = 0;
            // 
            // lbl_FormName
            // 
            this.lbl_FormName.AutoSize = true;
            this.lbl_FormName.Location = new System.Drawing.Point(463, 19);
            this.lbl_FormName.Name = "lbl_FormName";
            this.lbl_FormName.Size = new System.Drawing.Size(38, 14);
            this.lbl_FormName.TabIndex = 2;
            this.lbl_FormName.Text = "label1";
            // 
            // ptb_Background
            // 
            this.ptb_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Background.Image = global::Landemy.Properties.Resources.Main2;
            this.ptb_Background.Location = new System.Drawing.Point(0, 54);
            this.ptb_Background.Name = "ptb_Background";
            this.ptb_Background.Size = new System.Drawing.Size(929, 427);
            this.ptb_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Background.TabIndex = 1;
            this.ptb_Background.TabStop = false;
            // 
            // ptb_CloseIcon
            // 
            this.ptb_CloseIcon.Image = global::Landemy.Properties.Resources.CloseForm;
            this.ptb_CloseIcon.Location = new System.Drawing.Point(884, 5);
            this.ptb_CloseIcon.Name = "ptb_CloseIcon";
            this.ptb_CloseIcon.Size = new System.Drawing.Size(46, 49);
            this.ptb_CloseIcon.TabIndex = 1;
            this.ptb_CloseIcon.TabStop = false;
            this.ptb_CloseIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 481);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_Background);
            this.Controls.Add(this.pnl_MasterForm);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMaster";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.pnl_MasterForm.ResumeLayout(false);
            this.pnl_MasterForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_CloseIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MasterForm;
        private System.Windows.Forms.PictureBox ptb_CloseIcon;
        private System.Windows.Forms.Label lbl_FormName;
        private System.Windows.Forms.PictureBox ptb_Background;
    }
}