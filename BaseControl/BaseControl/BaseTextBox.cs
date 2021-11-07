using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseControl
{
    public partial class BaseTextBox : UserControl
    {
        public BaseTextBox()
        {
            InitializeComponent();
        }

        private bool _isNumber;
        private bool _isReal;
        public bool IsNumber
        {
            get { return _isNumber; }
            set { _isNumber = value; }
        }
        public bool IsReal
        {
            get { return _isReal; }
            set { _isReal = value; }
        }

        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public new string Tag
        {
            get { return textBox1.Tag.ToString(); }
            set { textBox1.Tag = value; }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNumber)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            if (IsNumber)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
