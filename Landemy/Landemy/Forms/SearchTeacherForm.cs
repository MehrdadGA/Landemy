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
    public partial class SearchTeacherForm : Forms.MasterForm.frmMaster
    {
        public int SendParameters = 0;

        public SearchTeacherForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void GetList()
        {
            dgv_SearchTeacherMore.DataSource = new TeacherBusiness().GetList();
            SetSetting();
        }

        private void SetOnlyOne()
        {
            com_SearchTeacherDegree.DataSource = new DegreeBusiness().GetDegreeList();

            com_SearchTeacherSex.Text = "انتخاب کنید";
            com_SearchTeacherSex.Items.Add("مونث");
            com_SearchTeacherSex.Items.Add("مذکر");

            //------------------------------------------------------------------------
            com_SearchTeacherDegree.DisplayMember = "Title";
            com_SearchTeacherDegree.ValueMember = "ID";
            com_SearchTeacherDegree.AutoCompleteMode = AutoCompleteMode.Suggest;
            com_SearchTeacherDegree.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void SetSetting()
        {
            dgv_SearchTeacherMore.Columns["ID"].Visible = false;
            //dgv_SearchTeacherMore.Columns["Image"].Visible = false;
            dgv_SearchTeacherMore.Columns["FK_DegreeID"].Visible = false;
            dgv_SearchTeacherMore.Columns["Name"].HeaderText = "نام";
            dgv_SearchTeacherMore.Columns["LastName"].HeaderText = "نام خانوادگی";
            dgv_SearchTeacherMore.Columns["NationalCode"].HeaderText = "کد ملی";
            dgv_SearchTeacherMore.Columns["DegreeID"].HeaderText = "کد مدرک";
            dgv_SearchTeacherMore.Columns["Sex"].HeaderText = "جنسیت";
            dgv_SearchTeacherMore.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            dgv_SearchTeacherMore.Columns["Address"].HeaderText = "آدرس";
            dgv_SearchTeacherMore.Columns["Phone"].HeaderText = "شماره تلفن";

            //System.Threading.Thread thread = new System.Threading.Thread(LoadImage);
            //thread.Start();
        }

        private void SearchTeacherForm_Load(object sender, EventArgs e)
        {
            GetList();
            SetOnlyOne();
        }

        private void btn_StdNationalcodeSearch_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            dgv_SearchTeacherMore.DataSource = teacherBusiness.DetailsByField("NationalCode", txt_SearchTeacherNationalCode.Text);
            SetSetting();
        }

        private void pnl_SearchTeacherComponent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TaecherSearchName_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            dgv_SearchTeacherMore.DataSource = teacherBusiness.DetailsByField("Name", txt_SearchTeacherName.Text);
            SetSetting();
        }

        private void btn_TeacherFamilySearch_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            dgv_SearchTeacherMore.DataSource = teacherBusiness.DetailsByField("Name", txt_SearchTeacherLastName.Text);
            SetSetting();
        }

        private void btn_TeacherSearchSex_Click(object sender, EventArgs e)
        {
            TeacherBusiness studentBusiness = new TeacherBusiness();
            dgv_SearchTeacherMore.DataSource = studentBusiness.DetailsByField("Sex", com_SearchTeacherSex.SelectedIndex.ToString());
            SetSetting();
        }

        private void btn_TeacherSearchDegree_Click(object sender, EventArgs e)
        {
            TeacherBusiness studentBusiness = new TeacherBusiness();
            dgv_SearchTeacherMore.DataSource = studentBusiness.DetailsByField("FK_DegreeID", com_SearchTeacherDegree.SelectedIndex.ToString());
            SetSetting();
        }

        public void LoadImage()
        {
            for (int i = 0; i < dgv_SearchTeacherMore.RowCount; i++)
            {
                if (dgv_SearchTeacherMore.Rows[i].Cells["ID"].Value != null)
                {
                    string strId = dgv_SearchTeacherMore.Rows[i].Cells["ID"].Value.ToString();
                    if (System.IO.File.Exists("TeacherImage/" + strId + ".jpg"))
                    {
                        System.Drawing.Bitmap bitmap = new Bitmap(Image.FromFile("TeacherImage/" + strId + ".jpg"), 50, 50);
                        dgv_SearchTeacherMore.Rows[i].Cells["ClmImage"].Value = bitmap;
                        dgv_SearchTeacherMore.Rows[i].Height = 50;
                    }
                }
            }
        }

        private void dgv_SearchTeacherMore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_SearchTeacherMore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SearchTeacherMore.Rows.Count > 1)
            {
                SendParameters = int.Parse(dgv_SearchTeacherMore.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void dgv_SearchTeacherMore_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_SearchTeacherMore.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
    }
}
