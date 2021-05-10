using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhotoStudioManagementSystem
{
    public partial class frmLogin : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cm;
        DataTable dt;
        int n;
        static int attempt = 2;
        public static string pass;
        public frmLogin()
        {
            InitializeComponent();
            frmSplashScreen screen = new frmSplashScreen();
            screen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Clear()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Login", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            n = dt.Rows.Count - 1;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            showData();
            if (attempt == 0)
            {
                MessageBox.Show("Invalid UserName and Password.....!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            if (txtusername.Text.Equals(dt.Rows[0].ItemArray[0].ToString()) && txtpassword.Text.Equals(dt.Rows[0].ItemArray[1].ToString()))
            {
                pass = txtusername.Text.ToString();
                MessageBox.Show("Login Successfull.....!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMDI ff = new frmMDI();
                ff.ShowDialog();

            }
            else
            {
                MessageBox.Show("You have to login only in   " + Convert.ToString(attempt) + "  Attempts...!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                --attempt;
                Clear();
            }
        }

        private void btnforgotpassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword forgot = new frmForgotPassword();
            forgot.ShowDialog();
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else if (chkshowpassword.Checked == false)
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
