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
    public partial class frmChangePassword : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        DataTable dt;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            showData();
        }

        public void showData()
        {
            cm = new SqlCommand("select * from login", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
        }

        private void Clear()
        {
            txtusername.Text = "";
            txtnewpassword.Text = "";
            txtoldpassword.Text = "";
            txtconfirmpassword.Text = "";
        }

        private void btnconfirmpass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnewpassword.Text == txtconfirmpassword.Text)
                {

                    if (dt.Rows[0].ItemArray[0].ToString().Equals(txtusername.Text.ToString()))
                    {
                        if (dt.Rows[0].ItemArray[1].ToString().Equals(txtoldpassword.Text.ToString()))
                        {
                            cm = new SqlCommand("update Login set Password ='" + txtnewpassword.Text.ToString() + "'", cn);
                            int dr = cm.ExecuteNonQuery();
                            if (dr == 1)
                            {
                                object v = MessageBox.Show("password change successfully new password is '" + txtnewpassword.Text + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (v.ToString() == "OK")
                                {
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("incorrect password....!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("incorrect user name....!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("New password & confirm password must equal....!" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Error in changing password...!", "Record Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
