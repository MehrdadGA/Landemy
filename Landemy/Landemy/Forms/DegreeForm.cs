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
        Forms.Frmmsg frmmsg = new Frmmsg();
        App_Source.Shared.MsgBox MsgBox = new App_Source.Shared.MsgBox();
        private void GetDegreeList()
        {
            DegreeBusiness degreeBusiness = new DegreeBusiness();
            dgv_Degree.DataSource = degreeBusiness.GetDegreeList();
        }
        private void SetDegreeSetting()
        {
            dgv_Degree.Columns["Title"].HeaderText = "عنوان مدرک";
            dgv_Degree.Columns["ID"].Visible = false;
        }
        public DegreeForm()
        {
            InitializeComponent();
        }

        private void DegreeForm_Load(object sender, EventArgs e)
        {
            GetDegreeList();
            SetDegreeSetting();
        }
        private void ClearDegreeText()
        {
            txt_Degreetitle.Text = string.Empty;
        }

        private void btn_DegreeInsert_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Degree degree = new Degree();
                degree.Title = txt_Degreetitle.Text.Trim();
                DegreeBusiness degreeBusiness = new DegreeBusiness();

                if (degreeBusiness.InsertDegree(degree) != 0)
                {
                    MsgBox.Show("مدرک جدید درست ثبت شد", "اتمام", 1);
                    GetDegreeList();
                    ClearDegreeText();
                }
                else
                {
                    MsgBox.Show("مدرک جدید درست ثبت نشد", "", 1);
                }
            }
        }

        private void dgv_Degree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Degree.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }
        public bool validateData()
        {
            bool Result = true;
            if (txt_Degreetitle.Text.Trim() == string.Empty)
            {
                erp_Degree.SetError(txt_Degreetitle, "لطفا مقدار را وارد نمایید");
                Result = false;
            }
            return Result;
        }

        private void btn_DegreeEdit_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    MsgBox.Show("لطفا بر روی سطر مورد نظر کلیک کنید", "", 1);
                    return;
                }
                Degree degree = new Degree();
                degree.ID = int.Parse(textBox1.Text);
                degree.Title = txt_Degreetitle.Text.Trim();
                DegreeBusiness degreeBusiness = new DegreeBusiness();
                if (degreeBusiness.UpdateDegree(degree) != 0)
                {
                    MsgBox.Show("مدرک جدید درست ویرایش شد", "", 1);
                    GetDegreeList();
                    ClearDegreeText();
                }
                else
                {
                    MsgBox.Show("مدرک جدید درست ویرایش نشد");
                }
            }
        }

        private void btn_DegreeDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MsgBox.Show("بر روی سطر مورد نظر کلیک کنید", "", 1);
                return;
            }
            if (MsgBox.Show("آیا میخواهی این رکورد حذف شود", "هشدار", 2) == DialogResult.OK)
            {
                Degree degree = new Degree();
                degree.ID = int.Parse(textBox1.Text);
                DegreeBusiness degreeBusiness = new DegreeBusiness();
                degreeBusiness.Delete(degree);
                GetDegreeList();
                ClearDegreeText();
                MsgBox.Show("رکورد مورد نظر حذف شد", "", 1);
            }
        }

        private void dgv_Degree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Degree.Rows.Count > 1)
            {
                textBox1.Text = dgv_Degree.CurrentRow.Cells["ID"].Value.ToString();
                txt_Degreetitle.Text = dgv_Degree.CurrentRow.Cells["Title"].Value.ToString();
            }
        }
    }
}
