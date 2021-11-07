﻿using System;
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
    public partial class BaseComboBox : UserControl
    {
        public BaseComboBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public ComboBox.ObjectCollection Items
        {
            get
            {
                return comboBox1.Items;
            }
        }
        public DataTable DataSource
        {
            get { return comboBox1.DataSource as DataTable; }
            set { comboBox1.DataSource = value; }
        }
        public string ValueMember
        {
            get { return comboBox1.ValueMember; }
            set { comboBox1.ValueMember = value; }
        }

        public string DisplayMember
        {
            get { return comboBox1.DisplayMember;}
            set { comboBox1.DisplayMember = value; }
        }

        public object SelectedValue
        {
            get { return comboBox1.SelectedValue; }
            set { comboBox1.SelectedValue = value; }
        }

        public int SelectedIndex
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_Resize(object sender, EventArgs e)
        {
            this.Width = comboBox1.Width;
            this.Height = comboBox1.Height;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.LightGreen;
        }
    }
}
