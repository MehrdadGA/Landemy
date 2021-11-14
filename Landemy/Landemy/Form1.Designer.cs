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
            this.btn_StudentForm = new System.Windows.Forms.Button();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.btn_Course = new System.Windows.Forms.Button();
            this.btn_CourseGroup = new System.Windows.Forms.Button();
            this.btn_CourseSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DegreeShow
            // 
            this.btn_DegreeShow.Location = new System.Drawing.Point(14, 45);
            this.btn_DegreeShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DegreeShow.Name = "btn_DegreeShow";
            this.btn_DegreeShow.Size = new System.Drawing.Size(86, 73);
            this.btn_DegreeShow.TabIndex = 1;
            this.btn_DegreeShow.Text = "مدارک";
            this.btn_DegreeShow.UseVisualStyleBackColor = true;
            this.btn_DegreeShow.Click += new System.EventHandler(this.btn_masterShow_Click);
            // 
            // btn_StudentForm
            // 
            this.btn_StudentForm.Location = new System.Drawing.Point(106, 45);
            this.btn_StudentForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StudentForm.Name = "btn_StudentForm";
            this.btn_StudentForm.Size = new System.Drawing.Size(86, 73);
            this.btn_StudentForm.TabIndex = 2;
            this.btn_StudentForm.Text = "دانش آموز";
            this.btn_StudentForm.UseVisualStyleBackColor = true;
            this.btn_StudentForm.Click += new System.EventHandler(this.btn_StudentForm_Click);
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.Location = new System.Drawing.Point(199, 45);
            this.btn_Teacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(86, 73);
            this.btn_Teacher.TabIndex = 3;
            this.btn_Teacher.Text = "استاد";
            this.btn_Teacher.UseVisualStyleBackColor = true;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // btn_Course
            // 
            this.btn_Course.Location = new System.Drawing.Point(291, 45);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(86, 73);
            this.btn_Course.TabIndex = 4;
            this.btn_Course.Text = "درس";
            this.btn_Course.UseVisualStyleBackColor = true;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // btn_CourseGroup
            // 
            this.btn_CourseGroup.Location = new System.Drawing.Point(383, 45);
            this.btn_CourseGroup.Name = "btn_CourseGroup";
            this.btn_CourseGroup.Size = new System.Drawing.Size(86, 73);
            this.btn_CourseGroup.TabIndex = 5;
            this.btn_CourseGroup.Text = "گروه درسی";
            this.btn_CourseGroup.UseVisualStyleBackColor = true;
            this.btn_CourseGroup.Click += new System.EventHandler(this.btn_CourseGroup_Click);
            // 
            // btn_CourseSelect
            // 
            this.btn_CourseSelect.Location = new System.Drawing.Point(485, 45);
            this.btn_CourseSelect.Name = "btn_CourseSelect";
            this.btn_CourseSelect.Size = new System.Drawing.Size(75, 73);
            this.btn_CourseSelect.TabIndex = 6;
            this.btn_CourseSelect.Text = "انتخاب واحد";
            this.btn_CourseSelect.UseVisualStyleBackColor = true;
            this.btn_CourseSelect.Click += new System.EventHandler(this.btn_CourseSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 624);
            this.Controls.Add(this.btn_CourseSelect);
            this.Controls.Add(this.btn_CourseGroup);
            this.Controls.Add(this.btn_Course);
            this.Controls.Add(this.btn_Teacher);
            this.Controls.Add(this.btn_StudentForm);
            this.Controls.Add(this.btn_DegreeShow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btn_DegreeShow, 0);
            this.Controls.SetChildIndex(this.btn_StudentForm, 0);
            this.Controls.SetChildIndex(this.btn_Teacher, 0);
            this.Controls.SetChildIndex(this.btn_Course, 0);
            this.Controls.SetChildIndex(this.btn_CourseGroup, 0);
            this.Controls.SetChildIndex(this.btn_CourseSelect, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DegreeShow;
        private System.Windows.Forms.Button btn_StudentForm;
        private System.Windows.Forms.Button btn_Teacher;
        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Button btn_CourseGroup;
        private System.Windows.Forms.Button btn_CourseSelect;
    }
}

