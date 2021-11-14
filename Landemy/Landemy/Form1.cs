using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy
{
    public partial class Form1 : Forms.MasterForm.frmMaster
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void btn_masterShow_Click(object sender, EventArgs e)
        {
            Forms.DegreeForm degreeForm = new Forms.DegreeForm();
            degreeForm.StrFormName = "فرم مدارک";
            degreeForm.ShowDialog();
        }

        private void btn_StudentForm_Click(object sender, EventArgs e)
        {
            Forms.StudentForm studentForm = new Forms.StudentForm();
            studentForm.StrFormName = "فرم دانش آموز";
            studentForm.ShowDialog();
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            Forms.TeacherForm teacherForm = new Forms.TeacherForm();
            teacherForm.StrFormName = "فرم اساتید";
            teacherForm.ShowDialog();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            Forms.CourseForm courseForm = new Forms.CourseForm();
            courseForm.StrFormName = "فرم درس";
            courseForm.ShowDialog();
        }

        private void btn_CourseGroup_Click(object sender, EventArgs e)
        {
            Forms.CourseGroupForm courseGroupForm = new Forms.CourseGroupForm();
            courseGroupForm.StrFormName = "فرم گروه درسی";
            courseGroupForm.ShowDialog();
        }

        private void btn_CourseSelect_Click(object sender, EventArgs e)
        {
            Forms.CourseSelectForm courseSelectForm = new Forms.CourseSelectForm();
            courseSelectForm.StrFormName = "فرم انتخاب واحد";
            courseSelectForm.ShowDialog();
        }
    }
}
