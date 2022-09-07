using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            bool ab = int.Parse(tbxA.Text) < int.Parse(tbxB.Text);
            lblSvar.Text = "Talen är i ordningsföljd: " + (ab && int.Parse(tbxB.Text) < int.Parse(tbxC.Text)).ToString();
        }
    }
}
