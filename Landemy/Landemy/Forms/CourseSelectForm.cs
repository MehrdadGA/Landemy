using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy.Forms
{
    public partial class CourseSelectForm : Forms.MasterForm.frmMaster
    {
        public CourseSelectForm()
        {
            InitializeComponent();
        }

        App_Source.Shared.MsgBox msgBox = new App_Source.Shared.MsgBox();

        private bool ValidateData()
        {
            erp_CourseSelect.Clear();
            bool Result = true;
            if (txt_CourseSelectStudent.Text.Trim() == string.Empty)
            {
                erp_CourseSelect.SetError(txt_CourseSelectStudent, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }
            if (txt_CourseSelectCourse.Text.Trim() == string.Empty)
            {
                erp_CourseSelect.SetError(txt_CourseSelectCourse, "لطفا این مقدار را درست وارد نمایید");
                Result = false;
            }

            if (txt_CourseSelectAttendScore.Text == string.Empty)
                txt_CourseSelectAttendScore.Text = "0.00";
            if (txt_CourseSelectFinalScore.Text == string.Empty)
                txt_CourseSelectFinalScore.Text = "0.00";
            if (txt_CourseSelectActivityScore.Text == string.Empty)
                txt_CourseSelectActivityScore.Text = "0.00";

            decimal AttendScoure = Convert.ToDecimal(txt_CourseSelectAttendScore.Text);
            decimal FinalScore = Convert.ToDecimal(txt_CourseSelectFinalScore.Text);
            decimal ActivitScore = Convert.ToDecimal(txt_CourseSelectActivityScore.Text);
            if ((AttendScoure + FinalScore + ActivitScore) > 100)
            {
                msgBox.Show("جمع نمرات نباید از 100 بیشتر باشد", "انتخاب واحد");
                Result = false;
            }

            return Result;
        }
        public void ClearText()
        {
            txt_CourseSelectStudent.Text = string.Empty;
            txt_CourseSelectStudent.Tag = string.Empty;
            txt_CourseSelectCourse.Text = string.Empty;
            txt_CourseSelectCourse.Tag = string.Empty;
            txt_CourseSelectFinalScore.Tag = string.Empty;
            txt_CourseSelectAttendScore.Text = "0.00";
            txt_CourseSelectFinalScore.Text = "0.00";
            txt_CourseSelectActivityScore.Text = "0.00";
        }

        private void GetList()
        {

            //if (txt_CourseSelectFinalScore.Tag.ToString() != string.Empty)
            //{
            //    CourseSelectBusiness courseSelectBusiness = new CourseSelectBusiness();
            //    dgv_CourseSelect.DataSource = courseSelectBusiness.DetailsByField("CourseSelect.ID", txt_CourseSelectFinalScore.Tag.ToString());
            //    SetSetting();
            //}
            //else
            //    dgv_CourseSelect.DataSource = null;

            dgv_CourseSelect.DataSource = new CourseSelectBusiness().GetList();
        }

        public void SetSetting()
        {
            dgv_CourseSelect.Columns["ID"].Visible = false;
            dgv_CourseSelect.Columns["FK_CourseGroupID"].Visible = false;
            dgv_CourseSelect.Columns["FK_StudentID"].Visible = false;
            dgv_CourseSelect.Columns["StudentName"].HeaderText = "دانشجو";
            dgv_CourseSelect.Columns["Title"].HeaderText = "نام درس";
            dgv_CourseSelect.Columns["teacherName"].HeaderText = " نام استاد";
            dgv_CourseSelect.Columns["LevelCourse"].HeaderText = " سطح";
            dgv_CourseSelect.Columns["Tuition"].HeaderText = "شهریه";
            dgv_CourseSelect.Columns["Year"].HeaderText = "سال";
            dgv_CourseSelect.Columns["Term"].HeaderText = "ترم";
            dgv_CourseSelect.Columns["ClassNumber"].HeaderText = "شماره کلاس";
            dgv_CourseSelect.Columns["AttendScore"].HeaderText = "نمره حضور و غیاب";
            dgv_CourseSelect.Columns["FinalScore"].HeaderText = "نمره پایانی";
            dgv_CourseSelect.Columns["ActivityScore"].HeaderText = "نمره فعالیت کلاسی ";
            dgv_CourseSelect.Columns["Score"].HeaderText = "نمره کامل";
            dgv_CourseSelect.Columns["WeekPlan"].HeaderText = "برنامه هفتگی";
            //------------------------Columns Width
            dgv_CourseSelect.Columns["Term"].Width = 30;
            dgv_CourseSelect.Columns["LevelCourse"].Width = 50;
            dgv_CourseSelect.Columns["Year"].Width = 50;
            dgv_CourseSelect.Columns["Tuition"].Width = 80;
            dgv_CourseSelect.Columns["ClassNumber"].Width = 70;
            dgv_CourseSelect.Columns["AttendScore"].Width = 70;
            dgv_CourseSelect.Columns["FinalScore"].Width = 70;
            dgv_CourseSelect.Columns["ActivityScore"].Width = 70;
            dgv_CourseSelect.Columns["Score"].Width = 70;
            dgv_CourseSelect.Columns["ClassNumber"].Width = 70;
            dgv_CourseSelect.Columns["ColumnRowNumber"].Width = 70;
            if (dgv_CourseSelect.Rows.Count == 1)
            {
                msgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }

        }
        public CourseSelect FillData()
        {
            CourseSelect courseSelect = new CourseSelect();
            courseSelect.FK_StudentID = int.Parse(txt_CourseSelectStudent.Tag.ToString());
            courseSelect.FK_CourseGroupID = int.Parse(txt_CourseSelectCourse.Tag.ToString());
            courseSelect.FinalScore = Convert.ToDecimal(txt_CourseSelectFinalScore.Text);
            courseSelect.ActivityScore = Convert.ToDecimal(txt_CourseSelectActivityScore.Text);
            courseSelect.AttendScore = Convert.ToDecimal(txt_CourseSelectAttendScore.Text);
            return courseSelect;

        }

        private void CourseSelectForm_Load(object sender, EventArgs e)
        {
            GetList();
            ClearText();
        }

        private void dgv_CourseSelect_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_CourseSelect.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void dgv_CourseSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            if (dgv_CourseSelect.Rows.Count > 1)
            {


                if (dgv_CourseSelect.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_CourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                txt_CourseSelectStudent.Text = dgv_CourseSelect.CurrentRow.Cells["StudentName"].Value.ToString();
                txt_CourseSelectStudent.Tag = dgv_CourseSelect.CurrentRow.Cells["FK_StudentID"].Value.ToString();
                string TeahcreName = dgv_CourseSelect.CurrentRow.Cells["teacherName"].Value.ToString(); ;
                string CourseTitle = dgv_CourseSelect.CurrentRow.Cells["Title"].Value.ToString();

                txt_CourseSelectCourse.Text = CourseTitle + "(" + TeahcreName + ")";
                txt_CourseSelectCourse.Tag = dgv_CourseSelect.CurrentRow.Cells["FK_CourseGroupID"].Value.ToString();
                txt_CourseSelectAttendScore.Text = dgv_CourseSelect.CurrentRow.Cells["AttendScore"].Value.ToString();
                txt_CourseSelectFinalScore.Text = dgv_CourseSelect.CurrentRow.Cells["FinalScore"].Value.ToString();
                txt_CourseSelectActivityScore.Text = dgv_CourseSelect.CurrentRow.Cells["ActivityScore"].Value.ToString();
                txt_CourseSelectFinalScore.Tag = dgv_CourseSelect.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void btn_CourseSelectInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {

                CourseSelectBusiness courseSelectBusiness = new CourseSelectBusiness();
                CourseSelect courseSelect = FillData();
                if (courseSelectBusiness.Insert(courseSelect) == 0)
                {
                    msgBox.Show("این دانشجو قبلا این انتخاب را انجام داده است", "انتخاب واحد");
                }
                else
                {

                    GetList();
                    msgBox.Show("انتخاب واحد مورد نظر اضافه شد", "انتخاب واحد");
                    ClearText();
                }
            }
        }

        private void btn_CourseSelectUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (txt_CourseSelectFinalScore.Tag.ToString() == string.Empty)
                {
                    msgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                    return;
                }


                CourseSelectBusiness courseSelectBusiness = new CourseSelectBusiness();
                CourseSelect courseSelect = FillData();

                courseSelect.ID = int.Parse(txt_CourseSelectFinalScore.Tag.ToString());
                courseSelectBusiness.Update(courseSelect);
                GetList();
                msgBox.Show(" انتخاب واحد مورد نظر ویرایش شد", "ویرایش انتخاب واحد");
                ClearText();
            }
        }

        private void btn_CourseSelectDelete_Click(object sender, EventArgs e)
        {
            if (txt_CourseSelectFinalScore.Tag.ToString() == string.Empty)
            {
                msgBox.Show("لطفا بر روی رکورد مورد نظر کلیک کنید", "هشدار");
                return;
            }
            if (msgBox.Show("آیا می خواهید این رکورد حذف شود", "هشدار", 2)
                == DialogResult.OK)
            {
                CourseSelectBusiness courseSelectBusiness = new CourseSelectBusiness();
                CourseSelect courseSelect = FillData();

                courseSelect.ID = int.Parse(txt_CourseSelectFinalScore.Tag.ToString());
                courseSelectBusiness.Delete(courseSelect);
                GetList();
                msgBox.Show(" انتخاب واحد مورد نظر حذف شد", "حذف انتخاب واحد");
                ClearText();
            }
        }

        private void btn_CourseSelectGroup_Click(object sender, EventArgs e)
        {
            DataTable DTable = new DataTable();
            DTable.Columns.Add("IDCourseGroup");
            DTable.Columns.Add("IDStudent");
            for (int i = 0; i < dgv_CourseSelect.RowCount - 1; ++i)
            {
                DTable.Rows.Add(txt_CourseSelectCourse.Tag,
                    dgv_CourseSelect.Rows[i].Cells["FK_StudentID"].Value.ToString()
                           );
            }
            

            SqlCon con = new SqlCon();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = "SelectCourseAll";
            Sqlcmd.Parameters.AddWithValue("@tbl_Input", DTable);
            Sqlcmd.Connection = con.Open();
            Sqlcmd.ExecuteNonQuery();
            con.Close();
            msgBox.Show("انتخاب گروهی انجام شد");
        }

        private void btn_CourseSelectStudent_Click(object sender, EventArgs e)
        {
            Forms.SearchStudentForm searchStudentForm = new Forms.SearchStudentForm();
            searchStudentForm.StrFormName = "فرم جستجوی دانش آموز";
            searchStudentForm.ShowDialog();
            //---------------------------
            if (searchStudentForm.sendParameter >= 0)
            {
                if (searchStudentForm.dgv_SearchStudent.Rows.Count > 1)
                {
                    if (searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    string Name = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Name"].Value.ToString(); ;
                    string LastName = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["LastName"].Value.ToString();

                    txt_CourseSelectStudent.Text = Name + " " + LastName;
                    txt_CourseSelectStudent.Tag = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
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

                    txt_CourseSelectCourse.Text = CourseTitle + "(" + TeahcreName + ")";
                    txt_CourseSelectCourse.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
        }

        private void btn_CourseSelectSearchStudent_Click(object sender, EventArgs e)
        {
            Forms.SearchStudentForm searchStudentForm = new Forms.SearchStudentForm();
            searchStudentForm.StrFormName = "فرم جستجوی دانش آموز";
            searchStudentForm.ShowDialog();
            //---------------------------
            if (searchStudentForm.sendParameter > 0)
            {
                if (searchStudentForm.dgv_SearchStudent.Rows.Count > 1)
                {
                    if (searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    string Name = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Name"].Value.ToString(); ;
                    string LastName = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["LastName"].Value.ToString();

                    txt_CourseSelectSearchStudent.Text = Name + " " + LastName;
                    txt_CourseSelectSearchStudent.Tag = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString();

                    dgv_CourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Student.ID", txt_CourseSelectSearchStudent.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_CourseSSearchGroup_Click(object sender, EventArgs e)
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
                    txt_GroupSelectSearchCourse.Text = CourseTitle + "(" + TeahcreName + ")";
                    txt_GroupSelectSearchCourse.Tag = searchCourseGroupForm.dgv_SearchGroupCourse.CurrentRow.Cells["ID"].Value.ToString();

                    dgv_CourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("ID_FK_CourseGroup", txt_GroupSelectSearchCourse.Tag.ToString());
                    SetSetting();
                }
            }
        }

        private void btn_CourseSelectYear_Click(object sender, EventArgs e)
        {
            dgv_CourseSelect.DataSource = new CourseSelectBusiness().DetailsByField("Year", txt_GroupSelectSearchYear.Text);
            if (dgv_CourseSelect.Rows.Count == 1)
            {
                msgBox.Show("هیچ رکوردی پیدا نشد", " انتخاب واحد");
            }

            SetSetting();
        }

        private void btn_GroupSelectMoreSearch_Click(object sender, EventArgs e)
        {
            Forms.SearchCourseSelectForm searchCourseSelectForm = new Forms.SearchCourseSelectForm();
            searchCourseSelectForm.StrFormName = "فرم جستجوی انتخاب واحد ها";
            searchCourseSelectForm.ShowDialog();
            //---------------------------
            if (searchCourseSelectForm.SendParameters > 0)
            {
                if (searchCourseSelectForm.dgv_SearchCourseSelect.Rows.Count > 1)
                {
                    if (searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value == null)
                        return;
                    if (searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                        return;
                    txt_CourseSelectStudent.Text = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["StudentName"].Value.ToString();
                    txt_CourseSelectStudent.Tag = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["FK_StudentID"].Value.ToString();
                    string TeahcreName = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["TeacherName"].Value.ToString(); ;
                    string CourseTitle = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["Title"].Value.ToString();

                    txt_CourseSelectCourse.Text = CourseTitle + "(" + TeahcreName + ")";
                    txt_CourseSelectCourse.Tag = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["FK_CourseGroupID"].Value.ToString();
                    txt_CourseSelectAttendScore.Text = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["AttendScore"].Value.ToString();
                    txt_CourseSelectFinalScore.Text = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["FinalScore"].Value.ToString();
                    txt_CourseSelectActivityScore.Text = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["ActivityScore"].Value.ToString();
                    txt_CourseSelectFinalScore.Tag = searchCourseSelectForm.dgv_SearchCourseSelect.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
        }
    }
}
