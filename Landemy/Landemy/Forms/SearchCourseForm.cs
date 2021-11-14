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
    public partial class SearchCourseForm : Forms.MasterForm.frmMaster
    {
        public int SendParameters = -1;
        public SearchCourseForm()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            dgv_SearchCourse.DataSource = new CourseBusiness().GetList();

            SetSetting();
        }
        public void SetSetting()
        {
            dgv_SearchCourse.Columns["ID"].Visible = false;

            dgv_SearchCourse.Columns["Title"].HeaderText = "نام درس";
            dgv_SearchCourse.Columns["LevelCount"].HeaderText = "تعداد سطح";
            dgv_SearchCourse.Columns["Tuition"].HeaderText = "شهریه";
        }

        private void SearchCourseForm_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void dgv_SearchCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_SearchCourse.Rows[e.RowIndex].Cells["ColumnRowNumber"].Value = e.RowIndex + 1;
        }

        private void dgv_SearchCourse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_SearchCourse.Rows.Count > 1)
            {
                if (dgv_SearchCourse.CurrentRow.Cells["ID"].Value == null)
                    return;
                if (dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString() == string.Empty)
                    return;
                SendParameters = int.Parse(dgv_SearchCourse.CurrentRow.Cells["ID"].Value.ToString());
                this.Close();
            }
        }

        private void btn_SearchCourseName_Click(object sender, EventArgs e)
        {
            CourseBusiness courseBusiness = new CourseBusiness();
            dgv_SearchCourse.DataSource = courseBusiness.DetailsByField("title", txt_SearchCourseName.Text);
            SetSetting();
        }
    }
}
