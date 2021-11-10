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
    public partial class TeacherForm : Forms.MasterForm.frmMaster
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        App_Source.Shared.MsgBox MsgBox = new App_Source.Shared.MsgBox();

        private void ClearText()
        {
            txt_TeacherName.Text = string.Empty;
            txt_TeacherLastName.Text = string.Empty;
            txt_TeacherNationalCode.Text = string.Empty;
            txt_TeacherPhone.Text = string.Empty;
            com_TeahcerSex.Text = "انتخاب کنید";
            txt_TeacherAddress.Text = string.Empty;
            pic_Teacher.Tag = string.Empty;
            pic_Teacher.Image = null;
            erp_teacher.Clear();
        }

        public void GetList()
        {

            dgv_Teacher.MultiSelect = true;
            dgv_Teacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgv_Teacher.DataSource = new TeacherBusiness().GetList();
         //   com_TeacherDegree.DataSource = new DegreeBusiness().GetDegreeList();
        }

        public void SetSetting()
        {
            dgv_Teacher.Columns["ID"].Visible = false;
            dgv_Teacher.Columns["FK_DegreeID"].Visible = false;
            //dgv_Teacher.Columns["FK_DegreeID"].Visible = false;
            dgv_Teacher.Columns["NationalCode"].HeaderText = "کد ملی";
            dgv_Teacher.Columns["Name"].HeaderText = "نام";
            dgv_Teacher.Columns["DegreeID"].HeaderText = "مدرک";
            dgv_Teacher.Columns["LastName"].HeaderText = "نام خانوادگی";
            dgv_Teacher.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            dgv_Teacher.Columns["Sex"].HeaderText = "جنسیت";
            dgv_Teacher.Columns["Phone"].HeaderText = "تلفن";
            dgv_Teacher.Columns["Address"].HeaderText = "آدرس";

            if (dgv_Teacher.Rows.Count == 1)
            {
                MsgBox.Show("برای مقدار وارد شده رکوردی موجود نیست", "هشدار");
            }
            //------------------------------------------------------------------------
            com_TeacherDegree.DisplayMember = "Title";
            com_TeacherDegree.ValueMember = "ID";
            com_TeacherDegree.AutoCompleteMode = AutoCompleteMode.Suggest;
            com_TeacherDegree.AutoCompleteSource = AutoCompleteSource.ListItems;
            //------------------------------------------------------------------------
            com_TeahcerSex.Text = "انتخاب کنید";
            com_TeahcerSex.Items.Add("مونث");
            com_TeahcerSex.Items.Add("مذکر");
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            GetList();
            SetSetting();
        }

        private void lbl_TeacherDegree_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Teacher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Teacher.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private bool ValidateData()
        {
            erp_teacher.Clear();
            bool Result = true;
            if (txt_TeacherNationalCode.Text.Trim() == string.Empty || txt_TeacherNationalCode.Text.Trim().Length != 10)
            {
                erp_teacher.SetError(txt_TeacherNationalCode, "لطفا مقدار کد ملی را صحیح وارد کنید");
                return false;
            }
            if (txt_TeacherName.Text.Trim() == string.Empty)
            {
                erp_teacher.SetError(txt_TeacherName, "لطفا مقدار نام را وارد نمایید");
                return false;
            }
            if (txt_TeacherLastName.Text.Trim() == string.Empty)
            {
                erp_teacher.SetError(txt_TeacherLastName, "لطفا فیلد نام خانوادگب را پر کنید");
                return false;
            }
            if (com_TeahcerSex.SelectedIndex == -1)
            {
                erp_teacher.SetError(com_TeahcerSex, "لطفا جنسیت را انتخاب کنید");
                return false;
            }
            return Result;
        }

        public Teacher FillData()
        {
            Teacher teacher = new Teacher();
            teacher.NationalCode = txt_TeacherNationalCode.Text;
            teacher.Name = txt_TeacherName.Text;
            teacher.LastName = txt_TeacherLastName.Text;
            teacher.FK_DegreeID = int.Parse(com_TeacherDegree.SelectedValue.ToString());
            teacher.DateOfBirth = datePicker1.txtDate.Text;
            teacher.Sex = Convert.ToByte(com_TeahcerSex.SelectedIndex);
            teacher.Phone = txt_TeacherPhone.Text;
            teacher.Address = txt_TeacherAddress.Text;
            return teacher;
        }

        private void dgv_Teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Teacher.Rows.Count > 1)
            {
                txt_TeacherNationalCode.Text = dgv_Teacher.CurrentRow.Cells["NationalCode"].Value.ToString();
                txt_TeacherNationalCode.Tag = dgv_Teacher.CurrentRow.Cells["ID"].Value.ToString();
                txt_TeacherName.Text = dgv_Teacher.CurrentRow.Cells["Name"].Value.ToString();
                txt_TeacherLastName.Text = dgv_Teacher.CurrentRow.Cells["LastName"].Value.ToString();
               
                com_TeacherDegree.Text = dgv_Teacher.CurrentRow.Cells["DegreeID"].Value.ToString();
                com_TeahcerSex.Text = dgv_Teacher.CurrentRow.Cells["Sex"].Value.ToString();
                

                txt_TeacherPhone.Text = dgv_Teacher.CurrentRow.Cells["Phone"].Value.ToString();
                txt_TeacherAddress.Text = dgv_Teacher.CurrentRow.Cells["Address"].Value.ToString();
                datePicker1.Text = dgv_Teacher.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            }
        }

        private void btn_TeacherInsert_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                DataTable dataTable = teacherBusiness.DetailsByField("NationalCode", txt_TeacherNationalCode.Text);
                if (dataTable.Rows.Count > 0)
                {
                    MsgBox.Show("این کد ملی وجود دارد", "خطا");
                    return;
                }
                Teacher teacher = FillData();
                teacherBusiness.Insert(teacher);
                GetList();
                MsgBox.Show("درج استاد انجام شد", "درج استاد", 1);
                ClearText();
            }
        }

        private void btn_TeacherEdit_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                if (txt_TeacherNationalCode.Tag.ToString() == string.Empty)
                {
                    MsgBox.Show("بر روی رکورد مورد نظر جهت ویرایش کلیک کنید.");
                    return;
                }
                Teacher teacher = FillData();
                teacherBusiness.Update(teacher);
                GetList();
                MsgBox.Show("ویرایش استاد انجام شد", "ویرایش استاد", 1);
                ClearText();
            }
        }

        private void btn_TeacherDelete_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            if (txt_TeacherNationalCode.Tag.ToString() == string.Empty)
            {
                MsgBox.Show("بر روی رکورد مورد نظر جهت حذف کلیک کنید.");
                return;
            }
            if (MsgBox.Show("آیا میخواهید رکورد حذف گردد؟", "هشدار", 2) == DialogResult.OK)
            {
                Teacher teacher = new Teacher();
                var id = dgv_Teacher.CurrentRow.Cells["ID"].Value.ToString();

                teacher.ID = int.Parse(id);

               // teacherBusiness.Delete(int.Parse(id));

                teacherBusiness.Delete(teacher);
                GetList();
                MsgBox.Show("حذف دانش آموز انجام شد", "حذف دانش آموز", 1);
                ClearText();
            }
        }

        private void btn_TeacherSearchNationalCode_Click(object sender, EventArgs e)
        {
            if (txt_TeacherSearchNationalCode.Text.Trim().Length >= 2)
            {
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                dgv_Teacher.DataSource = teacherBusiness.DetailsByField("NationalCode", txt_TeacherSearchNationalCode.Text);
                SetSetting();
            }
            else
                MsgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void btn_TeacheSearchName_Click(object sender, EventArgs e)
        {
            if (txt_TeacherSearchName.Text.Trim().Length >= 2)
            {
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                dgv_Teacher.DataSource = teacherBusiness.DetailsByField("Name", txt_TeacherSearchName.Text);
                SetSetting();
            }
            else
                MsgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void btn_TeacherSearchLastName_Click(object sender, EventArgs e)
        {
            if (txt_TeacherSearchLastName.Text.Trim().Length >= 2)
            {
                TeacherBusiness teacherBusiness = new TeacherBusiness();
                dgv_Teacher.DataSource = teacherBusiness.DetailsByField("LastName", txt_TeacherSearchLastName.Text);
                SetSetting();
            }
            else
                MsgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void dgv_Teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
