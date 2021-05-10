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
    public partial class frmPurchaseBill : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        string pay;
        int xpos = 0, ypos = 0;
        public frmPurchaseBill()
        {
            InitializeComponent();
        }

        private void frmPurchaseBill_Load(object sender, EventArgs e)
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

        private void Clear()
        {
            cmbbillid.Show();
            cmbequiid.Show();
            txtbillid.Text = "";
            txtequiid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            txtsuppliername.Text = "";
            datetimebilldate.Text = "";
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from PurchaseBill", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewpurchasebill.DataSource = dt;
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Bill_Id from PurchaseBill", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbsearchid.Items.Add(dr["Bill_Id"].ToString());
                cmbsearchid.ValueMember = dr["Bill_Id"].ToString(); ;
                cmbsearchid.DisplayMember = dr["Bill_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Equi_Id from Purchase", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbequiid.Items.Add(dr["Equi_Id"].ToString());
                cmbequiid.ValueMember = dr["Equi_Id"].ToString(); ;
                cmbequiid.DisplayMember = dr["Equi_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Bill_Id from PurchaseBill", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbbillid.Items.Add(dr["Bill_Id"].ToString());
                cmbbillid.ValueMember = dr["Bill_Id"].ToString(); ;
                cmbbillid.DisplayMember = dr["Bill_Id"].ToString(); ;
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbbillid.Hide();
            cmbequiid.Show();
            try
            {
                cm = new SqlCommand("select max(Bill_Id)from PurchaseBill", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtbillid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtbillid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbcash.Checked == true)
                {
                    int z = cm.ExecuteNonQuery();
                    cm = new SqlCommand("insert into PurchaseBill values(" + int.Parse(txtbillid.Text) + ",'" + cmbequiid.Text + "','" + txtname.Text + "'," + int.Parse(txtprice.Text) + "," + int.Parse(txtquantity.Text) + ",'" + txtsuppliername.Text + "','" + datetimebilldate.Text + "','" + this.pay + "','','','','')", cn);
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbequiid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("insert into PurchaseBill values(" + int.Parse(txtbillid.Text) + ",'" + cmbequiid.Text + "','" + txtname.Text + "'," + int.Parse(txtprice.Text) + "," + int.Parse(txtquantity.Text) + ",'" + txtsuppliername.Text + "','" + datetimebilldate.Value.Date.ToLongDateString() + "','" + this.pay + "'," + int.Parse(txtchequeno.Text) + ",'" + txtbankname.Text + "'," + int.Parse(txtaccountno.Text) + ",'" + txtbranch.Text + "')", cn);

                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showData();
                        cmbequiid.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbequiid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select * from Purchase where Equi_Id='" + cmbequiid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr["Name"].ToString();
                txtprice.Text = dr["Price"].ToString();
                txtquantity.Text = dr["Quantity"].ToString();
                txtsuppliername.Text = dr["Supplier_Name"].ToString();
            }
            dr.Close();
        }

        private void cmbbillid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbequiid.Hide();
            cm = new SqlCommand("select * from PurchaseBill where Bill_Id='" + cmbbillid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtequiid.Text = dr["Equi_Id"].ToString();
                txtname.Text = dr["Name"].ToString();
                txtprice.Text = dr["Price"].ToString();
                txtquantity.Text = dr["Quantity"].ToString();
                txtsuppliername.Text = dr["Supplier_Name"].ToString();
                datetimebilldate.Text = dr["Date"].ToString();
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
                if (rdbcash.Checked == true)
                {
                    txtbankname.Text = "";
                    txtbranch.Text = "";
                    txtchequeno.Text = "";
                    txtaccountno.Text = "";
                    cm = new SqlCommand("update PurchaseBill set Paid_By='" + this.pay + "',Bank_Name='',Branch='',Account_No='',Cheque_No='' where Bill_Id=" + int.Parse(cmbbillid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbillid.Show();
                    }
                }
                else if (rdbcheque.Checked == true)
                {
                    cm = new SqlCommand("update purchaseBill set Paid_By='" + this.pay + "',Bank_Name='" + txtbankname.Text + "',Cheque_No='" + txtchequeno.Text + "',Branch='" + txtbranch.Text + "',Account_No='" + txtaccountno.Text + "' where Bill_Id=" + int.Parse(cmbbillid.Text) + "", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbbillid.Show();
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
                cm = new SqlCommand("Delete from PurchaseBill where Bill_Id=(" + int.Parse(cmbbillid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbbillid.Show();
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
            datagridviewpurchasebill.DataSource = null;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from PurchaseBill where Bill_Id=(" + cmbsearchid.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "PurchaseBill");
                datagridviewpurchasebill.DataMember = "PurchaseBill";
                datagridviewpurchasebill.DataSource = ds;
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
