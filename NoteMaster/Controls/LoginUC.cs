﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMaster.Controls
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gösterBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (gösterBtn.Checked)
                passwordTxt.PasswordChar = '\0';
            else
                passwordTxt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
