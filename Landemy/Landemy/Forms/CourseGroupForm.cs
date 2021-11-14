using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy.Forms
{
    public partial class CourseGroupForm : Forms.MasterForm.frmMaster
    {
        public CourseGroupForm()
        {
            InitializeComponent();
        }

        App_Source.Shared.MsgBox msgBox = new App_Source.Shared.MsgBox();

        private void GetList()
        {

            //if (txt_TuitionCourseGroup.Tag.ToString() != string.Empty)
            //{
            //    CourseGroupBusiness courseGroupBusiness = new CourseGroupBusiness();
            //    dgv_CourseGroup.DataSource = courseGroupBusiness.DetailsByField("CourseGroup.ID", txt_TuitionCourseGroup.Tag.ToString());
            //    SetSetting();
            //}
            //else
            //    dgv_CourseGroup.DataSource = null;

            dgv_CourseGroup.DataSource = new CourseGroupBusiness().GetList();
        }

        public void SetSetting()
        {
            dgv_CourseGroup.Columns["ID"].Visible = false;
            dgv_CourseGroup.Columns["ID_FK_Teacher"].Visible = false;
            dgv_CourseGroup.Columns["ID_FK_Course"].Visible = false;


            dgv_CourseGroup.Columns["Title"].HeaderText = "نام درس";
            dgv_CourseGroup.Columns["teacherName"].HeaderText = " نام استاد";
            dgv_CourseGroup.Columns["LevelCourse"].HeaderText = " سطح";
            dgv_CourseGroup.Columns["Tuition"].HeaderText = "شهریه";
            dgv_CourseGroup.Columns["Year"].HeaderText = "سال";
            dgv_CourseGroup.Columns["Term"].HeaderText = "ترم";
            dgv_CourseGroup.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            dgv_CourseGroup.Columns["WeekPaln"].HeaderText = "برنامه هفتگی";
        }

        public CourseGroup FillData()
        {
            CourseGroup courseGroup = new CourseGroup();
            courseGroup.FK_CourseID = int.Parse(txt_CourseNameCourseGroup.Tag.ToString());
            courseGroup.FK_TeacherID = int.Parse(txt_TeacherCourseGroup.Tag.ToString());
            courseGroup.LevelCourse = Convert.ToByte(com_LevelCourseGroup.SelectedIndex + 1);
            courseGroup.Term = Convert.ToByte(txt_TermCourseGroup.Text);
            courseGroup.Year = Convert.ToInt16(txt_YearCourseGroup.Text);
            courseGroup.WeekPlan = txt_WeeklyPlanCourseGroup.Text;
            courseGroup.Tuition = txt_TuitionCourseGroup.Text;
            courseGroup.ClassNumber = Convert.ToByte(txt_ClassNumberCourseGroup.Text);
            return courseGroup;
        }

        public void ClearText()
        {
            txt_CourseNameCourseGroup.Text = string.Empty;
            txt_CourseNameCourseGroup.Tag = string.Empty;
            txt_TuitionCourseGroup.Text = string.Empty;
            com_LevelCourseGroup.Items.Clear();
            txt_TeacherCourseGroup.Text = string.Empty;
            txt_TeacherCourseGroup.Tag = string.Empty;
            txt_WeeklyPlanCourseGroup.Text = string.Empty;
            txt_ClassNumberCourseGroup.Text = string.Empty;
            txt_TermCourseGroup.Text = string.Empty;
            com_LevelCourseGroup.Text = "انتخاب کنید";
            txt_TuitionCourseGroup.Tag = string.Empty;//   برای کد گروه درسی
            //-------------------Get Yaer
            PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            int year = persianCalendar.GetYear(dateTime);
            txt_YearCourseGroup.Text = year.ToString();
                    }

        private bool ValidateData()
        {
            erp_CourseGroup.Clear();
            bool Result = true;
            if (txt_CourseNameCourseGroup.Text.Trim() == string.Empty)
            {
                erp_CourseGroup.SetError(txt_CourseNameCourseGroup, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }
            if (txt_TuitionCourseGroup.Text.Trim() == string.Empty)
            {
                erp_CourseGroup.SetError(txt_TuitionCourseGroup, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }
            if (com_LevelCourseGroup.SelectedIndex == -1)
            {
                erp_CourseGroup.SetError(com_LevelCourseGroup, "لطفا این مقدار را وارد نمایید");
                Result = false;
            }
            if (txt_TeacherCourseGroup.Text.Trim() == string.Empty)
            {
                erp_CourseGroup.SetError(txt_TeacherCourseGroup, "لطفا این مقدار را وارد نمایید");
                Result = false;
            }

            return Result;
        }
        private void CourseGroupForm_Load(object sender, EventArgs e)
        {
            GetList();
            ClearText();
        }

        private void dgv_CourseGroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_CourseGroup.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void btn_CourseGroupInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

                CourseGroupBusiness courseGroupBusiness = new CourseGroupBusiness();
                CourseGroup courseGroup = FillData();

                txt_TuitionCourseGroup.Tag = courseGroupBusiness.Insert(courseGroup);

                GetList();
                msgBox.Show("درس مورد نظر اضافه شد", "درج درس");
                ClearText();
            }
        }

        private void btn_CourseGroupEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

                if (txt_TuitionCourseGroup.Tag.ToString() == string.Empty)
                {
                    msgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }

                CourseGroupBusiness courseGroupBusiness = new CourseGroupBusiness();
                CourseGroup courseGroup = FillData();
                courseGroup.ID = int.Parse(txt_TuitionCourseGroup.Tag.ToString());

                courseGroupBusiness.Update(courseGroup);

                GetList();
                msgBox.Show(" گروه درس مورد نظر اضافه شد", "درج گروه درسی");
                ClearText();
            }
        }

        private void dgv_CourseGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (dgv_CourseGroup.Rows.Count > 1)
            {


                if (dgv_CourseGroup.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_CourseGroup.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                txt_TuitionCourseGroup.Tag = dgv_CourseGroup.CurrentRow.Cells["ID"].Value.ToString();
                txt_TeacherCourseGroup.Tag = dgv_CourseGroup.CurrentRow.Cells["FK_TeacherID"].Value.ToString();
                txt_TeacherCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["TeacherName"].Value.ToString();
                txt_CourseNameCourseGroup.Tag = dgv_CourseGroup.CurrentRow.Cells["FK_CourseID"].Value.ToString();
                txt_CourseNameCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["Title"].Value.ToString();
                ////------------------Get all Level

                DataTable Dt = new CourseBusiness().DetailsByField("ID", txt_CourseNameCourseGroup.Tag.ToString());
                byte levelCount = Dt.Rows[0].Field<byte>("LevelCount");
                com_LevelCourseGroup.Items.Clear();
                for (int i = 1; i <= levelCount; i++)
                {
                    com_LevelCourseGroup.Items.Add(i);
                }

                com_LevelCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["LevelCourse"].Value.ToString();
                txt_TuitionCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["Tuition"].Value.ToString();
                txt_YearCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["Year"].Value.ToString();
                txt_TermCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["Term"].Value.ToString();
                txt_ClassNumberCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["ClassNumber"].Value.ToString();
                txt_WeeklyPlanCourseGroup.Text = dgv_CourseGroup.CurrentRow.Cells["WeekPaln"].Value.ToString();
            }
            else
                GetList();
        }

        private void btn_CourseGroupDelete_Click(object sender, EventArgs e)
        {
            if (txt_TuitionCourseGroup.Tag.ToString() == string.Empty)
            {
                msgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (msgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2)
                == DialogResult.OK)
            {
                CourseGroupBusiness courseGroupBusiness = new CourseGroupBusiness();
                CourseGroup courseGroup = FillData();
                courseGroup.ID = int.Parse(txt_TuitionCourseGroup.Tag.ToString());
                courseGroupBusiness.Delete(courseGroup);

                GetList();
                msgBox.Show("گروه درس مورد نظر حذف شد  ", "حذف  گروه درس");
                ClearText();
            }
        }

        private void btn_CourseName_Click(object sender, EventArgs e)
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
                    txt_CourseNameCourseGroup.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    txt_CourseNameCourseGroup.Tag = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    txt_TuitionCourseGroup.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["Tuition"].Value.ToString().Trim();
                    int LevelCount = int.Parse(searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["LevelCount"].Value.ToString());
                    com_LevelCourseGroup.Text = "انتخاب کنید";
                    com_LevelCourseGroup.Items.Clear();
                    for (int i = 1; i <= LevelCount; i++)
                    {
                        com_LevelCourseGroup.Items.Add(i);
                    }

                }
            }
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
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
                    txt_TeacherCourseGroup.Text = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["Name"].Value.ToString() + " " + searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["lastName"].Value.ToString();
                    txt_TeacherCourseGroup.Tag = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString();

                }
            }
        }

        private void btn_TeacherSearchCourseGroup_Click(object sender, EventArgs e)
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
                    txt_TeacherSearchCourseGroup.Text = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["Name"].Value.ToString() + " " + searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["lastName"].Value.ToString();
                    txt_TeacherSearchCourseGroup.Tag = searchTeacherForm.dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_CourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Teacher", txt_TeacherSearchCourseGroup.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_CourseNameSearchCourseGroup_Click(object sender, EventArgs e)
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
                    txt_CourseSearchCourseGroup.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    txt_CourseSearchCourseGroup.Tag = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    dgv_CourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("ID_FK_Course", txt_CourseSearchCourseGroup.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_YearSearchCourseGroup_Click(object sender, EventArgs e)
        {
            dgv_CourseGroup.DataSource = new CourseGroupBusiness().DetailsByField("Year", txt_YearSearchCourseGroup.Text);
            SetSetting();
        }

        private void btn_CourseGroupMoreSearch_Click(object sender, EventArgs e)
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
                    txt_TuitionCourseGroup.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString();
                    txt_TeacherCourseGroup.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["FK_TeacherID"].Value.ToString();
                    txt_TeacherCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["TeacherName"].Value.ToString();
                    txt_CourseNameCourseGroup.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["FK_CourseID"].Value.ToString();
                    txt_CourseNameCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["Title"].Value.ToString();
                    ////------------------Get all Level

                    DataTable Dt = new CourseBusiness().DetailsByField("ID", txt_CourseNameCourseGroup.Tag.ToString());
                    byte levelCount = Dt.Rows[0].Field<byte>("LevelCount");
                    com_LevelCourseGroup.Items.Clear();
                    for (int i = 1; i <= levelCount; i++)
                    {
                        com_LevelCourseGroup.Items.Add(i);
                    }

                    com_LevelCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["LevelCourse"].Value.ToString();
                    txt_TuitionCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["Tuition"].Value.ToString();
                    txt_YearCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["Year"].Value.ToString();
                    txt_TermCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["Term"].Value.ToString();
                    txt_ClassNumberCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ClassNumber"].Value.ToString();
                    txt_WeeklyPlanCourseGroup.Text = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["WeekPlan"].Value.ToString();
                }
            }
        }
    }
}
