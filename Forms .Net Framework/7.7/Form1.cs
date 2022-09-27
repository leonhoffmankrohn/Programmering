using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxTal1.Text);
            double tal2 = double.Parse(tbxTal2.Text);
            lblResultat.Text = "Det minsta talet är " + (tal1 < tal2 ? tal1 : tal2).ToString();
        }
    }
}
