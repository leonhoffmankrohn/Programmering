using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string antalÅr = (int.Parse(tbxTid.Text) / 12).ToString();
            string antalMånader = (int.Parse(tbxTid.Text)%12).ToString();
            lblSvar.Text = antalÅr + " år och " + antalMånader + " månader";
        }
    }
}
