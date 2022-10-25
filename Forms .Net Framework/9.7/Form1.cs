using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int nivå = int.Parse(tbxNivå.Text);
            for (int i = 1; i < nivå+1; i++)
            {
                for (int j = 1; j < 11; j++) 
                {
                    tbxUtdata.AppendText(i*j+"\r\t");
                }
                tbxUtdata.AppendText("\r\n");
            }
        }
    }
}
