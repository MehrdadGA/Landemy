using Landemy.App_Source.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winprint;

namespace Landemy.Forms
{
    public partial class StudentForm : Forms.MasterForm.frmMaster
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        bool ChangePicture = false;

        private void ClearText()
        {
            txt_StudentNationalCode.Text = string.Empty;
            txt_StudentLastName.Text = string.Empty;
            txt_StudentAddress.Text = string.Empty;
            txtStudentFirstName.Text = string.Empty;
            com_StudentSex.Text = "انتخاب کنید";
            txt_StudentAddress.Text = string.Empty;
            erp_Student.Clear();
            pictureBox1.Tag = string.Empty;
            pictureBox1.Image = null;
        }

        public void GetList()
        {
            dgv_Student.DataSource = new StudentBusiness().GetList();
        }

        public void SetSetting()
        {
            dgv_Student.Columns["ID"].Visible = false;
            dgv_Student.Columns["Image"].Visible = false;
            dgv_Student.Columns["FK_DegreeID"].Visible = false;
            dgv_Student.Columns["Name"].HeaderText = "نام";
            dgv_Student.Columns["LastName"].HeaderText = "نام خانوادگی";
            dgv_Student.Columns["NationalCode"].HeaderText = "کد ملی";
            dgv_Student.Columns["DegreeID"].HeaderText = "کد مدرک";
            dgv_Student.Columns["Sex"].HeaderText = "جنسیت";
            dgv_Student.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
            dgv_Student.Columns["Address"].HeaderText = "آدرس";
            dgv_Student.Columns["Phone"].HeaderText = "شماره تلفن";

            if (dgv_Student.Rows.Count == 1)
            {
                msgBox.Show("برای مقدار وارد شده رکوردی پیدا نشد", "هشدار");
            }
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            GetList();
            SetSetting();
            SetOnlyOne();
        }

        private void dgv_Student_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Student.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void btn_StudentInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidateData()
        {
            erp_Student.Clear();
            bool Result = true;
            if (txt_StudentNationalCode.Text.Trim() == string.Empty || txt_StudentNationalCode.Text.Trim().Length != 10)
            {
                erp_Student.SetError(txt_StudentNationalCode, "لطفا مقداری در کد ملی وارد نمایید");
                return false;
            }
            if (txtStudentFirstName.Text.Trim() == string.Empty)
            {
                erp_Student.SetError(txtStudentFirstName, "لطفا مقدار در نام را وارد نمایید");
                return false;
            } 
            if (txt_StudentLastName.Text.Trim() == string.Empty)
            {
                erp_Student.SetError(txt_StudentLastName, "لطفا مقدار در نام خانوادگی را وارد نمایید");
                return false;
            }
            if (com_StudentSex.SelectedIndex == -1)
            {
                erp_Student.SetError(com_StudentSex, "لطفا جنسیت را وارد نمایید");
                return false;
            }
            return Result;
        }

        public Student FillData()
        {
            Student student = new Student();
            student.Name = txtStudentFirstName.Text;
            student.NationalCode = txt_StudentNationalCode.Text;
            student.Sex = Convert.ToByte(com_StudentSex.SelectedIndex);
            student.Phone = baseTextBox2.Text;
            student.LastName = txt_StudentLastName.Text;
            student.Address = txt_StudentAddress.Text;
            student.DateOfBirth = datePicker.txtDate.Text;
            student.FK_DegreeID = int.Parse(com_StudentDegreeID_FK.SelectedValue.ToString());
            return student;
        }

