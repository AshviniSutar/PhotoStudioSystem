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
using System.IO;
using System.Text.RegularExpressions;

namespace PhotoStudioManagementSystem
{
    public partial class frmPurchase : Form
    {
        SqlCommand cm,cm1;
        SqlConnection cn;
        DataTable dt,dt1;
        SqlDataReader dr,dr1;
        string imagename;
        int xpos = 0, ypos = 0;
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            dt1=new DataTable();
            SeeRecord();
            SeeRecord1();
            SeeRecord2();
            timer1.Start();
            xpos = label1.Location.X;
            ypos = label1.Location.Y;
        }

        private void Clear()
        {
            cmbequiid.Show();
            cmbsupplierid.Show();
            txtequiid.Text = "";
            txtname.Text = "";
            txtbrand.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            cmbsupplierid.Text = "";
            txtsuppliername.Text = "";
            txtsupplierid.Text = "";
            pictureBox1.Image = null;
        }

        private void showData()
        {
            dt.Clear();
            cm = new SqlCommand("select * from Purchase", cn);
            dr = cm.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            datagridviewequi.RowTemplate.Height = 50;
            datagridviewequi.AllowUserToAddRows = false;
            datagridviewequi.DataSource = dt;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)datagridviewequi.Columns[8];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
            cm = new SqlCommand("select Supplier_Id from Supplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbsupplierid.Items.Add(dr["Supplier_Id"].ToString());
                cmbsupplierid.ValueMember = dr["Supplier_Id"].ToString(); ;
                cmbsupplierid.DisplayMember = dr["Supplier_Id"].ToString(); ;
            }
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == string.Empty || txtbrand.Text == string.Empty || txtprice.Text == string.Empty || txtquantity.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                FileStream fs = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[fs.Length];
                fs.Read(img, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                cm = new SqlCommand("insert into Purchase values(" + int.Parse(txtequiid.Text) + ",'" + txtname.Text + "','" + txtbrand.Text + "'," + int.Parse(txtprice.Text) + "," + int.Parse(txtquantity.Text) + ",'" + cmbsupplierid.Text + "','" + txtsuppliername.Text + "','" + datetimeequi.Value.Date.ToLongDateString() + "',@image)", cn);
                cm.Parameters.Add(new SqlParameter("image", img));

                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record inserted successfully...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showData();
                    cmbequiid.Show();
                 }
            }
            catch
            {
                MessageBox.Show("Error in inserting Record...!", "Record Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbequiid.Hide();
            cmbsupplierid.Show();
            try
            {
                cm = new SqlCommand("select max(Equi_Id)from Purchase", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int z = int.Parse(dr[0].ToString()) + 1;
                    txtequiid.Text = z.ToString();
                }
                dr.Close();
            }
            catch
            {
                txtequiid.Text = "1";
            }
            dr.Close();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
            fd.Filter = "Image File(*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                imagename = fd.FileName;
                Bitmap bmp = new Bitmap(imagename);
                pictureBox1.Image = (Image)bmp;
            }
            fd = null;
        }

        private void cmbsupplierid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("select Supplier_Name from Supplier where Supplier_Id='" + cmbsupplierid.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    txtsuppliername.Text = dr["Supplier_Name"].ToString();
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("Error in fetching Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == string.Empty || txtbrand.Text == string.Empty || txtprice.Text == string.Empty || txtquantity.Text == string.Empty || txtsupplierid.Text == string.Empty)
                {
                    MessageBox.Show("Fill all information...!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cm = new SqlCommand("update Purchase set Name='" + txtname.Text + "',Brand='" + txtbrand.Text + "',Price=" + int.Parse(txtprice.Text) + ",Quantity=" + int.Parse(txtquantity.Text) + ",Supplier_Id='" + txtsupplierid.Text + "',Supplier_Name='" + txtsuppliername.Text + "',Date='" + datetimeequi.Value.Date.ToLongDateString() + "',Image=@Image where Equi_Id=" + int.Parse(cmbequiid.Text) + "", cn);
                    cm.Parameters.Add(new SqlParameter("Image", img));
                    int z = cm.ExecuteNonQuery();
                    if (z == 1)
                    {
                        MessageBox.Show("One record updated successfully...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        Clear();
                        cmbequiid.Show();
                        btnexit.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error in updating Record...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbequiid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsupplierid.Hide();
            cm = new SqlCommand("select * from Purchase where Equi_Id='" + cmbequiid.Text + "'", cn);
            cm1 = new SqlCommand("select * from Purchase where Equi_Id='" + cmbequiid.Text + "'", cn);
            dr = cm1.ExecuteReader();

            while (dr.Read())
            {
                txtname.Text = dr["Name"].ToString();
                txtbrand.Text = dr["Brand"].ToString();
                txtprice.Text = dr["Price"].ToString();
                txtquantity.Text = dr["Quantity"].ToString();
                txtsupplierid.Text = dr["Supplier_Id"].ToString();
                txtsuppliername.Text = dr["Supplier_Name"].ToString();
                datetimeequi.Text = dr["Date"].ToString();
            }
            dr.Close();

            dr1 = cm1.ExecuteReader();

            dt1.Load(dr1);
            foreach (DataRow row in dt1.Rows)
            {
                if (row[0].ToString() == cmbequiid.SelectedItem.ToString())
                {
                    byte[] blob = (byte[])row[8];
                    MemoryStream ms = new MemoryStream(blob);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("Delete from Purchase where Equi_Id=(" + int.Parse(cmbequiid.Text) + ")", cn);
                int z = cm.ExecuteNonQuery();
                if (z == 1)
                {
                    MessageBox.Show("One record Deleted successfully...!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    cmbequiid.Show();
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
                cm = new SqlCommand("select * from Purchase where Equi_Id='" + cmbsearchid.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Purchase");
                datagridviewequi.DataMember = "Purchase";

                datagridviewequi.RowTemplate.Height = 50;
                datagridviewequi.AllowUserToAddRows = false;
                datagridviewequi.DataSource = ds;
                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol = (DataGridViewImageColumn)datagridviewequi.Columns[8];
                imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch
            {
                MessageBox.Show("Error in search...!", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (txtname.Text == string.Empty)
            {
                errorProvider1.SetError(txtname, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtname.Text))
                {
                    errorProvider1.SetError(txtname, "");
                }
                else
                {
                    errorProvider1.SetError(txtname, "Please enter character");
                }
            }
        }

        private void txtbrand_Validating(object sender, CancelEventArgs e)
        {
            if (txtbrand.Text == string.Empty)
            {
                errorProvider1.SetError(txtbrand, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (!no.IsMatch(txtbrand.Text))
                {
                    errorProvider1.SetError(txtbrand, "");
                }
                else
                {
                    errorProvider1.SetError(txtbrand, "Please enter character");
                }
            }
        }

        private void txtprice_Validating(object sender, CancelEventArgs e)
        {
            if (txtprice.Text == string.Empty)
            {
                errorProvider1.SetError(txtprice, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtprice.Text))
                {
                    errorProvider1.SetError(txtprice, "");
                }
                else
                {
                    errorProvider1.SetError(txtprice, "Please enter number");
                }
            }
        }

        private void txtquantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtquantity.Text == string.Empty)
            {
                errorProvider1.SetError(txtquantity, "Please fill information");
            }
            else
            {
                Regex no = new Regex(@"^([0-9]*|\d*)$");
                if (no.IsMatch(txtquantity.Text))
                {
                    errorProvider1.SetError(txtquantity, "");
                }
                else
                {
                    errorProvider1.SetError(txtquantity, "Please enter number");
                }
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

        private void cmbsearchid_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridviewequi.DataSource = null;
        }   

       
   
    }
}
