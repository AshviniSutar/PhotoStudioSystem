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
    public partial class frmEmppayment : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        string pay;
        int xpos = 0, ypos = 0;
        public frmEmppayment()
        {
            InitializeComponent();
        }

        private void frmEmppayment_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            SeeRecord();
            SeeRecord1();
            SeeRecord2();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from EmpPayment", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewpayment.DataSource = dt;
        }

        private void Clear()
        {
            cmbempid.Show();
            cmbpaymentid.Show();
            cmbpaymentid.Text = "";
            txtpaymentid.Text = "";
            cmbempid.Text = "";
            txtempid.Text = "";
            txtempname.Text = "";
            datetimejoindate.Text = "";
            datetimetodaysdate.Text = "";
            txtyearswork.Text = "";
            txtbasicsalary.Text = "";
            rdbcash.Checked = false;
            rdbcheque.Checked = false;
            txtpaymentamount.Text = "";
            txtchequeno.Text = "";
            txtaccountno.Text = "";
            txtbankname.Text = "";
            txtbranch.Text = "";
            datetimepaymentdate.Text = "";
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Emp_Id from Emp", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbempid.Items.Add(dr["Emp_Id"].ToString());
                cmbempid.ValueMember = dr["Emp_Id"].ToString(); ;
                cmbempid.DisplayMember = dr["Emp_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Payment_Id from EmpPayment", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Payment_Id"].ToString());
                cmbidsearch.ValueMember = dr["Payment_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Payment_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Payment_Id from EmpPayment", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbpaymentid.Items.Add(dr["Payment_Id"].ToString());
                cmbpaymentid.ValueMember = dr["Payment_Id"].ToString(); ;
                cmbpaymentid.DisplayMember = dr["Payment_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select Name,Basic_Salary,Date_Of_Join from Emp where Emp_Id='" + cmbempid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtempname.Text = dr["Name"].ToString();
                    txtbasicsalary.Text = dr["Basic_Salary"].ToString();
                    datetimejoindate.Text = dr["Date_Of_Join"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void rdbcash_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            pay = "Cash";
        }

        private void rdbcheque_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            pay = "Cheque";
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            DateTime d1 = datetimejoindate.Value;
            DateTime d2 = datetimetodaysdate.Value;
            txtyearswork.Text = (((d2 - d1).Days) / 365).ToString();
            if (txtyearswork.Text.Equals(5))
            {
                int a = int.Parse(txtbasicsalary.Text) * 2;
                txtpaymentamount.Text = a.ToString();
            }
            else if (int.Parse(txtyearswork.Text) >= 10)
            {
                int a = int.Parse(txtbasicsalary.Text) * 3;
                txtpaymentamount.Text = a.ToString();
            }
            else
            {
                int b = int.Parse(txtbasicsalary.Text);
                txtpaymentamount.Text = b.ToString();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbempid.Show();
            txtpaymentid.Enabled = false;
            cmbpaymentid.Hide();
            try
            {
                cm = new SqlCommand("select max(Payment_Id)from EmpPayment", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtpaymentid.Text = z.ToString();
                }
                dr.Close();

            }
            catch
            {
                txtpaymentid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbcash.Checked == true)
                {
                    cm = new SqlCommand("insert into EmpPayment values('" + txtpaymentid.Text + "','" + cmbempid.Text + "','" + txtempname.Text + "','" + datetimejoindate.Value.Date.ToLongDateString() + "','" + datetimetodaysdate.Value.Date.ToLongDateString() + "','" + int.Parse(txtyearswork.Text) + "'," + int.Parse(txtbasicsalary.Text) + "," + int.Parse(txtpaymentamount.Text) + ",'" + datetimepaymentdate.Value.Date.ToLongDateString() + "','" + this.pay + "','','','','')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbpaymentid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("insert into EmpPayment values('" + txtpaymentid.Text + "','" + cmbempid.Text + "','" + txtempname.Text + "','" + datetimejoindate.Value.Date.ToLongDateString() + "','" + datetimetodaysdate.Value.Date.ToLongDateString() + "','" + int.Parse(txtyearswork.Text) + "'," + int.Parse(txtbasicsalary.Text) + "," + int.Parse(txtpaymentamount.Text) + ",'" + datetimepaymentdate.Value.Date.ToLongDateString() + "','" + this.pay + "'," + int.Parse(txtchequeno.Text) + ",'" + txtbankname.Text + "'," + int.Parse(txtaccountno.Text) + ",'" + txtbranch.Text + "')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbpaymentid.Show();
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
                if (rdbcash.Checked == true)
                {
                    txtbankname.Text = "";
                    txtbranch.Text = "";
                    txtchequeno.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("update EmpPayment set Paid_By='" + this.pay + "',Bank_Name='',Branch='',Account_No='',Cheque_No='' where Payment_Id=" + int.Parse(cmbpaymentid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbpaymentid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("update EmpPayment set Paid_By='" + this.pay + "',Bank_Name='" + txtbankname.Text + "',Cheque_No='" + txtchequeno.Text + "',Branch='" + txtbranch.Text + "',Account_No='" + txtaccountno.Text + "' where Payment_Id=" + int.Parse(cmbpaymentid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbpaymentid.Show();
                    }
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
                cm = new SqlCommand("Delete from EmpPayment where Payment_Id=(" + int.Parse(cmbpaymentid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbpaymentid.Show();
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
                cm = new SqlCommand("select * from EmpPayment where Payment_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "EmpPayment");
                datagridviewpayment.DataMember = "EmpPayment";
                datagridviewpayment.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewpayment.DataSource = null;
        }

        private void cmbpaymentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbempid.Hide();
            try
            {
                cm = new SqlCommand("select * from EmpPayment where Payment_Id='" + cmbpaymentid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtempid.Text = dr["Emp_Id"].ToString();
                    txtempname.Text = dr["Emp_Name"].ToString();
                    datetimejoindate.Text = dr["Join_Date"].ToString();
                    datetimetodaysdate.Text = dr["Todays_Date"].ToString();
                    txtyearswork.Text = dr["Years_Work"].ToString();
                    txtbasicsalary.Text = dr["Basic_Salary"].ToString();
                    if (dr["Paid_By"].ToString() == "Cash")
                    {
                        rdbcash.Checked = true;
                    }
                    else
                    {
                        rdbcheque.Checked = true;
                    }
                    txtpaymentamount.Text = dr["Payment_Amount"].ToString();
                    txtchequeno.Text = dr["Cheque_No"].ToString();
                    txtaccountno.Text = dr["Account_No"].ToString();
                    txtbankname.Text = dr["Bank_Name"].ToString();
                    txtbranch.Text = dr["Branch"].ToString();
                    datetimepaymentdate.Text = dr["Payment_Date"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xpos == -1)
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

        

        
        

  