        App_Source.Shared.MsgBox msgBox = new App_Source.Shared.MsgBox();
        private void btn_StudentInsert_Click_1(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                StudentBusiness studentBusiness = new StudentBusiness();
                DataTable dataTable = studentBusiness.DetailsByField("NationalCode", txt_StudentNationalCode.Text);
                if (dataTable.Rows.Count > 0)
                {
                    msgBox.Show("این کد ملی وجود دارد", "خطا");
                    return;
                }
                Student student = FillData();
                int id = studentBusiness.Insert(student);
                if (id > 0)
                {
                    
                    if (pictureBox1.Tag.ToString().Trim() != string.Empty)
                        MyFile.CopyFile(pictureBox1.Tag.ToString(), "StudentImage/" + id.ToString() + ".jpg");
                    student.ID = id;
                    student.Image = "StudentImage/" + id.ToString() + ".jpg";
                    studentBusiness.Update(student);
                }
                GetList();
                msgBox.Show("درج دانش آموز انجام شد", "درج دانش آموز",1);
                ClearText();
            }
        }

        private void btn_StudentEdit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                StudentBusiness studentBusiness = new StudentBusiness();
                if (txt_StudentNationalCode.Tag.ToString() == string.Empty)
                {
                    msgBox.Show("بر روی رکورد مورد نظر جهت ویرایش کلیک کنید.");
                    return;
                }
                Student student = FillData();
                student.ID = int.Parse(txt_StudentNationalCode.Tag.ToString());
                studentBusiness.Update(student);
                if (student.ID > 0)
                {
                    if (ChangePicture)
                    {
                        if (pictureBox1.Tag.ToString().Trim() != string.Empty)
                            MyFile.CopyFile(pictureBox1.Tag.ToString(), "StudentImage/" + student.ID.ToString() + ".jpg");
                    }
                }
                GetList();
                msgBox.Show("ویرایش دانش آموز انجام شد", "ویرایش دانش آموز", 1);
                ClearText();
            }
        }
        
        private void dgv_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Student.Rows.Count > 1)
            {
                txt_StudentNationalCode.Text = dgv_Student.CurrentRow.Cells["NationalCode"].Value.ToString();
                txt_StudentNationalCode.Tag = dgv_Student.CurrentRow.Cells["ID"].Value.ToString();
                txtStudentFirstName.Text = dgv_Student.CurrentRow.Cells["Name"].Value.ToString();
                txt_StudentLastName.Text = dgv_Student.CurrentRow.Cells["LastName"].Value.ToString();
                com_StudentDegreeID_FK.Text = dgv_Student.CurrentRow.Cells["DegreeID"].Value.ToString();
                com_StudentSex.Text = dgv_Student.CurrentRow.Cells["Sex"].Value.ToString();
                datePicker.Text = dgv_Student.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                txt_StudentAddress.Text = dgv_Student.CurrentRow.Cells["Address"].Value.ToString();
                baseTextBox2.Text = dgv_Student.CurrentRow.Cells["Phone"].Value.ToString();
                if (System.IO.File.Exists("StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg"))
                {
                    pictureBox1.Image = Image.FromFile("StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg");
                    pictureBox1.Tag = "StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg";
                }
                else
                    pictureBox1.Image = null;
            }
            else
                GetList();
        }

        private void btn_StudentDelete_Click(object sender, EventArgs e)
        {
            StudentBusiness studentBusiness = new StudentBusiness();
            if (txt_StudentNationalCode.Tag.ToString() == string.Empty)
            {
                msgBox.Show("بر روی رکورد مورد نظر جهت حذف کلیک کنید.");
                return;
            }
            if (msgBox.Show("آیا میخواهید رکورد حذف گردد؟", "هشدار", 2) == DialogResult.OK)
            {
                Student student = new Student();
                student.ID = int.Parse(txt_StudentNationalCode.Tag.ToString());
                studentBusiness.Delete(student);
                if (student.ID > 0)
                {
                    if (pictureBox1.Tag.ToString().Trim() != string.Empty)
                    {
                        pictureBox1.Image = null;
                        MyFile.DeleteFile("StudentImage/" + student.ID.ToString() + ".jpg");
                    }
                }
                GetList();
                msgBox.Show("حذف دانش آموز انجام شد", "حذف دانش آموز", 1);
                ClearText();
            }
        }

        private void btn_StudentOpenPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image|*.jpg;*.bmp;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    ChangePicture = true;
                }
                pictureBox1.Tag = openFileDialog.FileName;
            }
            catch (Exception ex)
            {
                msgBox.Show(ex.Message);
                throw;
            }
            
        }

        private void btn_StudentPicSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image|*.jpg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MyFile.CopyFile(pictureBox1.Tag.ToString(), saveFileDialog.FileName);
                    msgBox.Show("فایل مورد نظر کپی شد", "کپی فایل");
                }
            }
        }

        private void btn_StdSearchName_Click(object sender, EventArgs e)
        {
            if (txt_NameSearch.Text.Trim().Length >= 2)
            {
                StudentBusiness studentBusiness = new StudentBusiness();
                dgv_Student.DataSource = studentBusiness.DetailsByField("Name", txt_NameSearch.Text);
                SetSetting();
            }
            else
                msgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void btn_StdNationalcodeSearch_Click(object sender, EventArgs e)
        {
            if (txt_NationalSearch.Text.Trim().Length >= 2)
            {
                StudentBusiness studentBusiness = new StudentBusiness();
                dgv_Student.DataSource = studentBusiness.DetailsByField("NationalCode", txt_NationalSearch.Text);
                SetSetting();
            }
            else
                msgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void btn_stdFamilySearch_Click(object sender, EventArgs e)
        {
            if (txt_FamilySearch.Text.Trim().Length >= 2)
            {
                StudentBusiness studentBusiness = new StudentBusiness();
                dgv_Student.DataSource = studentBusiness.DetailsByField("LastName", txt_FamilySearch.Text);
                SetSetting();
            }
            else
                msgBox.Show("لطفا بیش از 2 کارکتر وارد نمایید");
        }

        private void btn_SearchMoreStudent_Click(object sender, EventArgs e)
        {
            Forms.SearchStudentForm searchStudentForm = new Forms.SearchStudentForm();
            searchStudentForm.StrFormName = "جستجوی دانش آموز";
            searchStudentForm.ShowDialog();
            //----------------------------------------------------------------------------------
            if (searchStudentForm.sendParameter > 0)
            {
                if (searchStudentForm.dgv_SearchStudent.Rows.Count > 1)
                {
                    txt_StudentNationalCode.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["NationalCode"].Value.ToString();
                    txt_StudentNationalCode.Tag = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["ID"].Value.ToString();
                    txtStudentFirstName.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Name"].Value.ToString();
                    txt_StudentLastName.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["LastName"].Value.ToString();
                    com_StudentDegreeID_FK.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["DegreeID"].Value.ToString();
                    com_StudentSex.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Sex"].Value.ToString();
                    datePicker.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["DateOfBirth"].Value.ToString();
                    txt_StudentAddress.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Address"].Value.ToString();
                    baseTextBox2.Text = searchStudentForm.dgv_SearchStudent.CurrentRow.Cells["Phone"].Value.ToString();
                    if (System.IO.File.Exists("StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg"))
                    {
                        pictureBox1.Image = Image.FromFile("StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg");
                        pictureBox1.Tag = "StudentImage/" + txt_StudentNationalCode.Tag.ToString() + ".jpg";
                    }
                    else
                        pictureBox1.Image = null;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentPrint_Click(object sender, EventArgs e)
        {
            winprint.PrintDGV.Print_DataGridView(FarsiGridView.reverse_DataGridView(dgv_Student));
        }
    }
}
