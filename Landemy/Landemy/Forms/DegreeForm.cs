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
    public partial class DegreeForm : Forms.MasterForm.frmMaster
    {
        private void GetDegreeList()
        {
            DegreeBusiness degreeBusiness = new DegreeBusiness();
            dgv_DegreeForm.DataSource = degreeBusiness.GetDegreeList();
        }

        private void SetSetting()
        {
            dgv_DegreeForm.Columns["Title"].HeaderText = "عنوان مدرک";
            dgv_DegreeForm.Columns["ID"].Visible = false;
        }

        public DegreeForm()
        {
            InitializeComponent();
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {
            GetDegreeList();
            SetSetting();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DegreeForm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_DegreeForm.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        public bool validateData()
        {
            bool Result = true;
            if (txt_DegreeTitle.Text.Trim() == string.Empty)
            {
                erp_DegreeForm.SetError(txt_DegreeTitle, "لطفا مقدار را وارد نمایید");
                Result = false;
            }
            return Result;
        }

        private void btn_DegreeInsert_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Degree degree = new Degree();
                degree.Title = txt_DegreeTitle.Text.Trim(); 
                DegreeBusiness degreeBusiness = new DegreeBusiness();

                if (degreeBusiness.InsertDegree(degree) != 0)
                { 
                    MessageBox.Show("مدرک جدید درست ثبت شد");
                    GetDegreeList();
                    ClearDegreeText();
                }
                else
                {
                    MessageBox.Show("مدرک جدید درست ثبت نشد");
                }
            }
        }

        private void ClearDegreeText()
        {
            txt_DegreeId.Text = string.Empty;
            txt_DegreeTitle.Text = string.Empty;
        }

        private void dgv_DegreeForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DegreeForm.Rows.Count > 1)
            {
                txt_DegreeId.Text = dgv_DegreeForm.CurrentRow.Cells["ID"].Value.ToString();
                txt_DegreeTitle.Text = dgv_DegreeForm.CurrentRow.Cells["Title"].Value.ToString();
            }
        }

        private void btn_DegreeEdit_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                if (txt_DegreeId.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("لطفا بر روی سطر مورد نظر کلیک کنید");
                    return;
                }
                Degree degree = new Degree();
                degree.ID = int.Parse(txt_DegreeId.Text);
                degree.Title = txt_DegreeTitle.Text.Trim();
                DegreeBusiness degreeBusiness = new DegreeBusiness();
                if (degreeBusiness.UpdateDegree(degree) != 0)
                {
                    MessageBox.Show("مدرک جدید درست ویرایش شد");
                    GetDegreeList();
                    ClearDegreeText();
                }
                else
                {
                    MessageBox.Show("مدرک جدید درست ویرایش نشد");
                }
            }
        }
    }
}
