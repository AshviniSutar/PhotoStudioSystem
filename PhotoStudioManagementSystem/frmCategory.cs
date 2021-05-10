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
    public partial class frmCategory : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        DataTable dt;
        int xpos = 0, ypos = 0;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void Clear()
        {
            txtcategoryid.Text = "";
            txtcategoryname.Text = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select max(Category_Id)from Category", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtcategoryid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtcategoryid.Text = "1";
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("insert into Category Values(" + int.Parse(txtcategoryid.Text) + ",'" + txtcategoryname.Text + "')", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record saved successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            Clear();
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
