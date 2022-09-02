using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kalkylator
{
    public partial class Form1 : Form
    {
        char[] calc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calc[0] != null) {
                calc.Append('0');
                Debug.Print(calc[0].ToString() + calc[1].ToString());
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calc.Append('1');
            Debug.Print(calc[0].ToString());
        }
    }
}
