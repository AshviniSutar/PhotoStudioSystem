namespace PhotoStudioManagementSystem
{
    partial class frmVisit
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
            this.cmbvisitid = new System.Windows.Forms.ComboBox();
            this.datagridviewvisit = new System.Windows.Forms.DataGridView();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.lblvisitplace = new System.Windows.Forms.Label();
            this.datetimevisitdate = new System.Windows.Forms.DateTimePicker();
            this.lblvisitdate = new System.Windows.Forms.Label();
            this.txtadvance = new System.Windows.Forms.TextBox();
            this.lbladvance = new System.Windows.Forms.Label();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.lblcatname = new System.Windows.Forms.Label();
            this.txtvisitplace = new System.Windows.Forms.TextBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblbookingid = new System.Windows.Forms.Label();
            this.cmbempid = new System.Windows.Forms.ComboBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.txtvisitid = new System.Windows.Forms.TextBox();
            this.lblvisitid = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvisitdays = new System.Windows.Forms.TextBox();
            this.lblvisitdays = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewvisit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbookid
            // 
            this.cmbbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbookid.FormattingEnabled = true;
            this.cmbbookid.Location = new System.Drawing.Point(470, 100);
            this.cmbbookid.Name = "cmbbookid";
            this.cmbbookid.Size = new System.Drawing.Size(152, 24);
            this.cmbbookid.TabIndex = 99;
            this.cmbbookid.SelectedIndexChanged += new System.EventHandler(this.cmbbookid_SelectedIndexChanged);
            // 
            // cmbvisitid
            // 
            this.cmbvisitid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvisitid.FormattingEnabled = true;
            this.cmbvisitid.Location = new System.Drawing.Point(179, 54);
            this.cmbvisitid.Name = "cmbvisitid";
            this.cmbvisitid.Size = new System.Drawing.Size(152, 24);
            this.cmbvisitid.TabIndex = 98;
            this.cmbvisitid.SelectedIndexChanged += new System.EventHandler(this.cmbvisitid_SelectedIndexChanged);
            // 
            // datagridviewvisit
            // 
            this.datagridviewvisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewvisit.Location = new System.Drawing.Point(32, 465);
            this.datagridviewvisit.Name = "datagridviewvisit";
            this.datagridviewvisit.Size = new System.Drawing.Size(892, 208);
            this.datagridviewvisit.TabIndex = 97;
            // 
            // txtcustname
            // 
            this.txtcustname.Enabled = false;
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(470, 148);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(152, 22);
            this.txtcustname.TabIndex = 89;
            // 
            // lblvisitplace
            // 
            this.lblvisitplace.AutoSize = true;
            this.lblvisitplace.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitplace.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitplace.Location = new System.Drawing.Point(31, 228);
            this.lblvisitplace.Name = "lblvisitplace";
            this.lblvisitplace.Size = new System.Drawing.Size(99, 23);
            this.lblvisitplace.TabIndex = 88;
            this.lblvisitplace.Text = "Visit_Place";
            // 
            // datetimevisitdate
            // 
            this.datetimevisitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimevisitdate.Location = new System.Drawing.Point(470, 190);
            this.datetimevisitdate.Name = "datetimevisitdate";
            this.datetimevisitdate.Size = new System.Drawing.Size(152, 22);
            this.datetimevisitdate.TabIndex = 87;
            // 
            // lblvisitdate
            // 
            this.lblvisitdate.AutoSize = true;
            this.lblvisitdate.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitdate.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitdate.Location = new System.Drawing.Point(364, 190);
            this.lblvisitdate.Name = "lblvisitdate";
            this.lblvisitdate.Size = new System.Drawing.Size(94, 23);
            this.lblvisitdate.TabIndex = 86;
            this.lblvisitdate.Text = "Visit_Date";
            // 
            // txtadvance
            // 
            this.txtadvance.Enabled = false;
            this.txtadvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvance.Location = new System.Drawing.Point(470, 237);
            this.txtadvance.Name = "txtadvance";
            this.txtadvance.Size = new System.Drawing.Size(152, 22);
            this.txtadvance.TabIndex = 85;
            // 
            // lbladvance
            // 
            this.lbladvance.AutoSize = true;
            this.lbladvance.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvance.ForeColor = System.Drawing.Color.Navy;
            this.lbladvance.Location = new System.Drawing.Point(364, 236);
            this.lbladvance.Name = "lbladvance";
            this.lbladvance.Size = new System.Drawing.Size(76, 23);
            this.lbladvance.TabIndex = 84;
            this.lbladvance.Text = "Advance";
            // 
            // txtcatname
            // 
            this.txtcatname.Enabled = false;
            this.txtcatname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatname.Location = new System.Drawing.Point(179, 186);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(152, 22);
            this.txtcatname.TabIndex = 83;
            // 
            // lblcatname
            // 
            this.lblcatname.AutoSize = true;
            this.lblcatname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatname.ForeColor = System.Drawing.Color.Navy;
            this.lblcatname.Location = new System.Drawing.Point(31, 184);
            this.lblcatname.Name = "lblcatname";
            this.lblcatname.Size = new System.Drawing.Size(134, 23);
            this.lblcatname.TabIndex = 82;
            this.lblcatname.Text = "Category_Name";
            // 
            // txtvisitplace
            // 
            this.txtvisitplace.Enabled = false;
            this.txtvisitplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitplace.Location = new System.Drawing.Point(179, 230);
            this.txtvisitplace.Name = "txtvisitplace";
            this.txtvisitplace.Size = new System.Drawing.Size(152, 22);
            this.txtvisitplace.TabIndex = 81;
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Navy;
            this.lblcustname.Location = new System.Drawing.Point(364, 144);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(99, 23);
            this.lblcustname.TabIndex = 80;
            this.lblcustname.Text = "Cust_Name";
            // 
            // lblbookingid
            // 
            this.lblbookingid.AutoSize = true;
            this.lblbookingid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingid.ForeColor = System.Drawing.Color.Navy;
            this.lblbookingid.Location = new System.Drawing.Point(364, 98);
            this.lblbookingid.Name = "lblbookingid";
            this.lblbookingid.Size = new System.Drawing.Size(100, 23);
            this.lblbookingid.TabIndex = 79;
            this.lblbookingid.Text = "Booking_Id";
            // 
            // cmbempid
            // 
            this.cmbempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbempid.FormattingEnabled = true;
            this.cmbempid.Location = new System.Drawing.Point(179, 95);
            this.cmbempid.Name = "cmbempid";
            this.cmbempid.Size = new System.Drawing.Size(152, 24);
            this.cmbempid.TabIndex = 78;
            this.cmbempid.SelectedIndexChanged += new System.EventHandler(this.cmbempid_SelectedIndexChanged);
            // 
            // txtempname
            // 
            this.txtempname.Enabled = false;
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(179, 142);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(152, 22);
            this.txtempname.TabIndex = 77;
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.ForeColor = System.Drawing.Color.Navy;
            this.lblempname.Location = new System.Drawing.Point(31, 140);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(142, 23);
            this.lblempname.TabIndex = 76;
            this.lblempname.Text = "Employee_Name";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.ForeColor = System.Drawing.Color.Navy;
            this.lblempid.Location = new System.Drawing.Point(31, 96);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(114, 23);
            this.lblempid.TabIndex = 75;
            this.lblempid.Text = "Employee_Id";
            // 
            // txtvisitid
            // 
            this.txtvisitid.Enabled = false;
            this.txtvisitid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitid.Location = new System.Drawing.Point(179, 54);
            this.txtvisitid.Name = "txtvisitid";
            this.txtvisitid.Size = new System.Drawing.Size(152, 22);
            this.txtvisitid.TabIndex = 74;
            // 
            // lblvisitid
            // 
            this.lblvisitid.AutoSize = true;
            this.lblvisitid.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitid.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitid.Location = new System.Drawing.Point(31, 52);
            this.lblvisitid.Name = "lblvisitid";
            this.lblvisitid.Size = new System.Drawing.Size(74, 23);
            this.lblvisitid.TabIndex = 73;
            this.lblvisitid.Text = "Visit_Id";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnew.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(347, 48);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(74, 31);
            this.btnnew.TabIndex = 100;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(732, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 112);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbidsearch
            // 
            this.cmbidsearch.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidsearch.FormattingEnabled = true;
            this.cmbidsearch.Location = new System.Drawing.Point(20, 32);
            this.cmbidsearch.Name = "cmbidsearch";
            this.cmbidsearch.Size = new System.Drawing.Size(149, 26);
            this.cmbidsearch.TabIndex = 63;
            this.cmbidsearch.SelectedIndexChanged += new System.EventHandler(this.cmbidsearch_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(38, 64);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 33);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(732, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 222);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(59, 30);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 30);
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
            this.btnupdate.Location = new System.Drawing.Point(59, 78);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 30);
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
            this.btndelete.Location = new System.Drawing.Point(59, 126);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 30);
            this.btndelete.TabIndex = 60;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnclear.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(59, 176);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 31);
            this.btnclear.TabIndex = 61;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtvisitdays);
            this.groupBox1.Controls.Add(this.lblvisitdays);
            this.groupBox1.Controls.Add(this.lblvisitid);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.lblempid);
            this.groupBox1.Controls.Add(this.lblempname);
            this.groupBox1.Controls.Add(this.txtempname);
            this.groupBox1.Controls.Add(this.txtcustname);
            this.groupBox1.Controls.Add(this.lblbookingid);
            this.groupBox1.Controls.Add(this.lblvisitplace);
            this.groupBox1.Controls.Add(this.lblcustname);
            this.groupBox1.Controls.Add(this.datetimevisitdate);
            this.groupBox1.Controls.Add(this.txtvisitplace);
            this.groupBox1.Controls.Add(this.lblvisitdate);
            this.groupBox1.Controls.Add(this.lblcatname);
            this.groupBox1.Controls.Add(this.txtadvance);
            this.groupBox1.Controls.Add(this.txtcatname);
            this.groupBox1.Controls.Add(this.lbladvance);
            this.groupBox1.Controls.Add(this.cmbvisitid);
            this.groupBox1.Controls.Add(this.txtvisitid);
            this.groupBox1.Controls.Add(this.cmbempid);
            this.groupBox1.Controls.Add(this.txtempid);
            this.groupBox1.Controls.Add(this.cmbbookid);
            this.groupBox1.Controls.Add(this.txtbookid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 343);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit Details";
            // 
            // txtvisitdays
            // 
            this.txtvisitdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitdays.Location = new System.Drawing.Point(179, 274);
            this.txtvisitdays.Name = "txtvisitdays";
            this.txtvisitdays.Size = new System.Drawing.Size(152, 22);
            this.txtvisitdays.TabIndex = 104;
            this.txtvisitdays.Validating += new System.ComponentModel.CancelEventHandler(this.txtvisitdays_Validating);
            // 
            // lblvisitdays
            // 
            this.lblvisitdays.AutoSize = true;
            this.lblvisitdays.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitdays.ForeColor = System.Drawing.Color.Navy;
            this.lblvisitdays.Location = new System.Drawing.Point(31, 272);
            this.lblvisitdays.Name = "lblvisitdays";
            this.lblvisitdays.Size = new System.Drawing.Size(95, 23);
            this.lblvisitdays.TabIndex = 103;
            this.lblvisitdays.Text = "Visit_Days";
            // 
            // txtempid
            // 
            this.txtempid.Enabled = false;
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(179, 97);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(152, 22);
            this.txtempid.TabIndex = 101;
            // 
            // txtbookid
            // 
            this.txtbookid.Enabled = false;
            this.txtbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookid.Location = new System.Drawing.Point(470, 102);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(152, 22);
            this.txtbookid.TabIndex = 102;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(706, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 103;
            this.label1.Text = "Information about Visit";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(959, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.datagridviewvisit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVisit";
            this.Load += new System.EventHandler(this.frmVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewvisit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbookid;
        private System.Windows.Forms.ComboBox cmbvisitid;
        private System.Windows.Forms.DataGridView datagridviewvisit;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label lblvisitplace;
        private System.Windows.Forms.DateTimePicker datetimevisitdate;
        private System.Windows.Forms.Label lblvisitdate;
        private System.Windows.Forms.TextBox txtadvance;
        private System.Windows.Forms.Label lbladvance;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.Label lblcatname;
        private System.Windows.Forms.TextBox txtvisitplace;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblbookingid;
        private System.Windows.Forms.ComboBox cmbempid;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.TextBox txtvisitid;
        private System.Windows.Forms.Label lblvisitid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtvisitdays;
        private System.Windows.Forms.Label lblvisitdays;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}