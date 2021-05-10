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
    public partial class frmMDI : Form
    {
        SqlConnection cn;
        SqlCommand cm, cm1;
        SqlDataReader dr;
        DataTable dt;
        string usernm, lastintime, lastouttime;
        DateTime dt0, dt1, dt2;
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            cn = new SqlConnection(cc.ConnectionString);
            cn.Open();
            dt = new DataTable();
            timer1.Enabled = true;
            timer2.Interval = 250;
            usernm = frmLogin.pass.ToString();
           lblwelcome.Text = "WELCOME  " + usernm.ToUpper();
            lbllogin.Text = "Log-In Time :  " + DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
            lastintime = DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
            dt0 = DateTime.Now;
            lastLoginTime();
            dt2 = DateTime.Now;
        }

        public void lastLoginTime()
        {
            try
            {
                cm1 = new SqlCommand("select * from logManager", cn);
                dr = cm1.ExecuteReader();
                dt.Load(dr);
                int y = dt.Rows.Count - 1;
                lbllastlogin.Text = "Last Log-In Time :  " + dt.Rows[y].ItemArray[1].ToString();
                dr.Close();
            }
            catch
            {
                lbllastlogin.Text = "Last Log-In Time :  - - -";
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object res = MessageBox.Show("This will Log-Out the User,Press OK to continue", "Log-Out User", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res.ToString().Equals("OK"))
            {
                lastouttime = DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
                dt1 = DateTime.Now;
                TimeSpan tsp = dt1 - dt0;
                string h, m, s;
                h = tsp.TotalHours.ToString();
                m = tsp.TotalMinutes.ToString();
                s = tsp.TotalSeconds.ToString();
                string diff = "  " + h.Substring(0, 4) + " Hours " + m.Substring(0, 4) + " Minutes " + s.Substring(0, 4) + " Seconds ";
                
                    cm = new SqlCommand("insert into LogManager values('" + usernm + "','" + lastintime + "','" + lastouttime + "','" + diff + "')", cn);
                    int i = cm.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Log-Out susccessfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
               
            }
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory();
            category.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer cust = new frmCustomer();
            cust.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword change = new frmChangePassword();
            change.ShowDialog();
        }

        private void bookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBooking book = new frmBooking();
            book.ShowDialog();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser user = new frmNewUser();
            user.ShowDialog();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpAttendance attendance = new frmEmpAttendance();
            attendance.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee payment = new frmEmployee();
            payment.ShowDialog();
        }

        private void employeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmppayment payment = new frmEmppayment();
            payment.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        private void photoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPhoto photo = new frmPhoto();
            photo.ShowDialog();
        }

        private void photoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhotoreturn preturn = new frmPhotoreturn();
            preturn.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase purchase = new frmPurchase();
            purchase.ShowDialog();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn preturn = new frmPurchaseReturn();
            preturn.ShowDialog();
        }

        private void visitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisit visit = new frmVisit();
            visit.Show();
        }

        private void visitBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisitBill bill = new frmVisitBill();
            bill.ShowDialog();
        }

        private void purchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseBill bill = new frmPurchaseBill();
            bill.ShowDialog();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.ShowDialog();
        }

        private void bookingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rptBooking b = new rptBooking();
            b.ShowDialog();
        }

        private void empPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptEmpPayment emp = new rptEmpPayment();
            emp.ShowDialog();
        }

        private void expenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rptExpense exp = new rptExpense();
            exp.ShowDialog();
        }

        private void photoReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptPhotoReturn photo = new rptPhotoReturn();
            photo.ShowDialog();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rptPurchase purc = new rptPurchase();
            purc.ShowDialog();
        }

        private void visiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptVisitBill vis = new rptVisitBill();
            vis.ShowDialog();
        }

        private void logDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmLog log = new frmLog();
             log.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsApps.shell("Notepad.exe", "Notepad"); 
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsApps.shell("Calc.exe", "Calculator");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutus ab = new frmAboutus();
            ab.ShowDialog();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }

        private void expenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExpense exp = new frmExpense();
            exp.ShowDialog();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

    }
}
