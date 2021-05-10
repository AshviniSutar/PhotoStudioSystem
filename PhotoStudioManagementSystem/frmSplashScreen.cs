using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudioManagementSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblstudio.ForeColor == Color.DarkMagenta)
            {
                lblstudio.ForeColor = Color.Maroon;
            }
            else if (lblstudio.ForeColor == Color.Maroon)
            {
                lblstudio.ForeColor = Color.BlueViolet;
            }
            else if (lblstudio.ForeColor == Color.BlueViolet)
            {
                lblstudio.ForeColor = Color.Yellow;
            }
            else if (lblstudio.ForeColor == Color.Yellow)
            {
                lblstudio.ForeColor = Color.DarkSlateBlue;
            }
            else if (lblstudio.ForeColor == Color.DarkSlateBlue)
            {
                lblstudio.ForeColor = Color.Brown;
            }
            else if (lblstudio.ForeColor == Color.Brown)
            {
                lblstudio.ForeColor = Color.YellowGreen;
            }
            else if (lblstudio.ForeColor == Color.YellowGreen)
            {
                lblstudio.ForeColor = Color.DarkMagenta;
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == 10)
            {
                lblsplashtext.Text = "Loading Project......";
            }
            if (progressBar1.Value == 20)
            {
                lblsplashtext.Text = "Please Wait..........";
            }
            if (progressBar1.Value == 30)
            {
                lblsplashtext.Text = "Initialising components........";
            }
            if (progressBar1.Value == 40)
            {
                lblsplashtext.Text = "Connecting Database..........";
            }
            if (progressBar1.Value == 60)
            {
                lblsplashtext.Text = "Loading Forms.............";
            }
            if (progressBar1.Value == 70)
            {
                lblsplashtext.Text = "Almost Done......";
            }
            if (progressBar1.Value == 80)
            {
                lblsplashtext.Text = "Done.....!";

            }
            if (progressBar1.Value == 100)
            {
                this.Close();
            }
        }
    }
}
