using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControl
{
    public partial class MyToolbar : UserControl
    {
        public delegate void Btn_Click();

        public event Btn_Click Btn_OK;
        public event Btn_Click Btn_Cancel;
        public event Btn_Click Btn_New;
        public event Btn_Click Btn_Edit;
        public event Btn_Click Btn_Delete;

        public Boolean ActionMode_NeworUpdate;
        public int ActiveRecord;

        public MyToolbar()
        {
            InitializeComponent();
        }

        private void MyToolbar_Load(object sender, EventArgs e)
        {
            SetActionMode(true);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SetActionMode(false);
            Btn_New();
        }

        public void SetActionMode(bool State)
        {
            pnl_Action.Visible = !State;
            pnl_Button.Visible = State;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SetActionMode(false);
            Btn_Edit();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Btn_Delete();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Btn_OK();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SetActionMode(true);
            Btn_Cancel();
        }
    }
}
