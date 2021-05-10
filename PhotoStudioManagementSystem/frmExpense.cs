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
    public partial class frmExpense : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        string pay;
        int xpos = 0, ypos = 0;
        public frmExpense()
        {
            InitializeComponent();
        }

        private void frmExpence_Load(object sender, EventArgs e)
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
            cmbexpenseid.Show();
            txtexpenseid.Text = "";
            txtdetail.Text = "";
            txtchequeno.Text = "";
            txtbranch.Text = "";
            txtbankname.Text = "";
            txtamount.Text = "";
            txtaccountno.Text = "";
            datetimeexpensedate.Text = "";
            rdbcash.Checked = false;
            rdbcheque.Checked = false;
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Expense", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewexpense.DataSource = dt;
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Expense_Id from Expense", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbsearchid.Items.Add(dr["Expense_Id"].ToString());
                cmbsearchid.ValueMember = dr["Expense_Id"].ToString(); ;
                cmbsearchid.DisplayMember = dr["Expense_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Expense_Id from Expense", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbexpenseid.Items.Add(dr["Expense_Id"].ToString());
                cmbexpenseid.ValueMember = dr["Expense_Id"].ToString(); ;
                cmbexpenseid.DisplayMember = dr["Expense_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbexpenseid.Hide();
            try
            {
                cm = new SqlCommand("select max(Expense_Id)from Expense", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtexpenseid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtexpenseid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text == string.Empty || txtdetail.Text == string.Empty  || rdbcash.Checked == false && rdbcheque.Checked == false)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (rdbcash.Checked == true)
                {
                    txtchequeno.Text = "";
                    txtbranch.Text = "";
                    txtbankname.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("insert into Expense values(" + int.Parse(txtexpenseid.Text) + ",'" + datetimeexpensedate.Text + "','" + txtdetail.Text + "'," + int.Parse(txtamount.Text) + ",'" + this.pay + "','','','','')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbexpenseid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("insert into Expense values(" + int.Parse(txtexpenseid.Text) + ",'" + datetimeexpensedate.Text + "','" + txtdetail.Text + "'," + int.Parse(txtamount.Text) + ",'" + this.pay + "'," + int.Parse(txtchequeno.Text) + ",'" + txtbankname.Text + "'," + int.Parse(txtaccountno.Text) + ",'" + txtbranch.Text + "')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbexpenseid.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbcash_CheckedChanged(object sender, EventArgs e)
        {
            txtchequeno.Text = "";
            txtbranch.Text = "";
            txtbankname.Text = "";
            txtaccountno.Text = "";
            panel1.Hide();
            pay = "Cash";
        }

        private void rdbcheque_CheckedChanged(object sender, EventArgs e)
        {
            pay = "Cheque";
            panel1.Show();
        }

        private void cmbexpenseid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select * from Expense where Expense_Id='" + cmbexpenseid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtamount.Text = dr["Amount"].ToString();
                txtdetail.Text = dr["Detail"].ToString();
                datetimeexpensedate.Text = dr["Date"].ToString();
                if (dr["Paid_By"].ToString() == "Cash")
                {
                    rdbcash.Checked = true;
                }
                else
                {
                    rdbcheque.Checked = true;
                }
                txtchequeno.Text = dr["Cheque_No"].ToString();
                txtaccountno.Text = dr["Account_No"].ToString();
                txtbankname.Text = dr["Bank_Name"].ToString();
                txtbranch.Text = dr["Branch"].ToString();
            }
            dr.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text == string.Empty || txtdetail.Text == string.Empty || rdbcash.Checked == false && rdbcheque.Checked == false)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                if (rdbcash.Checked == true)
                {
                    txtbankname.Text = "";
                    txtbranch.Text = "";
                    txtchequeno.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("update Expense set Paid_By='" + this.pay + "',Bank_Name='',Branch='',Account_No='',Cheque_No='' where Expense_Id=" + int.Parse(cmbexpenseid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbexpenseid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("update Expense set Paid_By='" + this.pay + "',Bank_Name='" + txtbankname.Text + "',Cheque_No='" + txtchequeno.Text + "',Branch='" + txtbranch.Text + "',Account_No='" + txtaccountno.Text + "' where Expense_Id=" + int.Parse(cmbexpenseid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbexpenseid.Show();
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
                cm = new SqlCommand("Delete from Expense where Expense_Id=(" + int.Parse(cmbexpenseid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbexpenseid.Show();
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

        private void cmbsearchid_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewexpense.DataSource = null;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Expense where Expense_Id=(" + cmbsearchid.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Expense");
                datagridviewexpense.DataMember = "Expense";
                datagridviewexpense.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
