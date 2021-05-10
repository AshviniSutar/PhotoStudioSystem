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
    public partial class frmVisit : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmVisit()
        {
            InitializeComponent();
        }

        private void frmVisit_Load(object sender, EventArgs e)
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
            txtvisitid.Text = "";
            cmbempid.Text = "";
            txtempid.Text = "";
            txtempname.Text = "";
            cmbbookid.Text = "";
            txtbookid.Text = "";
            txtcatname.Text = "";
            txtcustname.Text = "";
            txtvisitplace.Text = "";
            datetimevisitdate.Text = "";
            txtadvance.Text = "";
            txtvisitdays.Text = "";
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Visit", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewvisit.DataSource = dt;
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

        private void SeeRecord2()
        {
            cm = new SqlCommand("select Visit_Id from Visit", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbvisitid.Items.Add(dr["Visit_Id"].ToString());
                cmbvisitid.ValueMember = dr["Visit_Id"].ToString(); ;
                cmbvisitid.DisplayMember = dr["Visit_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void SeeRecord3()
        {
            cm = new SqlCommand("select Visit_Id from Visit", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbidsearch.Items.Add(dr["Visit_Id"].ToString());
                cmbidsearch.ValueMember = dr["Visit_Id"].ToString(); ;
                cmbidsearch.DisplayMember = dr["Visit_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Name from Emp where Emp_Id='" + cmbempid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtempname.Text = dr["Name"].ToString();
            }
            dr.Close();
        }

        private void cmbbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("select Category_Name,Cust_Name,Visit_Place,Visit_Date,Advance from Booking where Book_Id='" + cmbbookid.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtcatname.Text = dr["Category_Name"].ToString();
                txtcustname.Text = dr["Cust_Name"].ToString();
                txtvisitplace.Text = dr["Visit_Place"].ToString();
                datetimevisitdate.Text = dr["Visit_Date"].ToString();
                txtadvance.Text = dr["Advance"].ToString();
            }
            dr.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbbookid.Show();
            cmbempid.Show();
            cmbvisitid.Hide();
            try
            {
                cm = new SqlCommand("select max(Visit_Id)from Visit", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtvisitid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtvisitid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("insert into Visit values(" + int.Parse(txtvisitid.Text) + ",'" + cmbempid.Text + "','" + txtempname.Text + "','" + cmbbookid.Text + "','" + txtcatname.Text + "','" + txtcustname.Text + "','" + txtvisitplace.Text + "','" + datetimevisitdate.Value.Date.ToLongDateString() + "'," + int.Parse(txtadvance.Text) + "," + int.Parse(txtvisitdays.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm = new SqlCommand("Delete from Booking where Book_Id='" + cmbbookid.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    Clear();
                    showData();
                    cmbvisitid.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("update Visit set Visit_Id=" + int.Parse(cmbvisitid.Text) + ",Emp_Id=" + int.Parse(txtempid.Text) + ",Emp_Name='" + txtempname.Text + "',Book_Id=" + int.Parse(txtbookid.Text) + ",Category_Name='" + txtcatname.Text + "',Cust_Name='" + txtcustname.Text + "',Visit_Place='" + txtvisitplace.Text + "',Visit_Date='" + datetimevisitdate.Value.Date.ToLongDateString() + "',Advance=" + int.Parse(txtadvance.Text) + ",Visit_Days=" + int.Parse(txtvisitdays.Text) + " where Visit_Id=" + int.Parse(cmbvisitid.Text) + "", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    Clear();
                    cmbvisitid.Show();
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
                cm = new SqlCommand("Delete from Visit where Visit_Id=(" + int.Parse(cmbvisitid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbvisitid.Show();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error in deleting Record...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbidsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewvisit.DataSource = null;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select * from Visit where Visit_Id=(" + cmbidsearch.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Visit");
                datagridviewvisit.DataMember = "Visit";
                datagridviewvisit.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void cmbvisitid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbempid.Hide();
            cmbbookid.Hide();
            try
            {
                cm = new SqlCommand("select * from Visit where Visit_Id='" + cmbvisitid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtempid.Text = dr["Emp_Id"].ToString();
                    txtempname.Text = dr["Emp_Name"].ToString();
                    txtbookid.Text = dr["Book_Id"].ToString();
                    txtcatname.Text = dr["Category_Name"].ToString();
                    txtcustname.Text = dr["Cust_Name"].ToString();
                    txtvisitplace.Text = dr["Visit_Place"].ToString();
                    datetimevisitdate.Text = dr["Visit_Date"].ToString();
                    txtadvance.Text = dr["Advance"].ToString();
                    txtvisitdays.Text = dr["Visit_Days"].ToString();
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

        private void txtvisitdays_Validating(object sender, CancelEventArgs e)
        {
            if (txtvisitdays.Text == string.Empty)
            {
                errorProvider1.SetError(txtvisitdays, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtvisitdays.Text))
                {
                    errorProvider1.SetError(txtvisitdays, "");
                }
                else
                {
                    errorProvider1.SetError(txtvisitdays, "Please enter number");
                }
            }
        }
    }
}
