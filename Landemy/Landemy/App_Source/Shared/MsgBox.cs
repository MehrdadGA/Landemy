using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landemy.App_Source.Shared
{
    class MsgBox
    {
        public void Show(string strMessage)
        {
            Forms.Frmmsg frmmsg = new Forms.Frmmsg();
            frmmsg.lbl_Msgbox.Text = strMessage;
            frmmsg.ShowDialog();
        }
        public DialogResult Show(string strMessage, string strTitle)
        {
            Forms.Frmmsg frmmsg = new Forms.Frmmsg();
            frmmsg.lbl_Msgbox.Text = strMessage;
            frmmsg.StrFormName = strTitle;
            return frmmsg.ShowDialog();
        }
        public DialogResult Show(string strMessage , string strTitle , int ButtonCount)
        {
            Forms.Frmmsg frmmsg = new Forms.Frmmsg();
            frmmsg.lbl_Msgbox.Text = strMessage;
            frmmsg.StrFormName = strTitle;
            frmmsg.buttonCount = ButtonCount;
            return frmmsg.ShowDialog();
        }
    }
}
