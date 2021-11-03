using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy
{
    public partial class Form1 : Forms.MasterForm.frmMaster
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void btn_masterShow_Click(object sender, EventArgs e)
        {
            Forms.DegreeForm degreeForm = new Forms.DegreeForm();
            degreeForm.StrFormName = "فرم مدارک";
            degreeForm.ShowDialog();
        }
    }
}
