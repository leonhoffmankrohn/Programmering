﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string initals = tbxFörnamn.Text[0].ToString() + "." + tbxEfternamn.Text[0].ToString();
            lblSvar.Text = tbxFörnamn.Text + " " + tbxEfternamn.Text + " har initialerna " + initals + ".";
        }
    }
}
