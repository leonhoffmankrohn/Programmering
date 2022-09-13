using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            lblSvar.Text = (int.Parse(tbxA.Text) * 2 + int.Parse(tbxB.Text) * 3 + int.Parse(tbxC.Text) * 4).ToString();
        }
    }
}
