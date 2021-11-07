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
    public partial class Frmmsg : Forms.MasterForm.frmMaster
    {
        public int buttonCount = 1;
        public Frmmsg()
        {
            InitializeComponent();
        }

        private void Frmmsg_Load(object sender, EventArgs e)
        {
            if (buttonCount == 1)
            {
                btn_msgCancle.Visible = false;
            }
        }

        private void btn_Msgbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
