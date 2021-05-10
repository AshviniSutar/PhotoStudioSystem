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
    public partial class frmForgotPassword : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        DataTable dt;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
        }

        private void Clear()
        {
            txtusername.Text = "";
            cmbquestion.Text = "";
            txtanswer.Text = "";
        }

        private void btncheckedpass_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Login", cn);
                dr = cm.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                if (txtusername.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    if (cmbquestion.Text == dt.Rows[0].ItemArray[3].ToString())
                    {
                        if (txtanswer.Text == dt.Rows[0].ItemArray[4].ToString())
                        {
                            object v = MessageBox.Show("Password is '" + dt.Rows[0].ItemArray[2].ToString() + "'", "Correct Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (v.ToString() == "OK")
                            {
                                Clear();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Answer is incorrect....!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You select incorrect question....!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User name is incorrect....!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Please Fill Correct information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
