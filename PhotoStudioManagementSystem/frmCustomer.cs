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
using System.Text.RegularExpressions;

namespace PhotoStudioManagementSystem
{
    public partial class frmCustomer : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            SeeRecord();
            SeeRecord1();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void Clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtadd.Text = "";
            txtmobile.Text = "";
            datetimecustdate.Text = "";
            cmbid.Show();
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Cust", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewcust.DataSource = dt;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbid.Hide();
            try
            {
                cm = new SqlCommand("select max(Cust_Id)from Cust", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                char[] c = txtmobile.Text.ToCharArray();
                if (txtname.Text == string.Empty || txtadd.Text == string.Empty || txtmobile.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (c.Length == 10)
                {
                    cm = new SqlCommand("insert into Cust Values(" + int.Parse(txtid.Text) + ",'" + txtname.Text + "','" + txtadd.Text + "'," + Int64.Parse(txtmobile.Text) + ",'" + datetimecustdate.Value.Date.ToLongDateString() + "')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbid.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect mobile number...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Cust_Id from Cust", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbid.Items.Add(dr["Cust_Id"].ToString());
                cmbid.ValueMember = dr["Cust_Id"].ToString(); ;
                cmbid.DisplayMember = dr["Cust_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Cust_Id from Cust", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Cust_Id"].ToString());
                cmbidsearch.ValueMember = dr["Cust_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Cust_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                char[] c = txtmobile.Text.ToCharArray();
                if (txtname.Text == string.Empty || txtadd.Text == string.Empty || txtmobile.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (c.Length == 10)
                {
                    cm = new SqlCommand("update Cust set Cust_Name='" + txtname.Text + "',Address='" + txtadd.Text + "',Mobile_No=" + Int64.Parse(txtmobile.Text) + ",Date='" + datetimecustdate.Value.Date.ToLongDateString() + "' where Cust_Id=" + int.Parse(cmbid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbid.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect mobile number...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error in updating Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from Cust where Cust_Id=(" + int.Parse(cmbid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbid.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error in deleting Record...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Cust where Cust_Id='" + cmbid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtname.Text = dr["Cust_Name"].ToString();
                    txtadd.Text = dr["Address"].ToString();
                    txtmobile.Text = dr["Mobile_No"].ToString();
                    datetimecustdate.Text = dr["Date"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void btnserachid_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select Cust_Id,Cust_Name,Address,Mobile_No from Cust where Cust_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                datagridviewcust.DataMember = "Cust";
                datagridviewcust.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (txtname.Text == string.Empty)
            {
                errorProvider1.SetError(txtname, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtname.Text))
                {
                    errorProvider1.SetError(txtname, "");
                }
                else
                {
                    errorProvider1.SetError(txtname, "Please enter character");
                }
            }
        }

        private void txtadd_Validating(object sender, CancelEventArgs e)
        {
            if (txtadd.Text == string.Empty)
            {
                errorProvider1.SetError(txtadd, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtadd.Text))
                {
                    errorProvider1.SetError(txtadd, "");
                }
                else
                {
                    errorProvider1.SetError(txtadd, "Please enter character");
                }
            }
        }

        private void txtmobile_Validating(object sender, CancelEventArgs e)
        {
            if (txtmobile.Text == string.Empty)
            {
                errorProvider1.SetError(txtmobile, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtmobile.Text) && txtmobile.Text.Length == 10)
                {
                    errorProvider1.SetError(txtmobile, "");
                }
                else
                {
                    errorProvider1.SetError(txtmobile, "Please enter 10 digit number");
                }
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewcust.DataSource = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xpos == 0)
            {
                this.label1.Location = new System.Drawing.Point(this.Width, ypos);
                xpos = this.Width;
            }
            else
            {
                this.label1.Location = new System.Drawing.Point(xpos, ypos);
                xpos -= 2;
            }
        }
    }
}
