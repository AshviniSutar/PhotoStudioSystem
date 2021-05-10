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
    public partial class frmBooking : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        string pay;
        int xpos = 0, ypos = 0;
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            SeeRecord();
            SeeRecord1();
            SeeRecord2();
            SeeRecord3();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void Clear()
        {
            cmbbookid.Show();
            cmbcatid.Show();
            cmbcustid.Show();
            txtbookid.Text = "";
            cmbcatid.Text = "";
            txtcatname.Text = "";
            cmbcustid.Text = "";
            txtcustname.Text = "";
            datetimebookdate.Text = "";
            txtvisitplace.Text = "";
            datetimevisitdate.Text = "";
            txtadvance.Text = "";
            txtcustid.Text = "";
            txtcatid.Text = "";
            rdbcash.Checked = false;
            rdbcheque.Checked = false;
            txtbankname.Text = "";
            txtbranch.Text = "";
            txtchequeno.Text = "";
            txtaccountno.Text = "";
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Category_Id from Category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbcatid.Items.Add(dr["Category_Id"].ToString());
                cmbcatid.ValueMember = dr["Category_Id"].ToString(); ;
                cmbcatid.DisplayMember = dr["Category_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Cust_Id from Cust", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbcustid.Items.Add(dr["Cust_Id"].ToString());
                cmbcustid.ValueMember = dr["Cust_Id"].ToString(); ;
                cmbcustid.DisplayMember = dr["Cust_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Book_Id from Booking", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbbookid.Items.Add(dr["Book_Id"].ToString());
                cmbbookid.ValueMember = dr["Book_Id"].ToString(); ;
                cmbbookid.DisplayMember = dr["Book_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord3()
        {
            cm = new SqlCommand("select Book_Id from Booking", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Book_Id"].ToString());
                cmbidsearch.ValueMember = dr["Book_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Book_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Booking", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewbook.DataSource = dt;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbcatid.Show();
            cmbcustid.Show();
            cmbbookid.Hide();
            try
            {
                cm = new SqlCommand("select max(Book_Id)from Booking", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtbookid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtbookid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtadvance.Text == string.Empty || txtvisitplace.Text == string.Empty || rdbcash.Checked == false && rdbcheque.Checked == false)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("insert into Booking values(" + int.Parse(txtbookid.Text) + ",'" + cmbcatid.Text + "','" + txtcatname.Text + "','" + cmbcustid.Text + "','" + txtcustname.Text + "','" + datetimebookdate.Value.Date.ToLongDateString() + "','" + txtvisitplace.Text + "','" + datetimevisitdate.Value.Date.ToLongDateString() + "'," + int.Parse(txtadvance.Text) + ",'" + this.pay + "','" + txtbankname.Text + "'," + int.Parse(txtchequeno.Text) + "," + int.Parse(txtaccountno.Text) + ",'" + txtbranch.Text + "')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbookid.Show();
                    }
                }
                else
                {

                    txtbankname.Text = "";
                    txtbranch.Text = "";
                    txtchequeno.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("insert into Booking values(" + int.Parse(txtbookid.Text) + ",'" + cmbcatid.Text + "','" + txtcatname.Text + "','" + cmbcustid.Text + "','" + txtcustname.Text + "','" + datetimebookdate.Value.Date.ToLongDateString() + "','" + txtvisitplace.Text + "','" + datetimevisitdate.Value.Date.ToLongDateString() + "'," + int.Parse(txtadvance.Text) + ",'" + this.pay + "','','','','')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbookid.Show();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtadvance.Text == string.Empty || txtvisitplace.Text == string.Empty || rdbcash.Checked == false && rdbcheque.Checked == false)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("update Booking set Book_Id=" + int.Parse(cmbbookid.Text) + ",Category_Id='" + txtcatid.Text + "',Category_Name='" + txtcatname.Text + "',Cust_Id='" + txtcustid.Text + "',Cust_Name='" + txtcustname.Text + "',Book_Date='" + datetimebookdate.Value.Date.ToLongDateString() + "',Visit_Place='" + txtvisitplace.Text + "',Visit_Date='" + datetimevisitdate.Value.Date.ToLongDateString() + "',Advance=" + int.Parse(txtadvance.Text) + ",Paid_By='" + this.pay + "',Bank_Name='" + txtbankname.Text + "',Cheque_No='" + txtchequeno.Text + "',Branch='" + txtbranch.Text + "',Account_No='" + txtaccountno.Text + "' where Book_Id=" + int.Parse(cmbbookid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbookid.Show();
                    }
                }
                else
                {

                    txtbankname.Text = "";
                    txtbranch.Text = "";
                    txtchequeno.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("update Booking set Book_Id=" + int.Parse(cmbbookid.Text) + ",Category_Id='" + txtcatid.Text + "',Category_Name='" + txtcatname.Text + "',Cust_Id='" + txtcustid.Text + "',Cust_Name='" + txtcustname.Text + "',Book_Date='" + datetimebookdate.Value.Date.ToLongDateString() + "',Visit_Place='" + txtvisitplace.Text + "',Visit_Date='" + datetimevisitdate.Value.Date.ToLongDateString() + "',Advance=" + int.Parse(txtadvance.Text) + ",Paid_By='" + this.pay + "',Bank_Name='',Branch='',Account_No='',Cheque_No='' where Book_Id=" + int.Parse(cmbbookid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbookid.Show();
                    }
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
                cm = new SqlCommand("Delete from Booking where Book_Id=(" + int.Parse(cmbbookid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbbookid.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error in deleting Record...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
        }

        private void cmbbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcatid.Hide();
            cmbcustid.Hide();
            cm = new SqlCommand("select * from Booking where Book_Id='" + cmbbookid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcatid.Text = dr["Category_Id"].ToString();
                txtcatname.Text = dr["Category_Name"].ToString();
                txtcustid.Text = dr["Cust_Id"].ToString();
                txtcustname.Text = dr["Cust_Name"].ToString();
                datetimebookdate.Text = dr["Book_Date"].ToString();
                txtvisitplace.Text = dr["Visit_Place"].ToString();
                datetimevisitdate.Text = dr["Visit_Date"].ToString();
                txtadvance.Text = dr["Advance"].ToString();
                if (dr["Paid_By"].ToString() == "cheque")
                {
                    rdbcheque.Checked = true;
                }
                else
                {
                    rdbcash.Checked = true;
                }
                txtbankname.Text = dr["Bank_Name"].ToString();
                txtbranch.Text = dr["Branch"].ToString();
                txtchequeno.Text = dr["Cheque_No"].ToString();
                txtaccountno.Text = dr["Account_No"].ToString();
            }
            dr.Close();
        }

        private void cmbcatid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Category_Name from Category where Category_Id='" + cmbcatid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcatname.Text = dr["Category_Name"].ToString();
            }
            dr.Close();
        }

        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select * from Cust where Cust_Id='" + cmbcustid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcustname.Text = dr["Cust_Name"].ToString();
            }
            dr.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Booking where Book_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Booking");
                datagridviewbook.DataMember = "Booking";
                datagridviewbook.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewbook.DataSource = null;
        }

        private void rdbcheque_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            pay = "cheque";
        }

        private void rdbcash_CheckedChanged(object sender, EventArgs e)
        {
            pay = "cash";
            txtbankname.Text = "";
            txtbranch.Text = "";
            txtchequeno.Text = "";
            txtaccountno.Text = "";
            panel1.Hide();
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

        private void btncancle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtvisitplace_Validating(object sender, CancelEventArgs e)
        {
            if (txtvisitplace.Text == string.Empty)
            {
                errorProvider1.SetError(txtvisitplace, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtvisitplace.Text))
                {
                    errorProvider1.SetError(txtvisitplace, "");
                }
                else
                {
                    errorProvider1.SetError(txtvisitplace, "Please enter character");
                }
            }
        }

        private void txtadvance_Validating(object sender, CancelEventArgs e)
        {
            if (txtadvance.Text == string.Empty)
            {
                errorProvider1.SetError(txtadvance, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtadvance.Text))
                {
                    errorProvider1.SetError(txtadvance, "");
                }
                else
                {
                    errorProvider1.SetError(txtadvance, "Please enter 10 digit number");
                }
            }
        }
    }
}
