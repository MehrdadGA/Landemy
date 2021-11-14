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
    public partial class SearchCourseGroupForm : Forms.MasterForm.frmMaster
    {
        public int SendParameters = 0;

        public SearchCourseGroupForm()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            dgv_SearchGroupCourse.DataSource = new CourseGroupBusiness().GetList();

            SetSetting();
        }
        public void SetSetting()
        {
            dgv_SearchGroupCourse.Columns["ID"].Visible = false;
            dgv_SearchGroupCourse.Columns["FK_TeacherID"].Visible = false;
            dgv_SearchGroupCourse.Columns["FK_CourseID"].Visible = false;


            dgv_SearchGroupCourse.Columns["Title"].HeaderText = "نام درس";
            dgv_SearchGroupCourse.Columns["teacherName"].HeaderText = " نام استاد";
            dgv_SearchGroupCourse.Columns["LevelCourse"].HeaderText = " سطح";
            dgv_SearchGroupCourse.Columns["Tuition"].HeaderText = "شهریه";
            dgv_SearchGroupCourse.Columns["Year"].HeaderText = "سال";
            dgv_SearchGroupCourse.Columns["Term"].HeaderText = "ترم";
            dgv_SearchGroupCourse.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            dgv_SearchGroupCourse.Columns["WeekPlan"].HeaderText = "برنامه هفتگی";
        }

        private void SearchCourseGroupForm_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void dgv_SearchGroupCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_SearchGroupCourse.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void dgv_SearchGroupCourse_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SearchGroupCourse.Rows.Count > 1)
            {
                if (dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void dgv_SearchGroupCourse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_SearchGroupCourse.Rows.Count > 1)
            {
                if (dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void btn_SearchTeacherGroupCourse_Click(object sender, EventArgs e)
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
                    txt_SearchTeacherGroupCourse.Text = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["Name"].Value.ToString() + " " + searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["lastName"].Value.ToString();
                    txt_SearchTeacherGroupCourse.Tag = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_SearchGroupCourse.DataSource = new CourseGroupBusiness().DetailsByField("Teacher.ID", txt_SearchTeacherGroupCourse.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_CourseNameSearchGroupCourse_Click(object sender, EventArgs e)
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
                    txt_CourseNameSearchGroupCourse.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    txt_CourseNameSearchGroupCourse.Tag = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_SearchGroupCourse.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Course", txt_CourseNameSearchGroupCourse.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_YearSearchGroupCourse_Click(object sender, EventArgs e)
        {
            dgv_SearchGroupCourse.DataSource = new CourseGroupBusiness().DetailsByField("Year", txt_YearSearchGroupCourse.Text);
            SetSetting();
        }
    }
}
