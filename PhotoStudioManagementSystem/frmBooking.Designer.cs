namespace PhotoStudioManagementSystem
{
    partial class frmBooking
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
            this.cmbbookid = new System.Windows.Forms.ComboBox();
            this.txtvisitplace = new System.Windows.Forms.TextBox();
            this.lblvisitplace = new System.Windows.Forms.Label();
            this.datetimevisitdate = new System.Windows.Forms.DateTimePicker();
            this.lblvisitdate = new System.Windows.Forms.Label();
            this.txtadvance = new System.Windows.Forms.TextBox();
            this.lbladvance = new System.Windows.Forms.Label();
            this.datetimebookdate = new System.Windows.Forms.DateTimePicker();
            this.lblbookdate = new System.Windows.Forms.Label();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.cmbcatid = new System.Windows.Forms.ComboBox();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.lblcatname = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblcatid = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.lblbookid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaccountno = new System.Windows.Forms.TextBox();
            this.lblchequeno = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.lblbankname = new System.Windows.Forms.Label();
            this.txtchequeno = new System.Windows.Forms.TextBox();
            this.lblaccountno = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.txtbankname = new System.Windows.Forms.TextBox();
            this.rdbcash = new System.Windows.Forms.RadioButton();
            this.rdbcheque = new System.Windows.Forms.RadioButton();
            this.lblpaidby = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtcatid = new System.Windows.Forms.TextBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.datagridviewbook = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbookid
            // 
            this.cmbbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbookid.FormattingEnabled = true;
            this.cmbbookid.Location = new System.Drawing.Point(163, 46);
            this.cmbbookid.Name = "cmbbookid";
            this.cmbbookid.Size = new System.Drawing.Size(157, 24);
            this.cmbbookid.TabIndex = 98;
            this.cmbbookid.SelectedIndexChanged += new System.EventHandler(this.cmbbookid_SelectedIndexChanged);
            // 
            // txtvisitplace
            // 
            this.txtvisitplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitplace.Location = new System.Drawing.Point(163, 232);
            this.txtvisitplace.Name = "txtvisitplace";
            this.txtvisitplace.Size = new System.Drawing.Size(157, 22);
            this.txtvisitplace.TabIndex = 89;
            this.txtvisitplace.Validating += new System.ComponentModel.CancelEventHandler(this.txtvisitplace_Validating);
            // 
            // lblvisitplace
            // 
            this.lblvisitplace.AutoSize = true;
            this.lblvisitplace.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitplace.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitplace.Location = new System.Drawing.Point(27, 230);
            this.lblvisitplace.Name = "lblvisitplace";
            this.lblvisitplace.Size = new System.Drawing.Size(99, 23);
            this.lblvisitplace.TabIndex = 88;
            this.lblvisitplace.Text = "Visit_Place";
            // 
            // datetimevisitdate
            // 
            this.datetimevisitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimevisitdate.Location = new System.Drawing.Point(452, 188);
            this.datetimevisitdate.Name = "datetimevisitdate";
            this.datetimevisitdate.Size = new System.Drawing.Size(152, 22);
            this.datetimevisitdate.TabIndex = 87;
            // 
            // lblvisitdate
            // 
            this.lblvisitdate.AutoSize = true;
            this.lblvisitdate.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitdate.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitdate.Location = new System.Drawing.Point(351, 188);
            this.lblvisitdate.Name = "lblvisitdate";
            this.lblvisitdate.Size = new System.Drawing.Size(94, 23);
            this.lblvisitdate.TabIndex = 86;
            this.lblvisitdate.Text = "Visit_Date";
            // 
            // txtadvance
            // 
            this.txtadvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvance.Location = new System.Drawing.Point(452, 238);
            this.txtadvance.Name = "txtadvance";
            this.txtadvance.Size = new System.Drawing.Size(152, 22);
            this.txtadvance.TabIndex = 85;
            this.txtadvance.Validating += new System.ComponentModel.CancelEventHandler(this.txtadvance_Validating);
            // 
            // lbladvance
            // 
            this.lbladvance.AutoSize = true;
            this.lbladvance.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvance.ForeColor = System.Drawing.Color.Navy;
            this.lbladvance.Location = new System.Drawing.Point(351, 235);
            this.lbladvance.Name = "lbladvance";
            this.lbladvance.Size = new System.Drawing.Size(76, 23);
            this.lbladvance.TabIndex = 84;
            this.lbladvance.Text = "Advance";
            // 
            // datetimebookdate
            // 
            this.datetimebookdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimebookdate.Location = new System.Drawing.Point(163, 186);
            this.datetimebookdate.Name = "datetimebookdate";
            this.datetimebookdate.Size = new System.Drawing.Size(157, 22);
            this.datetimebookdate.TabIndex = 83;
            // 
            // lblbookdate
            // 
            this.lblbookdate.AutoSize = true;
            this.lblbookdate.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookdate.ForeColor = System.Drawing.Color.Navy;
            this.lblbookdate.Location = new System.Drawing.Point(27, 184);
            this.lblbookdate.Name = "lblbookdate";
            this.lblbookdate.Size = new System.Drawing.Size(120, 23);
            this.lblbookdate.TabIndex = 82;
            this.lblbookdate.Text = "Booking_Date";
            // 
            // cmbcustid
            // 
            this.cmbcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(452, 93);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(152, 24);
            this.cmbcustid.TabIndex = 81;
            this.cmbcustid.SelectedIndexChanged += new System.EventHandler(this.cmbcustid_SelectedIndexChanged);
            // 
            // cmbcatid
            // 
            this.cmbcatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcatid.FormattingEnabled = true;
            this.cmbcatid.Location = new System.Drawing.Point(163, 92);
            this.cmbcatid.Name = "cmbcatid";
            this.cmbcatid.Size = new System.Drawing.Size(157, 24);
            this.cmbcatid.TabIndex = 80;
            this.cmbcatid.SelectedIndexChanged += new System.EventHandler(this.cmbcatid_SelectedIndexChanged);
            // 
            // txtcatname
            // 
            this.txtcatname.BackColor = System.Drawing.SystemColors.Window;
            this.txtcatname.Enabled = false;
            this.txtcatname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatname.Location = new System.Drawing.Point(163, 140);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(157, 22);
            this.txtcatname.TabIndex = 79;
            // 
            // lblcatname
            // 
            this.lblcatname.AutoSize = true;
            this.lblcatname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatname.ForeColor = System.Drawing.Color.Navy;
            this.lblcatname.Location = new System.Drawing.Point(27, 138);
            this.lblcatname.Name = "lblcatname";
            this.lblcatname.Size = new System.Drawing.Size(134, 23);
            this.lblcatname.TabIndex = 78;
            this.lblcatname.Text = "Category_Name";
            // 
            // txtcustname
            // 
            this.txtcustname.BackColor = System.Drawing.SystemColors.Window;
            this.txtcustname.Enabled = false;
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcustname.Location = new System.Drawing.Point(452, 141);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(152, 22);
            this.txtcustname.TabIndex = 77;
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Navy;
            this.lblcustname.Location = new System.Drawing.Point(351, 141);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(99, 23);
            this.lblcustname.TabIndex = 76;
            this.lblcustname.Text = "Cust_Name";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Navy;
            this.lblcustid.Location = new System.Drawing.Point(351, 94);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(71, 23);
            this.lblcustid.TabIndex = 75;
            this.lblcustid.Text = "Cust_Id";
            // 
            // lblcatid
            // 
            this.lblcatid.AutoSize = true;
            this.lblcatid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatid.ForeColor = System.Drawing.Color.Navy;
            this.lblcatid.Location = new System.Drawing.Point(27, 92);
            this.lblcatid.Name = "lblcatid";
            this.lblcatid.Size = new System.Drawing.Size(106, 23);
            this.lblcatid.TabIndex = 74;
            this.lblcatid.Text = "Category_Id";
            // 
            // txtbookid
            // 
            this.txtbookid.Enabled = false;
            this.txtbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookid.Location = new System.Drawing.Point(163, 46);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(157, 22);
            this.txtbookid.TabIndex = 73;
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookid.ForeColor = System.Drawing.Color.Navy;
            this.lblbookid.Location = new System.Drawing.Point(27, 46);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(100, 23);
            this.lblbookid.TabIndex = 72;
            this.lblbookid.Text = "Booking_Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rdbcash);
            this.groupBox1.Controls.Add(this.rdbcheque);
            this.groupBox1.Controls.Add(this.lblpaidby);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.lblbookid);
            this.groupBox1.Controls.Add(this.lblcatid);
            this.groupBox1.Controls.Add(this.lblcustid);
            this.groupBox1.Controls.Add(this.lblcustname);
            this.groupBox1.Controls.Add(this.txtcustname);
            this.groupBox1.Controls.Add(this.txtvisitplace);
            this.groupBox1.Controls.Add(this.lblcatname);
            this.groupBox1.Controls.Add(this.lblvisitplace);
            this.groupBox1.Controls.Add(this.txtcatname);
            this.groupBox1.Controls.Add(this.datetimevisitdate);
            this.groupBox1.Controls.Add(this.lblvisitdate);
            this.groupBox1.Controls.Add(this.txtadvance);
            this.groupBox1.Controls.Add(this.lblbookdate);
            this.groupBox1.Controls.Add(this.lbladvance);
            this.groupBox1.Controls.Add(this.datetimebookdate);
            this.groupBox1.Controls.Add(this.cmbbookid);
            this.groupBox1.Controls.Add(this.txtbookid);
            this.groupBox1.Controls.Add(this.cmbcatid);
            this.groupBox1.Controls.Add(this.txtcatid);
            this.groupBox1.Controls.Add(this.cmbcustid);
            this.groupBox1.Controls.Add(this.txtcustid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 389);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtaccountno);
            this.panel1.Controls.Add(this.lblchequeno);
            this.panel1.Controls.Add(this.txtbranch);
            this.panel1.Controls.Add(this.lblbankname);
            this.panel1.Controls.Add(this.txtchequeno);
            this.panel1.Controls.Add(this.lblaccountno);
            this.panel1.Controls.Add(this.lblbranch);
            this.panel1.Controls.Add(this.txtbankname);
            this.panel1.Location = new System.Drawing.Point(15, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 78);
            this.panel1.TabIndex = 189;
            // 
            // txtaccountno
            // 
            this.txtaccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccountno.Location = new System.Drawing.Point(431, 46);
            this.txtaccountno.Name = "txtaccountno";
            this.txtaccountno.Size = new System.Drawing.Size(158, 22);
            this.txtaccountno.TabIndex = 106;
            // 
            // lblchequeno
            // 
            this.lblchequeno.AutoSize = true;
            this.lblchequeno.BackColor = System.Drawing.Color.Transparent;
            this.lblchequeno.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchequeno.ForeColor = System.Drawing.Color.Navy;
            this.lblchequeno.Location = new System.Drawing.Point(330, 10);
            this.lblchequeno.Name = "lblchequeno";
            this.lblchequeno.Size = new System.Drawing.Size(98, 23);
            this.lblchequeno.TabIndex = 186;
            this.lblchequeno.Text = "Cheque_No";
            // 
            // txtbranch
            // 
            this.txtbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranch.Location = new System.Drawing.Point(146, 45);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(159, 22);
            this.txtbranch.TabIndex = 105;
            // 
            // lblbankname
            // 
            this.lblbankname.AutoSize = true;
            this.lblbankname.BackColor = System.Drawing.Color.Transparent;
            this.lblbankname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbankname.ForeColor = System.Drawing.Color.Navy;
            this.lblbankname.Location = new System.Drawing.Point(6, 10);
            this.lblbankname.Name = "lblbankname";
            this.lblbankname.Size = new System.Drawing.Size(104, 23);
            this.lblbankname.TabIndex = 183;
            this.lblbankname.Text = "Bank_Name";
            // 
            // txtchequeno
            // 
            this.txtchequeno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtchequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequeno.Location = new System.Drawing.Point(431, 14);
            this.txtchequeno.Name = "txtchequeno";
            this.txtchequeno.Size = new System.Drawing.Size(158, 22);
            this.txtchequeno.TabIndex = 184;
            // 
            // lblaccountno
            // 
            this.lblaccountno.AutoSize = true;
            this.lblaccountno.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountno.ForeColor = System.Drawing.Color.Navy;
            this.lblaccountno.Location = new System.Drawing.Point(330, 45);
            this.lblaccountno.Name = "lblaccountno";
            this.lblaccountno.Size = new System.Drawing.Size(103, 23);
            this.lblaccountno.TabIndex = 103;
            this.lblaccountno.Text = "Account_No";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.ForeColor = System.Drawing.Color.Navy;
            this.lblbranch.Location = new System.Drawing.Point(6, 44);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(66, 23);
            this.lblbranch.TabIndex = 104;
            this.lblbranch.Text = "Branch";
            // 
            // txtbankname
            // 
            this.txtbankname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankname.Location = new System.Drawing.Point(146, 14);
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.Size = new System.Drawing.Size(159, 22);
            this.txtbankname.TabIndex = 181;
            // 
            // rdbcash
            // 
            this.rdbcash.AutoSize = true;
            this.rdbcash.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcash.ForeColor = System.Drawing.Color.Navy;
            this.rdbcash.Location = new System.Drawing.Point(255, 272);
            this.rdbcash.Name = "rdbcash";
            this.rdbcash.Size = new System.Drawing.Size(65, 27);
            this.rdbcash.TabIndex = 107;
            this.rdbcash.TabStop = true;
            this.rdbcash.Text = "Cash";
            this.rdbcash.UseVisualStyleBackColor = true;
            this.rdbcash.CheckedChanged += new System.EventHandler(this.rdbcash_CheckedChanged);
            // 
            // rdbcheque
            // 
            this.rdbcheque.AutoSize = true;
            this.rdbcheque.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcheque.ForeColor = System.Drawing.Color.Navy;
            this.rdbcheque.Location = new System.Drawing.Point(163, 272);
            this.rdbcheque.Name = "rdbcheque";
            this.rdbcheque.Size = new System.Drawing.Size(86, 27);
            this.rdbcheque.TabIndex = 106;
            this.rdbcheque.TabStop = true;
            this.rdbcheque.Text = "Cheque";
            this.rdbcheque.UseVisualStyleBackColor = true;
            this.rdbcheque.CheckedChanged += new System.EventHandler(this.rdbcheque_CheckedChanged);
            // 
            // lblpaidby
            // 
            this.lblpaidby.AutoSize = true;
            this.lblpaidby.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidby.ForeColor = System.Drawing.Color.Navy;
            this.lblpaidby.Location = new System.Drawing.Point(27, 276);
            this.lblpaidby.Name = "lblpaidby";
            this.lblpaidby.Size = new System.Drawing.Size(74, 23);
            this.lblpaidby.TabIndex = 105;
            this.lblpaidby.Text = "Paid_By";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnew.Font = new System.Drawing.Font("Sitka Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(333, 46);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(71, 27);
            this.btnnew.TabIndex = 102;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtcatid
            // 
            this.txtcatid.Enabled = false;
            this.txtcatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatid.Location = new System.Drawing.Point(163, 92);
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.Size = new System.Drawing.Size(157, 22);
            this.txtcatid.TabIndex = 103;
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(452, 93);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(152, 22);
            this.txtcustid.TabIndex = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(695, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 114);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbidsearch
            // 
            this.cmbidsearch.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidsearch.FormattingEnabled = true;
            this.cmbidsearch.Location = new System.Drawing.Point(25, 32);
            this.cmbidsearch.Name = "cmbidsearch";
            this.cmbidsearch.Size = new System.Drawing.Size(149, 27);
            this.cmbidsearch.TabIndex = 63;
            this.cmbidsearch.SelectedIndexChanged += new System.EventHandler(this.cmbidsearch_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Sitka Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(64, 69);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(110, 29);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btncancle);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(695, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 264);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncancle.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(64, 203);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(88, 30);
            this.btncancle.TabIndex = 62;
            this.btncancle.Text = "CANCLE";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(64, 61);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(88, 30);
            this.btnsave.TabIndex = 58;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(64, 109);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 30);
            this.btnupdate.TabIndex = 59;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(64, 157);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 30);
            this.btndelete.TabIndex = 60;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // datagridviewbook
            // 
            this.datagridviewbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewbook.Location = new System.Drawing.Point(2, 460);
            this.datagridviewbook.Name = "datagridviewbook";
            this.datagridviewbook.Size = new System.Drawing.Size(922, 183);
            this.datagridviewbook.TabIndex = 102;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(626, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 103;
            this.label1.Text = "Information about Booking";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewbook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbookid;
        private System.Windows.Forms.TextBox txtvisitplace;
        private System.Windows.Forms.Label lblvisitplace;
        private System.Windows.Forms.DateTimePicker datetimevisitdate;
        private System.Windows.Forms.Label lblvisitdate;
        private System.Windows.Forms.TextBox txtadvance;
        private System.Windows.Forms.Label lbladvance;
        private System.Windows.Forms.DateTimePicker datetimebookdate;
        private System.Windows.Forms.Label lblbookdate;
        private System.Windows.Forms.ComboBox cmbcustid;
        private System.Windows.Forms.ComboBox cmbcatid;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.Label lblcatname;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblcatid;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox txtcatid;
        private System.Windows.Forms.RadioButton rdbcash;
        private System.Windows.Forms.RadioButton rdbcheque;
        private System.Windows.Forms.Label lblpaidby;
        private System.Windows.Forms.Label lblbankname;
        private System.Windows.Forms.TextBox txtbankname;
        private System.Windows.Forms.Label lblchequeno;
        private System.Windows.Forms.TextBox txtchequeno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridviewbook;
        private System.Windows.Forms.TextBox txtaccountno;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label lblaccountno;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}