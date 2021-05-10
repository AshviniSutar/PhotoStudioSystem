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
    public partial class frmPhoto : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cm;
        DataTable dt;
        int amount;
        int xpos = 0, ypos = 0;
        public frmPhoto()
        {
            InitializeComponent();
        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            SeeRecord();
            SeeRecord1();
            SeeRecord2();
            cmbpid.Hide();
            cmbcid.Show();
            try
            {
                cm = new SqlCommand("select max(Photo_Id)from Photo", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtpid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtpid.Text = "1";
            }
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void Clear()
        {
            cmbcid.Show();
            cmbpid.Show();
            txtpid.Text = "";
            cmbcid.Text = "";
            txtcname.Text = "";
            cmbpsize.Text = "";
            txtpprice.Text = "";
            txtpquantity.Text = "";
            txttotalprice.Text = "";
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Photo", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewphoto.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpprice.Text == string.Empty || txtpquantity.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    cm = new SqlCommand("insert into Photo Values(" + int.Parse(txtpid.Text) + ",'" + cmbcid.Text + "','" + txtcname.Text + "','" + cmbpsize.Text + "'," + int.Parse(txtpprice.Text) + "," + int.Parse(txtpquantity.Text) + "," + int.Parse(txttotalprice.Text) + ",'" + datetimephoto.Value.Date.ToLongDateString() + "')", cn);
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbpid.Show();
                    }
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
                cmbcid.Items.Add(dr["Cust_Id"].ToString());
                cmbcid.ValueMember = dr["Cust_Id"].ToString(); ;
                cmbcid.DisplayMember = dr["Cust_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Photo_Id from Photo", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbpid.Items.Add(dr["Photo_Id"].ToString());
                cmbpid.ValueMember = dr["Photo_Id"].ToString(); ;
                cmbpid.DisplayMember = dr["Photo_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Photo_Id from Photo", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Photo_Id"].ToString());
                cmbidsearch.ValueMember = dr["Photo_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Photo_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void cmbpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcid.Hide();
            cm = new SqlCommand("select Cust_Id,Cust_Name,Photo_Price,Photo_Size,Photo_Quantity,Total_Price,Date from Photo where Photo_Id='" + cmbpid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcustid.Text = dr["Cust_ID"].ToString();
                txtcname.Text = dr["Cust_Name"].ToString();
                cmbpsize.Text = dr["Photo_Size"].ToString();
                txtpprice.Text = dr["Photo_Price"].ToString();
                txtpquantity.Text = dr["Photo_Quantity"].ToString();
                txttotalprice.Text = dr["Total_Price"].ToString();
                datetimephoto.Text = dr["Date"].ToString();
            }
            dr.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from Photo where Photo_Id=(" + int.Parse(cmbpid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbpid.Show();
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

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewphoto.DataSource = null;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Photo where Photo_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Photo");
                datagridviewphoto.DataMember = "Photo";
                datagridviewphoto.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Cust_Name from Cust where Cust_Id=('" + cmbcid.Text + "')", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcname.Text = dr["Cust_Name"].ToString();
            }
            dr.Close();
        }

        private void txtpquantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtpquantity.Text == string.Empty)
            {
                errorProvider1.SetError(txtpquantity, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtpquantity.Text))
                {
                    errorProvider1.SetError(txtpquantity, "");
                }
                else
                {
                    errorProvider1.SetError(txtpquantity, "Please enter 10 digit number");
                }
            }
        }

        private void txtpprice_Validating(object sender, CancelEventArgs e)
        {
            if (txtpprice.Text == string.Empty)
            {
                errorProvider1.SetError(txtpprice, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtpprice.Text))
                {
                    errorProvider1.SetError(txtpprice, "");
                }
                else
                {
                    errorProvider1.SetError(txtpprice, "Please enter 10 digit number");
                }
            }
        }

        private void txtpquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(txtpprice.Text) * int.Parse(txtpquantity.Text);
                txttotalprice.Text = amount.ToString();
            }
            catch (Exception)
            {
                txttotalprice.Text = "";
            }
        }

        private void txtpprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(txtpprice.Text) * int.Parse(txtpquantity.Text);
                txttotalprice.Text = amount.ToString();
            }
            catch (Exception)
            {
                txttotalprice.Text = "";
            }
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
