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
    public partial class frmLog : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            showData();
        }

        public void showData()
        {
            
            cm = new SqlCommand("select * from LogManager", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            listView1.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(new ListViewItem(dt.Rows[i].ItemArray[0].ToString()));
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("truncate table LogManager", cn);
            int a = cm.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("Log cleared...!", "Clear Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            listView1.Items.Clear();
            dt.Clear();
            showData();
        }

       
        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dt.Clear();
            showData();
        }
    }
}
