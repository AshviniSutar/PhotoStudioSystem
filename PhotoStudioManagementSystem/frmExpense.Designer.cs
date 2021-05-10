namespace PhotoStudioManagementSystem
{
    partial class frmExpense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaccountno = new System.Windows.Forms.TextBox();
            this.txtbankname = new System.Windows.Forms.TextBox();
            this.txtchequeno = new System.Windows.Forms.TextBox();
            this.lblaccountno = new System.Windows.Forms.Label();
            this.lblchequeno = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.lblbankname = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.rdbcheque = new System.Windows.Forms.RadioButton();
            this.rdbcash = new System.Windows.Forms.RadioButton();
            this.lblpaidby = new System.Windows.Forms.Label();
            this.lblexpenseid = new System.Windows.Forms.Label();
            this.datetimeexpensedate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.lbldetail = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.cmbexpenseid = new System.Windows.Forms.ComboBox();
            this.txtexpenseid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbsearchid = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.datagridviewexpense = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewexpense)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rdbcheque);
            this.groupBox1.Controls.Add(this.rdbcash);
            this.groupBox1.Controls.Add(this.lblpaidby);
            this.groupBox1.Controls.Add(this.lblexpenseid);
            this.groupBox1.Controls.Add(this.datetimeexpensedate);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.txtdetail);
            this.groupBox1.Controls.Add(this.lbldetail);
            this.groupBox1.Controls.Add(this.lblamount);
            this.groupBox1.Controls.Add(this.cmbexpenseid);
            this.groupBox1.Controls.Add(this.txtexpenseid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(41, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense ";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnew.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(320, 66);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(67, 32);
            this.btnnew.TabIndex = 101;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
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
            this.panel1.Location = new System.Drawing.Point(10, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 87);
            this.panel1.TabIndex = 90;
            // 
            // txtaccountno
            // 
            this.txtaccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccountno.Location = new System.Drawing.Point(464, 56);
            this.txtaccountno.Name = "txtaccountno";
            this.txtaccountno.Size = new System.Drawing.Size(153, 22);
            this.txtaccountno.TabIndex = 8;
            // 
            // txtbankname
            // 
            this.txtbankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankname.Location = new System.Drawing.Point(139, 15);
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.Size = new System.Drawing.Size(149, 22);
            this.txtbankname.TabIndex = 7;
            // 
            // txtchequeno
            // 
            this.txtchequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequeno.Location = new System.Drawing.Point(464, 15);
            this.txtchequeno.Name = "txtchequeno";
            this.txtchequeno.Size = new System.Drawing.Size(153, 22);
            this.txtchequeno.TabIndex = 5;
            // 
            // lblaccountno
            // 
            this.lblaccountno.AutoSize = true;
            this.lblaccountno.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountno.ForeColor = System.Drawing.Color.Navy;
            this.lblaccountno.Location = new System.Drawing.Point(342, 53);
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
            this.lblchequeno.Location = new System.Drawing.Point(342, 9);
            this.lblchequeno.Name = "lblchequeno";
            this.lblchequeno.Size = new System.Drawing.Size(116, 28);
            this.lblchequeno.TabIndex = 1;
            this.lblchequeno.Text = "Cheque_No";
            // 
            // txtbranch
            // 
            this.txtbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranch.Location = new System.Drawing.Point(139, 60);
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
            // rdbcheque
            // 
            this.rdbcheque.AutoSize = true;
            this.rdbcheque.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcheque.ForeColor = System.Drawing.Color.Navy;
            this.rdbcheque.Location = new System.Drawing.Point(230, 192);
            this.rdbcheque.Name = "rdbcheque";
            this.rdbcheque.Size = new System.Drawing.Size(98, 32);
            this.rdbcheque.TabIndex = 92;
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
            this.rdbcash.Location = new System.Drawing.Point(149, 192);
            this.rdbcash.Name = "rdbcash";
            this.rdbcash.Size = new System.Drawing.Size(75, 32);
            this.rdbcash.TabIndex = 91;
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
            this.lblpaidby.Location = new System.Drawing.Point(19, 194);
            this.lblpaidby.Name = "lblpaidby";
            this.lblpaidby.Size = new System.Drawing.Size(88, 28);
            this.lblpaidby.TabIndex = 89;
            this.lblpaidby.Text = "Paid_By";
            // 
            // lblexpenseid
            // 
            this.lblexpenseid.AutoSize = true;
            this.lblexpenseid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenseid.ForeColor = System.Drawing.Color.Navy;
            this.lblexpenseid.Location = new System.Drawing.Point(23, 60);
            this.lblexpenseid.Name = "lblexpenseid";
            this.lblexpenseid.Size = new System.Drawing.Size(120, 28);
            this.lblexpenseid.TabIndex = 86;
            this.lblexpenseid.Text = "Expense_Id";
            // 
            // datetimeexpensedate
            // 
            this.datetimeexpensedate.CalendarFont = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeexpensedate.Checked = false;
            this.datetimeexpensedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeexpensedate.Location = new System.Drawing.Point(483, 100);
            this.datetimeexpensedate.Name = "datetimeexpensedate";
            this.datetimeexpensedate.Size = new System.Drawing.Size(152, 22);
            this.datetimeexpensedate.TabIndex = 85;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(381, 96);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(55, 28);
            this.lbldate.TabIndex = 84;
            this.lbldate.Text = "Date";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(482, 152);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(152, 22);
            this.txtamount.TabIndex = 83;
            // 
            // txtdetail
            // 
            this.txtdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetail.Location = new System.Drawing.Point(149, 96);
            this.txtdetail.Multiline = true;
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(165, 90);
            this.txtdetail.TabIndex = 82;
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetail.ForeColor = System.Drawing.Color.Navy;
            this.lbldetail.Location = new System.Drawing.Point(24, 110);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(69, 28);
            this.lbldetail.TabIndex = 80;
            this.lbldetail.Text = "Detail";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.Color.Navy;
            this.lblamount.Location = new System.Drawing.Point(381, 146);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(86, 28);
            this.lblamount.TabIndex = 81;
            this.lblamount.Text = "Amount";
            // 
            // cmbexpenseid
            // 
            this.cmbexpenseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbexpenseid.FormattingEnabled = true;
            this.cmbexpenseid.Location = new System.Drawing.Point(149, 66);
            this.cmbexpenseid.Name = "cmbexpenseid";
            this.cmbexpenseid.Size = new System.Drawing.Size(165, 24);
            this.cmbexpenseid.TabIndex = 88;
            this.cmbexpenseid.SelectedIndexChanged += new System.EventHandler(this.cmbexpenseid_SelectedIndexChanged);
            // 
            // txtexpenseid
            // 
            this.txtexpenseid.Enabled = false;
            this.txtexpenseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpenseid.Location = new System.Drawing.Point(149, 66);
            this.txtexpenseid.Name = "txtexpenseid";
            this.txtexpenseid.Size = new System.Drawing.Size(165, 22);
            this.txtexpenseid.TabIndex = 87;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbsearchid);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(753, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 123);
            this.groupBox2.TabIndex = 98;
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
            this.groupBox3.Location = new System.Drawing.Point(753, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 223);
            this.groupBox3.TabIndex = 99;
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
            // datagridviewexpense
            // 
            this.datagridviewexpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewexpense.Location = new System.Drawing.Point(41, 442);
            this.datagridviewexpense.Name = "datagridviewexpense";
            this.datagridviewexpense.Size = new System.Drawing.Size(918, 192);
            this.datagridviewexpense.TabIndex = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(685, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 101;
            this.label1.Text = "Information about Expense";
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(990, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewexpense);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmExpence";
            this.Load += new System.EventHandler(this.frmExpence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewexpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtaccountno;
        private System.Windows.Forms.TextBox txtbankname;
        private System.Windows.Forms.TextBox txtchequeno;
        private System.Windows.Forms.Label lblaccountno;
        private System.Windows.Forms.Label lblchequeno;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label lblbankname;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.RadioButton rdbcheque;
        private System.Windows.Forms.RadioButton rdbcash;
        private System.Windows.Forms.Label lblpaidby;
        private System.Windows.Forms.Label lblexpenseid;
        private System.Windows.Forms.DateTimePicker datetimeexpensedate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.ComboBox cmbexpenseid;
        private System.Windows.Forms.TextBox txtexpenseid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbsearchid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView datagridviewexpense;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}