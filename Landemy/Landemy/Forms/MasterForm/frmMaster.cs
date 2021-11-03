using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy.Forms.MasterForm
{
    public partial class frmMaster : Form
    {
        public string StrFormName = "فرم اصلی";
        public frmMaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            lbl_FormName.Text = StrFormName;
            ptb_CloseIcon.Left = pnl_MasterForm.Width - ptb_CloseIcon.Width;
            lbl_FormName.Left = pnl_MasterForm.Width / 2 - lbl_FormName.Width / 2;
        }
    }
}
