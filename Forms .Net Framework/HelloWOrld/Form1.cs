using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWOrld
{
    public partial class Form1 : Form
    {
        bool x = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if(BackColor == Color.Red) {
                BackColor = Color.Pink;
            }else{
                BackColor = Color.Red;
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.Green;
            btnGreen.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.White;
            BackColor = Color.White;
            btnGreen.Enabled = true;
            obj.Location = new Point(100, 100);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // obj.Location = new Point(obj.Location.X + 10, 100);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void btnRun_MouseDown(object sender, MouseEventArgs e)
        {
            x = true;
            Timer timer = new Timer();
            while (x) {

                obj.Location = new Point(obj.Location.X + 1, 100);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnRun_MouseUp(object sender, MouseEventArgs e)
        {
            x = false;
            MessageBox.Show("Up");
        }
    }
}
