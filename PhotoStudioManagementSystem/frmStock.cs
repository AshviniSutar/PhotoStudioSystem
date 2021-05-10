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
    public partial class frmStock : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        DataTable dt;
        SqlDataReader dr;
        int xpos = 0, ypos = 0;
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            SeeRecord();
            showData();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select Equi_Id,Name,Brand,Quantity from Purchase", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewstock.DataSource = dt;
        }

        private void SeeRecord()
        {
            cm = new SqlCommand("select Equi_Id from Purchase", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbsearchid.Items.Add(dr["Equi_Id"].ToString());
                cmbsearchid.ValueMember = dr["Equi_Id"].ToString(); ;
                cmbsearchid.DisplayMember = dr["Equi_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmPurchase purchase = new frmPurchase();
            purchase.ShowDialog();
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Equi_Id,Name,Brand,Quantity from Purchase where Equi_Id='" + cmbsearchid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtid.Text = dr["Equi_Id"].ToString();
                txtname.Text = dr["Name"].ToString();
                txtbrand.Text = dr["Brand"].ToString();
                txtquantity.Text = dr["Quantity"].ToString();
            }
            dr.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
