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
    public partial class frmSupplier : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
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

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Supplier", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewsupplier.DataSource = dt;
        }

        private void Clear()
        {
            cmbid.Show();
            txtid.Text = "";
            txtname.Text = "";
            txtadd.Text = "";
            txtpin.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Supplier_Id from Supplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbid.Items.Add(dr["Supplier_Id"].ToString());
                cmbid.ValueMember = dr["Supplier_Id"].ToString(); ;
                cmbid.DisplayMember = dr["Supplier_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Supplier_Id from Supplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Supplier_Id"].ToString());
                cmbidsearch.ValueMember = dr["Supplier_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Supplier_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            cmbid.Hide();
            try
            {
                cm = new SqlCommand("select max(Supplier_Id)from Supplier", cn);
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
                string s = txtemail.Text.ToString();
                int d = txtemail.Text.LastIndexOf(".");
                int a = txtemail.Text.IndexOf("@");
                char[] c = txtmobile.Text.ToCharArray();
                char[] p = txtpin.Text.ToCharArray();
                if (txtname.Text == string.Empty || txtadd.Text == string.Empty || (txtpin.Text == string.Empty) || txtemail.Text == string.Empty || txtmobile.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (s.Contains("@") && s.Contains(".") && (d > a))
                {
                    if (c.Length == 10 && p.Length == 6)
                    {
                        cm = new SqlCommand("insert into Supplier Values(" + int.Parse(txtid.Text) + ",'" + txtname.Text + "','" + txtadd.Text + "'," + int.Parse(txtpin.Text) + "," + Int64.Parse(txtmobile.Text) + ",'" + txtemail.Text + "')", cn);
                        int z = cm.ExecuteNonQuery();
                        if (z == 1)
                        {
                            MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            showData();
                            cmbid.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect mobile number or Pin number...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email address...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Supplier where Supplier_Id='" + cmbid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtname.Text = dr["Supplier_Name"].ToString();
                    txtadd.Text = dr["Address"].ToString();
                    txtpin.Text = dr["PinCode"].ToString();
                    txtmobile.Text = dr["Mobile_No"].ToString();
                    txtemail.Text = dr["Email_Id"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string s = txtemail.Text.ToString();
                int d = txtemail.Text.LastIndexOf(".");
                int a = txtemail.Text.IndexOf("@");
                char[] c = txtmobile.Text.ToCharArray();
                char[] p = txtpin.Text.ToCharArray();
                if (txtname.Text==string.Empty || txtadd.Text==string.Empty || (txtpin.Text==string.Empty) || txtemail.Text==string.Empty || txtmobile.Text==string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (s.Contains("@") && s.Contains(".") && (d > a))
                {
                    if (c.Length == 10 && p.Length == 6)
                    {
                        cm = new SqlCommand("update Supplier set Supplier_Name='" + txtname.Text.ToString() + "',Address='" + txtadd.Text + "',PinCode=" + int.Parse(txtpin.Text) + ",Mobile_No=" + Int64.Parse(txtmobile.Text) + ",Email_Id='" + txtemail.Text + "' where Supplier_Id=(" + cmbid.Text + ")", cn);
                        int z = cm.ExecuteNonQuery();
                        if (z == 1)
                        {
                            MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showData();
                            Clear();
                            cmbid.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect mobile number or Pin number...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email address...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error in updating Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from Supplier where Supplier_Id=(" + int.Parse(cmbid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbid.Show();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error in deleting Record...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Supplier where Supplier_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Supplier");
                datagridviewsupplier.DataMember = "Supplier";
                datagridviewsupplier.DataSource = ds;
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

        private void txtpin_Validating(object sender, CancelEventArgs e)
        {
            if (txtpin.Text == string.Empty)
            {
                errorProvider1.SetError(txtpin, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtpin.Text) && txtpin.Text.Length == 6)
                {
                    errorProvider1.SetError(txtpin, "");
                }
                else
                {
                    errorProvider1.SetError(txtpin, "Please enter 6 digit number");
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

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            string s = txtemail.Text.ToString();
            int d = txtemail.Text.LastIndexOf(".");
            int a = txtemail.Text.IndexOf("@");
            if (txtemail.Text == string.Empty)
            {
                errorProvider1.SetError(txtemail, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtemail.Text) && s.Contains("@") && s.Contains(".") && (d > a))
                {
                    errorProvider1.SetError(txtemail, "");
                }
                else
                {
                    errorProvider1.SetError(txtemail, "Please enter email");
                }
            }
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

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewsupplier.DataSource = null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
