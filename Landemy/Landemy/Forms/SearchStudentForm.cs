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
    public partial class SearchStudentForm : Forms.MasterForm.frmMaster
    {
        public int sendParameter = 0;

        public SearchStudentForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void SearchStudentForm_Load(object sender, EventArgs e)
        {
            GetList();
            SetOnlyOne();
        }


        private void dgv_SearchStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_SearchStudent.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        public void GetList()
        {
            dgv_SearchStudent.DataSource = new StudentBusiness().GetList();
            SetSetting();
        }

        public void SetSetting()
        {
            dgv_SearchStudent.Columns["ID"].Visible = false;
            dgv_SearchStudent.Columns["Image"].Visible = false;
            dgv_SearchStudent.Columns["FK_DegreeID"].Visible = false;
            dgv_SearchStudent.Columns["Name"].HeaderText = "نام";
            dgv_SearchStudent.Columns["LastName"].HeaderText = "نام خانوادگی";
            dgv_SearchStudent.Columns["NationalCode"].HeaderText = "کد ملی";
            dgv_SearchStudent.Columns["DegreeID"].HeaderText = "کد مدرک";
            dgv_SearchStudent.Columns["Sex"].HeaderText = "جنسیت";
            dgv_SearchStudent.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            dgv_SearchStudent.Columns["Address"].HeaderText = "آدرس";
            dgv_SearchStudent.Columns["Phone"].HeaderText = "شماره تلفن";

            System.Threading.Thread thread = new System.Threading.Thread(LoadImage);
            thread.Start();
        }

        private void SetOnlyOne()
        {
            com_StudentDegreeID_FK.DataSource = new DegreeBusiness().GetDegreeList();

            com_StudentSex.Text = "انتخاب کنید";
            com_StudentSex.Items.Add("مونث");
            com_StudentSex.Items.Add("مذکر");

            //------------------------------------------------------------------------
            com_StudentDegreeID_FK.DisplayMember = "Title";
            com_StudentDegreeID_FK.ValueMember = "ID";
            com_StudentDegreeID_FK.AutoCompleteMode = AutoCompleteMode.Suggest;
            com_StudentDegreeID_FK.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btn_StdNationalcodeSearch_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgv_SearchStudent.DataSource = studentBusiness.DetailsByField("NationalCode", txt_NationalSearch.Text);
            SetSetting();
        }

        private void btn_StdSearchName_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgv_SearchStudent.DataSource = studentBusiness.DetailsByField("Name", txt_NameSearch.Text);
            SetSetting();
        }

        private void btn_stdFamilySearch_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgv_SearchStudent.DataSource = studentBusiness.DetailsByField("LastName", txt_FamilySearch.Text);
            SetSetting();
        }

        private void dgv_SearchStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_SearchStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgv_SearchStudent.DataSource = studentBusiness.DetailsByField("Sex", com_StudentSex.SelectedIndex.ToString()) ;
            SetSetting();
        }

        private void btn_SearchDegreeStd_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            dgv_SearchStudent.DataSource = studentBusiness.DetailsByField("FK_DegreeID", com_StudentDegreeID_FK.SelectedValue.ToString());
            SetSetting();
        }

        private void dgv_SearchStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SearchStudent.Rows.Count > 1)
            {
                sendParameter = int.Parse(dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        public void LoadImage()
        {
            for (int i = 0; i < dgv_SearchStudent.RowCount; i++)
            {
                if (dgv_SearchStudent.Rows[i].Cells["ID"].Value != null) 
                {
                    string strId = dgv_SearchStudent.Rows[i].Cells["ID"].Value.ToString();
                    if (System.IO.File.Exists("StudentImage/" + strId + ".jpg"))
                    {
                        System.Drawing.Bitmap bitmap = new Bitmap(Image.FromFile("StudentImage/" + strId + ".jpg"), 50, 50);
                        dgv_SearchStudent.Rows[i].Cells["ClmImage"].Value = bitmap;
                        dgv_SearchStudent.Rows[i].Height = 50;
                    }
                }
            }
        }
    }
}
