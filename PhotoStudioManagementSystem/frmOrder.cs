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
    public partial class frmOrder : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cm;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
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
            cmbcustid.Show();
            cmborderid.Show();
            cmborderid.Text = "";
            txtorderid.Text = "";
            cmbcustid.Text = "";
            txtcname.Text = "";
            txtphotoid.Text = "";
            datetimedeliverydate.Text = "";
            datetimeorderdate.Text = "";
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Orderphoto", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridvieworder.DataSource = dt;
        }

        private void SeeRecord()
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

        private void SeeRecord1()
        {
            cm = new SqlCommand("select Order_Id from Orderphoto", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmborderid.Items.Add(dr["Order_Id"].ToString());
                cmborderid.ValueMember = dr["Order_Id"].ToString(); ;
                cmborderid.DisplayMember = dr["Order_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Order_Id from Orderphoto", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Order_Id"].ToString());
                cmbidsearch.ValueMember = dr["Order_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Order_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnneworder_Click(object sender, EventArgs e)
        {
            cmborderid.Hide();
            try
            {
                cm = new SqlCommand("select max(Order_Id)from Orderphoto", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtorderid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtorderid.Text = "1";
            }
            dr.Close();
        }

        private void btnnewphoto_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select max(Photo_Id)from Photo", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtphotoid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtphotoid.Text = "1";
            }
            dr.Close();
            frmPhoto p = new frmPhoto();
            p.ShowDialog();
        }

        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Cust_Name from Cust where Cust_Id=('" + cmbcustid.Text + "')", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcname.Text = dr["Cust_Name"].ToString();
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("insert into Orderphoto values(" + int.Parse(txtorderid.Text) + ",'" + cmbcustid.Text + "','" + txtcname.Text + "'," + int.Parse(txtphotoid.Text) + ",'" + datetimeorderdate.Value.Date.ToLongDateString() + "','" + datetimedeliverydate.Value.Date.ToLongDateString() + "')", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showData();
                    cmborderid.Show();
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
                cm = new SqlCommand("update Orderphoto set Order_Id=" + int.Parse(cmborderid.Text) + ",Cust_Id='" + txtcustid.Text + "',Cust_Name='" + txtcname.Text + "',Photo_Id=" + int.Parse(txtphotoid.Text) + ",Order_Date='" + datetimeorderdate.Value.Date.ToLongDateString() + "',Delivery_Date='" + datetimedeliverydate.Value.Date.ToLongDateString() + "'  where Order_Id='" + cmborderid.Text + "'", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record updated successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showData();
                    cmborderid.Show();
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
                cm = new SqlCommand("Delete from Orderphoto where Order_Id=(" + int.Parse(cmborderid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmborderid.Show();
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

        private void cmborderid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcustid.Hide();
            try
            {
                cm = new SqlCommand("select * from Orderphoto where Order_Id='" + cmborderid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtcustid.Text = dr["Cust_Id"].ToString();
                    txtcname.Text = dr["Cust_Name"].ToString();
                    txtphotoid.Text = dr["Photo_Id"].ToString();
                    datetimedeliverydate.Text = dr["Delivery_Date"].ToString();
                    datetimeorderdate.Text = dr["Order_Date"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Orderphoto where Order_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Orderphoto");
                datagridvieworder.DataMember = "Orderphoto";
                datagridvieworder.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridvieworder.DataSource = null;
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
      

    

