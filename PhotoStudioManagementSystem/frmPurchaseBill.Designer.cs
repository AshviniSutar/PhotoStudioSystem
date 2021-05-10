namespace PhotoStudioManagementSystem
{
    partial class frmPurchaseBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datetimebilldate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblequiid = new System.Windows.Forms.Label();
            this.lblsuppliername = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.cmbequiid = new System.Windows.Forms.ComboBox();
            this.txtequiid = new System.Windows.Forms.TextBox();
            this.lblbillid = new System.Windows.Forms.Label();
            this.cmbbillid = new System.Windows.Forms.ComboBox();
            this.txtbillid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaccountno = new System.Windows.Forms.TextBox();
            this.txtbankname = new System.Windows.Forms.TextBox();
            this.txtchequeno = new System.Windows.Forms.TextBox();
            this.lblaccountno = new System.Windows.Forms.Label();
            this.lblchequeno = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.lblbankname = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.rdbcheque = new System.Windows.Forms.RadioButton();
            this.rdbcash = new System.Windows.Forms.RadioButton();
            this.lblpaidby = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbsearchid = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.datagridviewpurchasebill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpurchasebill)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimebilldate
            // 
            this.datetimebilldate.CalendarFont = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimebilldate.Checked = false;
            this.datetimebilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimebilldate.Location = new System.Drawing.Point(502, 96);
            this.datetimebilldate.Name = "datetimebilldate";
            this.datetimebilldate.Size = new System.Drawing.Size(152, 22);
            this.datetimebilldate.TabIndex = 72;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(384, 92);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(55, 28);
            this.lbldate.TabIndex = 71;
            this.lbldate.Text = "Date";
            // 
            // lblequiid
            // 
            this.lblequiid.AutoSize = true;
            this.lblequiid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequiid.ForeColor = System.Drawing.Color.Navy;
            this.lblequiid.Location = new System.Drawing.Point(25, 92);
            this.lblequiid.Name = "lblequiid";
            this.lblequiid.Size = new System.Drawing.Size(146, 28);
            this.lblequiid.TabIndex = 60;
            this.lblequiid.Text = "Equipment_Id";
            // 
            // lblsuppliername
            // 
            this.lblsuppliername.AutoSize = true;
            this.lblsuppliername.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuppliername.ForeColor = System.Drawing.Color.Navy;
            this.lblsuppliername.Location = new System.Drawing.Point(26, 180);
            this.lblsuppliername.Name = "lblsuppliername";
            this.lblsuppliername.Size = new System.Drawing.Size(135, 28);
            this.lblsuppliername.TabIndex = 69;
            this.lblsuppliername.Text = "Supplier_Nm";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Navy;
            this.lblname.Location = new System.Drawing.Point(25, 136);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 28);
            this.lblname.TabIndex = 61;
            this.lblname.Text = "Name";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.BackColor = System.Drawing.SystemColors.Window;
            this.txtsuppliername.Enabled = false;
            this.txtsuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppliername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsuppliername.Location = new System.Drawing.Point(171, 184);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(152, 22);
            this.txtsuppliername.TabIndex = 70;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Navy;
            this.lblprice.Location = new System.Drawing.Point(384, 136);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(59, 28);
            this.lblprice.TabIndex = 62;
            this.lblprice.Text = "Price";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Navy;
            this.lblquantity.Location = new System.Drawing.Point(384, 178);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(95, 28);
            this.lblquantity.TabIndex = 63;
            this.lblquantity.Text = "Quantity";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(171, 141);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(152, 22);
            this.txtname.TabIndex = 65;
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(502, 141);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(152, 22);
            this.txtprice.TabIndex = 66;
            // 
            // txtquantity
            // 
            this.txtquantity.Enabled = false;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(502, 184);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(152, 22);
            this.txtquantity.TabIndex = 67;
            // 
            // cmbequiid
            // 
            this.cmbequiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbequiid.FormattingEnabled = true;
            this.cmbequiid.Location = new System.Drawing.Point(171, 93);
            this.cmbequiid.Name = "cmbequiid";
            this.cmbequiid.Size = new System.Drawing.Size(152, 24);
            this.cmbequiid.TabIndex = 68;
            this.cmbequiid.SelectedIndexChanged += new System.EventHandler(this.cmbequiid_SelectedIndexChanged);
            // 
            // txtequiid
            // 
            this.txtequiid.Enabled = false;
            this.txtequiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtequiid.Location = new System.Drawing.Point(171, 93);
            this.txtequiid.Name = "txtequiid";
            this.txtequiid.Size = new System.Drawing.Size(152, 22);
            this.txtequiid.TabIndex = 64;
            // 
            // lblbillid
            // 
            this.lblbillid.AutoSize = true;
            this.lblbillid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillid.ForeColor = System.Drawing.Color.Navy;
            this.lblbillid.Location = new System.Drawing.Point(26, 48);
            this.lblbillid.Name = "lblbillid";
            this.lblbillid.Size = new System.Drawing.Size(76, 28);
            this.lblbillid.TabIndex = 73;
            this.lblbillid.Text = "Bill_Id";
            // 
            // cmbbillid
            // 
            this.cmbbillid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbillid.FormattingEnabled = true;
            this.cmbbillid.Location = new System.Drawing.Point(172, 54);
            this.cmbbillid.Name = "cmbbillid";
            this.cmbbillid.Size = new System.Drawing.Size(152, 24);
            this.cmbbillid.TabIndex = 75;
            this.cmbbillid.SelectedIndexChanged += new System.EventHandler(this.cmbbillid_SelectedIndexChanged);
            // 
            // txtbillid
            // 
            this.txtbillid.Enabled = false;
            this.txtbillid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillid.Location = new System.Drawing.Point(172, 54);
            this.txtbillid.Name = "txtbillid";
            this.txtbillid.Size = new System.Drawing.Size(152, 22);
            this.txtbillid.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.rdbcheque);
            this.groupBox1.Controls.Add(this.rdbcash);
            this.groupBox1.Controls.Add(this.lblpaidby);
            this.groupBox1.Controls.Add(this.lblbillid);
            this.groupBox1.Controls.Add(this.datetimebilldate);
            this.groupBox1.Controls.Add(this.cmbbillid);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblequiid);
            this.groupBox1.Controls.Add(this.cmbequiid);
            this.groupBox1.Controls.Add(this.lblsuppliername);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtsuppliername);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.lblquantity);
            this.groupBox1.Controls.Add(this.txtbillid);
            this.groupBox1.Controls.Add(this.txtequiid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 352);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Bill";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtaccountno);
            this.panel1.Controls.Add(this.txtbankname);
            this.panel1.Controls.Add(this.txtchequeno);
            this.panel1.Controls.Add(this.lblaccountno);
            this.panel1.Controls.Add(this.lblchequeno);
            this.panel1.Controls.Add(this.txtbranch);
            this.panel1.Controls.Add(this.lblbankname);
            this.panel1.Controls.Add(this.lblbranch);
            this.panel1.Location = new System.Drawing.Point(16, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 87);
            this.panel1.TabIndex = 77;
            // 
            // txtaccountno
            // 
            this.txtaccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccountno.Location = new System.Drawing.Point(485, 56);
            this.txtaccountno.Name = "txtaccountno";
            this.txtaccountno.Size = new System.Drawing.Size(153, 22);
            this.txtaccountno.TabIndex = 8;
            // 
            // txtbankname
            // 
            this.txtbankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankname.Location = new System.Drawing.Point(144, 11);
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.Size = new System.Drawing.Size(149, 22);
            this.txtbankname.TabIndex = 7;
            // 
            // txtchequeno
            // 
            this.txtchequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequeno.Location = new System.Drawing.Point(485, 15);
            this.txtchequeno.Name = "txtchequeno";
            this.txtchequeno.Size = new System.Drawing.Size(153, 22);
            this.txtchequeno.TabIndex = 5;
            // 
            // lblaccountno
            // 
            this.lblaccountno.AutoSize = true;
            this.lblaccountno.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountno.ForeColor = System.Drawing.Color.Navy;
            this.lblaccountno.Location = new System.Drawing.Point(363, 53);
            this.lblaccountno.Name = "lblaccountno";
            this.lblaccountno.Size = new System.Drawing.Size(122, 28);
            this.lblaccountno.TabIndex = 3;
            this.lblaccountno.Text = "Account_No";
            // 
            // lblchequeno
            // 
            this.lblchequeno.AutoSize = true;
            this.lblchequeno.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchequeno.ForeColor = System.Drawing.Color.Navy;
            this.lblchequeno.Location = new System.Drawing.Point(363, 9);
            this.lblchequeno.Name = "lblchequeno";
            this.lblchequeno.Size = new System.Drawing.Size(116, 28);
            this.lblchequeno.TabIndex = 1;
            this.lblchequeno.Text = "Cheque_No";
            // 
            // txtbranch
            // 
            this.txtbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranch.Location = new System.Drawing.Point(144, 56);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(149, 22);
            this.txtbranch.TabIndex = 6;
            // 
            // lblbankname
            // 
            this.lblbankname.AutoSize = true;
            this.lblbankname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbankname.ForeColor = System.Drawing.Color.Navy;
            this.lblbankname.Location = new System.Drawing.Point(13, 9);
            this.lblbankname.Name = "lblbankname";
            this.lblbankname.Size = new System.Drawing.Size(123, 28);
            this.lblbankname.TabIndex = 2;
            this.lblbankname.Text = "Bank_Name";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.ForeColor = System.Drawing.Color.Navy;
            this.lblbranch.Location = new System.Drawing.Point(13, 54);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(78, 28);
            this.lblbranch.TabIndex = 4;
            this.lblbranch.Text = "Branch";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnew.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(339, 54);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(67, 32);
            this.btnnew.TabIndex = 95;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // rdbcheque
            // 
            this.rdbcheque.AutoSize = true;
            this.rdbcheque.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcheque.ForeColor = System.Drawing.Color.Navy;
            this.rdbcheque.Location = new System.Drawing.Point(252, 222);
            this.rdbcheque.Name = "rdbcheque";
            this.rdbcheque.Size = new System.Drawing.Size(98, 32);
            this.rdbcheque.TabIndex = 79;
            this.rdbcheque.TabStop = true;
            this.rdbcheque.Text = "Cheque";
            this.rdbcheque.UseVisualStyleBackColor = true;
            this.rdbcheque.CheckedChanged += new System.EventHandler(this.rdbcheque_CheckedChanged);
            // 
            // rdbcash
            // 
            this.rdbcash.AutoSize = true;
            this.rdbcash.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcash.ForeColor = System.Drawing.Color.Navy;
            this.rdbcash.Location = new System.Drawing.Point(171, 222);
            this.rdbcash.Name = "rdbcash";
            this.rdbcash.Size = new System.Drawing.Size(75, 32);
            this.rdbcash.TabIndex = 78;
            this.rdbcash.TabStop = true;
            this.rdbcash.Text = "Cash";
            this.rdbcash.UseVisualStyleBackColor = true;
            this.rdbcash.CheckedChanged += new System.EventHandler(this.rdbcash_CheckedChanged);
            // 
            // lblpaidby
            // 
            this.lblpaidby.AutoSize = true;
            this.lblpaidby.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidby.ForeColor = System.Drawing.Color.Navy;
            this.lblpaidby.Location = new System.Drawing.Point(25, 224);
            this.lblpaidby.Name = "lblpaidby";
            this.lblpaidby.Size = new System.Drawing.Size(88, 28);
            this.lblpaidby.TabIndex = 76;
            this.lblpaidby.Text = "Paid_By";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbsearchid);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(773, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 123);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbsearchid
            // 
            this.cmbsearchid.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearchid.FormattingEnabled = true;
            this.cmbsearchid.Location = new System.Drawing.Point(25, 32);
            this.cmbsearchid.Name = "cmbsearchid";
            this.cmbsearchid.Size = new System.Drawing.Size(149, 27);
            this.cmbsearchid.TabIndex = 63;
            this.cmbsearchid.SelectedIndexChanged += new System.EventHandler(this.cmbsearchid_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Sitka Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(55, 69);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 35);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(773, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 223);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(64, 87);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 29);
            this.btnupdate.TabIndex = 62;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(64, 39);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 30);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(64, 134);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 30);
            this.btndelete.TabIndex = 60;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(64, 182);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(92, 30);
            this.btnexit.TabIndex = 61;
            this.btnexit.Text = "CANCLE";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // datagridviewpurchasebill
            // 
            this.datagridviewpurchasebill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewpurchasebill.Location = new System.Drawing.Point(37, 457);
            this.datagridviewpurchasebill.Name = "datagridviewpurchasebill";
            this.datagridviewpurchasebill.Size = new System.Drawing.Size(942, 192);
            this.datagridviewpurchasebill.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(768, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Information about Bill";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(1030, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridviewpurchasebill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPurchaseBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPurchaseBill";
            this.Load += new System.EventHandler(this.frmPurchaseBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpurchasebill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimebilldate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblequiid;
        private System.Windows.Forms.Label lblsuppliername;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cmbequiid;
        private System.Windows.Forms.TextBox txtequiid;
        private System.Windows.Forms.Label lblbillid;
        private System.Windows.Forms.ComboBox cmbbillid;
        private System.Windows.Forms.TextBox txtbillid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcheque;
        private System.Windows.Forms.RadioButton rdbcash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtaccountno;
        private System.Windows.Forms.TextBox txtbankname;
        private System.Windows.Forms.TextBox txtchequeno;
        private System.Windows.Forms.Label lblaccountno;
        private System.Windows.Forms.Label lblchequeno;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label lblbankname;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblpaidby;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbsearchid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView datagridviewpurchasebill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}