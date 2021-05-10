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
    public partial class frmPurchaseReturn : Form
    {
        SqlConnection cn;
        SqlCommand cm,cm1;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
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
            cm = new SqlCommand("select * from PurchaseReturn", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewpurchasereturn.DataSource = dt;
        }

        private void Clear()
        {
            cmbequiid.Show();
            cmbpurchasereturnid.Show();
            txtpurchasereturnid.Text = "";
            cmbpurchasereturnid.Text = "";
            cmbequiid.Text = "";
            txtequiid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            txtsuppliername.Text = "";
            datetimedate.Text = "";
            txtreasons.Text = "";
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select PurchaseReturn_Id from PurchaseReturn", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbpurchasereturnid.Items.Add(dr["PurchaseReturn_Id"].ToString());
                cmbpurchasereturnid.ValueMember = dr["PurchaseReturn_Id"].ToString(); ;
                cmbpurchasereturnid.DisplayMember = dr["PurchaseReturn_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select PurchaseReturn_Id from PurchaseReturn", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["PurchaseReturn_Id"].ToString());
                cmbidsearch.ValueMember = dr["PurchaseReturn_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["PurchaseReturn_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
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

        private void cmbequiid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Enabled = false;
            try
            {
                cm = new SqlCommand("select * from Purchase where Equi_Id='" + cmbequiid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtname.Text = dr["Name"].ToString();
                    txtprice.Text = dr["Price"].ToString();
                    txtavailable.Text = dr["Quantity"].ToString();
                    txtsuppliername.Text = dr["Supplier_Name"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbequiid.Show();
            cmbpurchasereturnid.Hide();
            try
            {
                cm = new SqlCommand("select max(PurchaseReturn_Id)from PurchaseReturn", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtpurchasereturnid.Text = z.ToString();
                }
                dr.Close();

            }
            catch
            {
                txtpurchasereturnid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtquantity.Text) < int.Parse(txtavailable.Text))
                {
                    if (txtreasons.Text == string.Empty)
                    {
                        MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    }
                    else
                    {
                        cm = new SqlCommand("insert into PurchaseReturn Values(" + int.Parse(txtpurchasereturnid.Text) + ",'" + cmbequiid.Text + "','" + txtname.Text + "'," + int.Parse(txtprice.Text) + "," + int.Parse(txtquantity.Text) + ",'" + txtsuppliername.Text + "','" + datetimedate.Value.Date.ToLongDateString() + "','" + txtreasons.Text + "'," + int.Parse(txtavailable.Text) + ")", cn);
                        int z = cm.ExecuteNonQuery();
                        if (z == 1)
                        {
                            MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cm1 = new SqlCommand("update Purchase set Quantity=(Quantity-" + int.Parse(txtquantity.Text) + ") where Equi_Id='" + cmbequiid.Text + "'", cn);
                            cm1.ExecuteNonQuery();
                            Clear();
                            showData();
                            cmbpurchasereturnid.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is high...!", "Check stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                if (int.Parse(txtquantity.Text) < int.Parse(txtavailable.Text))
                {
                    if (txtreasons.Text == string.Empty)
                    {
                        MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    }
                    else
                    {
                        cm = new SqlCommand("update PurchaseReturn set Reasons='" + txtreasons.Text + "',Date='" + datetimedate.Value.Date.ToLongDateString() + "' where PurchaseReturn_Id='" + cmbpurchasereturnid.Text + "'", cn);
                        int z = cm.ExecuteNonQuery();
                        if (z == 1)
                        {
                            MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showData();
                            Clear();
                            cmbpurchasereturnid.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is high...!", "Check stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Error in updating Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbpurchasereturnid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbequiid.Hide();
            try
            {
                cm = new SqlCommand("select * from PurchaseReturn where PurchaseReturn_Id='" + cmbpurchasereturnid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtequiid.Text = dr["Equi_Id"].ToString();
                    txtname.Text = dr["Name"].ToString();
                    txtprice.Text = dr["Price"].ToString();
                    txtquantity.Text = dr["Quantity"].ToString();
                    txtsuppliername.Text = dr["Supplier_Name"].ToString();
                    datetimedate.Text = dr["Date"].ToString();
                    txtreasons.Text = dr["Reasons"].ToString();
                    txtavailable.Text = dr["Available_Quantity"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from PurchaseReturn where PurchaseReturn_Id=(" + int.Parse(cmbpurchasereturnid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbpurchasereturnid.Show();
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
                cm = new SqlCommand("select * from PurchaseReturn where PurchaseReturn_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "PurchaseReturn");
                datagridviewpurchasereturn.DataMember = "PurchaseReturn";
                datagridviewpurchasereturn.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewpurchasereturn.DataSource = null;
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
