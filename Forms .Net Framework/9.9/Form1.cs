using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFörskjut_Click(object sender, EventArgs e)
        {
            string[] number = new string[3];
            number[0] = tbx3.Text;
            number[1] = tbx1.Text;
            number[2] = tbx2.Text;

            tbx1.Text = number[0];
            tbx2.Text = number[1];
            tbx3.Text = number[2];
        }
    }
}
