using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int sekunder = int.Parse(tbxTotSekunder.Text);
            int timmar = sekunder / 3600;
            sekunder %= 3600;
            int minuter = sekunder / 60;
            sekunder %= 60;

            lblSvar.Text = "Timmar: " + timmar.ToString() + " Minuter: " + minuter.ToString() + " Sekunder: " + sekunder.ToString();

        }
    }
}
