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
    public partial class frmNewUser : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        DataTable dt;
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
        }

        private void Clear()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconformpassword.Text = "";
            cmbquestion.Text = "";
            txtanswer.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text != "" || txtpassword.Text != "" || txtconformpassword.Text != "" || cmbquestion.Text != "" || txtanswer.Text != "")
                {
                    if (txtpassword.Text == txtconformpassword.Text)
                    {
                        cm = new SqlCommand("update Login set user_name='" + txtusername.Text + "',Password='" + txtpassword.Text + "',Question='" + cmbquestion.Text + "',Answer='" + txtanswer.Text + "'", cn);
                        cm.ExecuteNonQuery();

                        object v = MessageBox.Show("User Updated Successfully.....!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (v.ToString() == "OK")
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        object v = MessageBox.Show("Conformed password incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (v.ToString() == "RETRY")
                        {
                            txtconformpassword.Text = "";
                            txtpassword.Text = "";
                        }
                    }
                }
                else
                {
                    object v = MessageBox.Show("please fill all the records", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (v.ToString() == "CANCEL")
                    {
                        Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error in updating Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
