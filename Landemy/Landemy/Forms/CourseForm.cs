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
    public partial class CourseForm : Forms.MasterForm.frmMaster
    {
        App_Source.Shared.MsgBox msgBox = new App_Source.Shared.MsgBox();

        public CourseForm()
        {
            InitializeComponent();
        }

        private void GetList()
        {

            //if (txt_CourseName.Tag.ToString() != string.Empty)
            //{
            //    CourseBusiness courseBusiness = new CourseBusiness();
            //    dgv_Course.DataSource = courseBusiness.DetailsByField("Course.ID", txt_CourseName.Tag.ToString());
            //    SetSetting();
            //}
            //else
            //    dgv_Course.DataSource = null;

            dgv_Course.DataSource = new CourseBusiness().GetList();
        }

        public void SetSetting()
        {
            dgv_Course.Columns["ID"].Visible = false;

            dgv_Course.Columns["Title"].HeaderText = "نام درس";
            dgv_Course.Columns["LevelCount"].HeaderText = "تعداد سطح";
            dgv_Course.Columns["Tuition"].HeaderText = "شهریه";

            if (dgv_Course.Rows.Count == 1)
            {
                msgBox.Show("برای مقدار وارد شده هیچ رکوردی پیدا نشد", "هشدار");
            }
        }

        public void ClearText()
        {
            txt_CourseName.Text = string.Empty;
            txt_CorseLevelCount.Text = string.Empty;
            txt_CourseTuition.Text = string.Empty;
            txt_CourseName.Tag = string.Empty;

        }
        public Course FillData()
        {
            Course course = new Course();
            course.Title = txt_CourseName.Text;
            course.LevelCount = Convert.ToByte(txt_CorseLevelCount.Text);
            course.Tuition = txt_CourseTuition.Text;

            return course;
        }
        private bool ValidateData()
        {
            erp_Course.Clear();
            bool Result = true;
            if (txt_CourseName.Text.Trim() == string.Empty)
            {
                erp_Course.SetError(txt_CourseName, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }
            if (txt_CorseLevelCount.Text.Trim() == string.Empty)
            {
                erp_Course.SetError(txt_CorseLevelCount, "لطفا این مقدار را وارد نمایید");
                Result = false;
            }
            if (txt_CourseTuition.Text.Trim() == string.Empty)
            {
                erp_Course.SetError(txt_CourseTuition, "لطفا این مقدار را وارد نمایید");
                Result = false;
            }

            return Result;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            GetList();
            ClearText();
        }

        private void btn_CourseInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseBusiness courseBusiness = new CourseBusiness();

                Course course = FillData();

                int ID = courseBusiness.Insert(course);
                txt_CourseName.Tag = ID;
                GetList();
                msgBox.Show("درس مورد نظر اضافه شد", "درج درس");
                ClearText();
            }
        }

        private void btn_CourseEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CourseBusiness courseBusiness = new CourseBusiness();


                Course course = FillData();
                course.ID = int.Parse(txt_CourseName.Tag.ToString());
                courseBusiness.Update(course);

                GetList();
                msgBox.Show("درس مورد نظر اضافه شد", "درج درس");
                ClearText();
            }
        }

        private void btn_CourseDelete_Click(object sender, EventArgs e)
        {
            CourseBusiness courseBusiness = new CourseBusiness();
            if (txt_CourseName.Tag.ToString() == string.Empty)
            {
                msgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (msgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2)
                == DialogResult.OK)
            {
                Course course = new Course();
                course.ID = int.Parse(txt_CourseName.Tag.ToString());
                courseBusiness.Delete(course);

                GetList();
                msgBox.Show("درس مورد نظر حذف شد", "حذف درس");
                ClearText();
            }
        }

        private void btn_CourseNameSearch_Click(object sender, EventArgs e)
        {
            CourseBusiness courseBusiness = new CourseBusiness();
            dgv_Course.DataSource = courseBusiness.DetailsByField("title", txt_CourseSearchName.Text);
            SetSetting();
        }

        private void dgv_Course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (dgv_Course.Rows.Count > 1)
            {
                if (dgv_Course.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_Course.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                txt_CourseName.Tag = dgv_Course.CurrentRow.Cells["ID"].Value.ToString();
                txt_CourseName.Text = dgv_Course.CurrentRow.Cells["title"].Value.ToString();
                txt_CorseLevelCount.Text = dgv_Course.CurrentRow.Cells["LevelCount"].Value.ToString();
                txt_CourseTuition.Text = dgv_Course.CurrentRow.Cells["Tuition"].Value.ToString();

            }
            else
                GetList();
        }

        private void btn_MoreCourseSearch_Click(object sender, EventArgs e)
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
                    txt_CourseName.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["title"].Value.ToString();
                    txt_CourseName.Tag = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString();
                    txt_CorseLevelCount.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["LevelCount"].Value.ToString();
                    txt_CourseTuition.Text = searchCourseForm.dgv_SearchCourse.CurrentRow.Cells["Tuition"].Value.ToString();

                }
            }
        }

        private void dgv_Course_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Course.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
    }
}
