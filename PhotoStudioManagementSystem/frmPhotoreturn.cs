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
    public partial class frmPhotoreturn : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmPhotoreturn()
        {
            InitializeComponent();
        }

        private void frmPhotoreturn_Load(object sender, EventArgs e)
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
            cm = new SqlCommand("select * from Returnphoto", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewreturnphoto.DataSource = dt;
        }

        private void Clear()
        {
            cmbcid.Show();
            cmbreturnid.Show();
            txtreturnid.Text = "";
            txtcname.Text = "";
            cmbcid.Text = "";
            txtphotoid.Text = "";
            datetimedeliverydate.Text = "";
            txttotalprice.Text = "";
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Cust_Id from Orderphoto", cn);
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
            cm = new SqlCommand("select Return_Id from Returnphoto", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Return_Id"].ToString());
                cmbidsearch.ValueMember = dr["Return_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Return_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Return_Id from Returnphoto", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbreturnid.Items.Add(dr["Return_Id"].ToString());
                cmbreturnid.ValueMember = dr["Return_Id"].ToString(); ;
                cmbreturnid.DisplayMember = dr["Return_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnnewreturn_Click(object sender, EventArgs e)
        {
            txtreturnid.Enabled = false;
            cmbreturnid.Hide();
            try
            {
                cm = new SqlCommand("select max(Return_Id)from Returnphoto", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtreturnid.Text = z.ToString();
                }
                dr.Close();

            }
            catch
            {
                txtreturnid.Text = "1";
            }
            dr.Close();
        }

        private void cmbreturnid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcid.Hide();
            try
            {
                cm = new SqlCommand("select * from Returnphoto where Return_Id='" + cmbreturnid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtcid.Text = dr["Cust_Id"].ToString();
                    txtcname.Text = dr["Cust_Name"].ToString();
                    txtphotoid.Text = dr["Photo_Id"].ToString();
                    datetimedeliverydate.Text = dr["Delivery_Date"].ToString();
                    txttotalprice.Text = dr["Total_Price"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void cmbcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from OrderPhoto where Cust_Id='" + cmbcid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtcname.Text = dr["Cust_Name"].ToString();
                    txtphotoid.Text = dr["Photo_Id"].ToString();
                    datetimedeliverydate.Text = dr["Delivery_Date"].ToString();
                    
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();

            try
            {
                cm = new SqlCommand("select Total_Price from Photo where Cust_Id='" + cmbcid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txttotalprice.Text = dr["Total_Price"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("insert into Returnphoto Values(" + int.Parse(txtreturnid.Text) + ",'" + cmbcid.Text + "','" + txtcname.Text + "'," + int.Parse(txtphotoid.Text) + ",'" + datetimedeliverydate.Value.Date.ToLongDateString() + "'," + int.Parse(txttotalprice.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm = new SqlCommand("delete from Photo where Photo_Id='" + int.Parse(txtphotoid.Text) + "'", cn);
                    cm.ExecuteNonQuery();
                    cm = new SqlCommand("delete from Orderphoto where Photo_Id='" + int.Parse(txtphotoid.Text) + "'", cn);
                    cm.ExecuteNonQuery();
                    Clear();
                    showData();
                    cmbreturnid.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("update Returnphoto set Delivery_Date='"+datetimedeliverydate.Value.Date.ToLongDateString()+"' where cust_Id='"+txtcid.Text+"'",cn);
            int z = cm.ExecuteNonQuery();
            if (z == 1)
            {
                MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                Clear();
                cmbcid.Show();
                cmbreturnid.Show();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from Returnphoto where Return_Id=(" + int.Parse(cmbreturnid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbreturnid.Show();
                    cmbcid.Show();
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Returnphoto where Return_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Returnphoto");
                datagridviewreturnphoto.DataMember = "Returnphoto";
                datagridviewreturnphoto.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewreturnphoto.DataSource = null;   
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
