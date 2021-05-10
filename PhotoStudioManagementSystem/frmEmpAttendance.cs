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
    public partial class frmEmpAttendance : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;      
        string attendance;
        public frmEmpAttendance()
        {
            InitializeComponent();
        }

        private void frmEmpAttendance_Load(object sender, EventArgs e)
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

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from EmpAttendance", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewattendance.DataSource = dt;
        }

        private void Clear()
        {
            cmbempid.Text = "";
            txtempname.Text = "";
            datetimedate.Text = "";
            rdbabsent.Checked = false;
            rdbpresent.Checked = false;
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
            cm = new SqlCommand("select Emp_Id from EmpAttendance", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbsearchid.Items.Add(dr["Emp_Id"].ToString());
                cmbsearchid.ValueMember = dr["Emp_Id"].ToString(); ;
                cmbsearchid.DisplayMember = dr["Emp_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void cmbempid_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            int u = cmbid.SelectedIndex;
            txtName.Text = dt1.Rows[u].ItemArray[1].ToString();*/
            try
            {
                cm = new SqlCommand("select Name from Emp where Emp_Id='" + cmbempid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtempname.Text = dr["Name"].ToString();
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
               // int u = cmbempid.SelectedIndex;
               // DateTime d = datetimedate.Value;
          
                cm = new SqlCommand("insert into EmpAttendance Values(" + int.Parse(cmbempid.Text) + ",'" + txtempname.Text + "','"+datetimedate.Value.Date.ToLongDateString()+"','"+this.attendance+"')", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showData();
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbpresent_CheckedChanged(object sender, EventArgs e)
        {
            attendance = "Present";
        }

        private void rdbabsent_CheckedChanged(object sender, EventArgs e)
        {
            attendance = "Absent";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
          try
            {
                cm = new SqlCommand("select * from EmpAttendance where Emp_Id=(" + cmbsearchid.Text + ")", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "EmpAttendance");
                datagridviewattendance.DataMember = "EmpAttendance";
                datagridviewattendance.DataSource = ds;
            }
          catch
          {
              MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        private void cmbsearchid_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewattendance.DataSource = null;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from EmpAttendance where Emp_Id=(" + int.Parse(cmbempid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbempid.Show();
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
