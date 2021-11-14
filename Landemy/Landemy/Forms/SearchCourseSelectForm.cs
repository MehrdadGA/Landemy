using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy.Forms
{
    public partial class SearchCourseSelectForm : Forms.MasterForm.frmMaster
    {
        public int SendParameters = 0;

        App_Source.Shared.MsgBox msgBox = new App_Source.Shared.MsgBox();

        public SearchCourseSelectForm()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            dgv_SearchCourseSelect.DataSource = new CourseSelectBusiness().GetList();
            SetSetting();
        }
        public void SetSetting()
        {
            dgv_SearchCourseSelect.Columns["ID"].Visible = false;
            dgv_SearchCourseSelect.Columns["FK_CourseGroupID"].Visible = false;
            dgv_SearchCourseSelect.Columns["FK_StudentID"].Visible = false;
            dgv_SearchCourseSelect.Columns["StudentName"].HeaderText = "دانشجو";
            dgv_SearchCourseSelect.Columns["Title"].HeaderText = "نام درس";
            dgv_SearchCourseSelect.Columns["teacherName"].HeaderText = " نام استاد";
            dgv_SearchCourseSelect.Columns["LevelCourse"].HeaderText = " سطح";
            dgv_SearchCourseSelect.Columns["Tuition"].HeaderText = "شهریه";
            dgv_SearchCourseSelect.Columns["Year"].HeaderText = "سال";
            dgv_SearchCourseSelect.Columns["Term"].HeaderText = "ترم";
            dgv_SearchCourseSelect.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            dgv_SearchCourseSelect.Columns["AttendScore"].HeaderText = "نمره حضور و غیاب";
            dgv_SearchCourseSelect.Columns["FinalScore"].HeaderText = "نمره پایانی";
            dgv_SearchCourseSelect.Columns["ActivityScore"].HeaderText = "نمره فعالیت کلاسی ";
            dgv_SearchCourseSelect.Columns["Score"].HeaderText = "نمره کامل";
            dgv_SearchCourseSelect.Columns["WeekPaln"].HeaderText = "برنامه هفتگی";
            //------------------------Columns Width

            dgv_SearchCourseSelect.Columns["Term"].Width = 30;
            dgv_SearchCourseSelect.Columns["LevelCourse"].Width = 50;
            dgv_SearchCourseSelect.Columns["Year"].Width = 50;
            dgv_SearchCourseSelect.Columns["Tuition"].Width = 80;
            dgv_SearchCourseSelect.Columns["ClassNumber"].Width = 70;
            dgv_SearchCourseSelect.Columns["AttendScore"].Width = 70;
            dgv_SearchCourseSelect.Columns["FinalScore"].Width = 70;
            dgv_SearchCourseSelect.Columns["ActivityScore"].Width = 70;
            dgv_SearchCourseSelect.Columns["Score"].Width = 70;
            dgv_SearchCourseSelect.Columns["ClassNumber"].Width = 70;
            if (dgv_SearchCourseSelect.Rows.Count == 1)
            {
                msgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }

        }

        private void SearchCourseSelectForm_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CourseSelectTeacher_Click(object sender, EventArgs e)
        {
            Forms.SearchTeacherForm searchTeacherForm = new Forms.SearchTeacherForm();
            searchTeacherForm.StrFormName = "فرم جستجوی استاد";
            searchTeacherForm.ShowDialog();
            //---------------------------
            if (searchTeacherForm.SendParameters > 0)
            {
                if (searchTeacherForm.dgv_SearchTeacherMore.Rows.Count > 1)
                {
                    if (searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    txt_CourseSelectTeacher.Text = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["Name"].Value.ToString() + " " + searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["lastName"].Value.ToString();
                    txt_CourseSelectTeacher.Tag = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_SearchCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Teacher.ID", txt_CourseSelectTeacher.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void dgv_SearchCourseSelect_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_SearchCourseSelect.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void dgv_SearchCourseSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SearchCourseSelect.Rows.Count > 1)
            {
                if (dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void btn_CourseSelectCourseName_Click(object sender, EventArgs e)
        {
            Forms.SearchCourseForm searchCourseForm = new Forms.SearchCourseForm();
            searchCourseForm.StrFormName = "فرم جستجوی درس";
            searchCourseForm.ShowDialog();
            //---------------------------
            if (searchCourseForm.SendParameters > 0)
            {
                if (searchCourseForm.dgv_SearchCourse.Rows.Count > 1)
                {
                    if (searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    txt_CourseSelectCourseName.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    txt_CourseSelectCourseName.Tag = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_SearchCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Course.ID", txt_CourseSelectCourseName.Tag.ToString());
                    SetSetting();


                }
            }
        }

        private void btn_CourseSelectYear_Click(object sender, EventArgs e)
        {
            dgv_SearchCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Year", txt_CourseSelectYear.Text);
            if (dgv_SearchCourseSelect.Rows.Count == 1)
            {
                msgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }

            SetSetting();
        }

        private void btn_CourseSelectCourseGroup_Click(object sender, EventArgs e)
        {
            Forms.SearchCourseGroupForm searchCourseGroupForm = new Forms.SearchCourseGroupForm();
            searchCourseGroupForm.StrFormName = "فرم جستجوی گروه درسی";
            searchCourseGroupForm.ShowDialog();
            //---------------------------
            if (searchCourseGroupForm.SendParameters > 0)
            {
                if (searchCourseGroupForm.dgv_SearchGroupCourse.Rows.Count > 1)
                {
                    if (searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    string TeahcreName = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["teacherName"].Value.ToString(); ;
                    string CourseTitle = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["Title"].Value.ToString();
                    txt_CourseSelectCourseGroup.Text = CourseTitle + "(" + TeahcreName + ")";
                    txt_CourseSelectCourseGroup.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString();

                    dgv_SearchCourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("ID_FK_CourseGroup", txt_CourseSelectCourseGroup.Tag.ToString());
                    SetSetting();


                }
            }
        }
    }
}
