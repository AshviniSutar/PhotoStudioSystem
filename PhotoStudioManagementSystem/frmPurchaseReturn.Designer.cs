namespace PhotoStudioManagementSystem
{
    partial class frmPurchaseReturn
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
            this.datetimedate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.lblsupplyname = new System.Windows.Forms.Label();
            this.txtreasons = new System.Windows.Forms.TextBox();
            this.lblreasons = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbequiid = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblequiid = new System.Windows.Forms.Label();
            this.txtpurchasereturnid = new System.Windows.Forms.TextBox();
            this.lblpurchasereturnid = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cmbpurchasereturnid = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtequiid = new System.Windows.Forms.TextBox();
            this.datagridviewpurchasereturn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.lblavailable = new System.Windows.Forms.Label();
            this.txtavailable = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpurchasereturn)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimedate
            // 
            this.datetimedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimedate.Location = new System.Drawing.Point(552, 95);
            this.datetimedate.Name = "datetimedate";
            this.datetimedate.Size = new System.Drawing.Size(152, 22);
            this.datetimedate.TabIndex = 102;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(403, 91);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(55, 28);
            this.lbldate.TabIndex = 96;
            this.lbldate.Text = "Date";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Enabled = false;
            this.txtsuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppliername.Location = new System.Drawing.Point(552, 189);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(152, 22);
            this.txtsuppliername.TabIndex = 101;
            // 
            // lblsupplyname
            // 
            this.lblsupplyname.AutoSize = true;
            this.lblsupplyname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplyname.ForeColor = System.Drawing.Color.Navy;
            this.lblsupplyname.Location = new System.Drawing.Point(399, 181);
            this.lblsupplyname.Name = "lblsupplyname";
            this.lblsupplyname.Size = new System.Drawing.Size(156, 28);
            this.lblsupplyname.TabIndex = 92;
            this.lblsupplyname.Text = "Supplier_Name";
            // 
            // txtreasons
            // 
            this.txtreasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreasons.Location = new System.Drawing.Point(229, 232);
            this.txtreasons.Multiline = true;
            this.txtreasons.Name = "txtreasons";
            this.txtreasons.Size = new System.Drawing.Size(152, 91);
            this.txtreasons.TabIndex = 99;
            // 
            // lblreasons
            // 
            this.lblreasons.AutoSize = true;
            this.lblreasons.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreasons.ForeColor = System.Drawing.Color.Navy;
            this.lblreasons.Location = new System.Drawing.Point(22, 226);
            this.lblreasons.Name = "lblreasons";
            this.lblreasons.Size = new System.Drawing.Size(94, 28);
            this.lblreasons.TabIndex = 100;
            this.lblreasons.Text = "Reasons ";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Navy;
            this.lblquantity.Location = new System.Drawing.Point(399, 226);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(99, 28);
            this.lblquantity.TabIndex = 93;
            this.lblquantity.Text = "Damaged";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Navy;
            this.lblname.Location = new System.Drawing.Point(22, 136);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(180, 28);
            this.lblname.TabIndex = 94;
            this.lblname.Text = "Equipment_Name";
            // 
            // cmbequiid
            // 
            this.cmbequiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbequiid.FormattingEnabled = true;
            this.cmbequiid.Location = new System.Drawing.Point(229, 97);
            this.cmbequiid.Name = "cmbequiid";
            this.cmbequiid.Size = new System.Drawing.Size(152, 24);
            this.cmbequiid.TabIndex = 98;
            this.cmbequiid.SelectedIndexChanged += new System.EventHandler(this.cmbequiid_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(229, 142);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(152, 22);
            this.txtname.TabIndex = 95;
            // 
            // lblequiid
            // 
            this.lblequiid.AutoSize = true;
            this.lblequiid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequiid.ForeColor = System.Drawing.Color.Navy;
            this.lblequiid.Location = new System.Drawing.Point(22, 91);
            this.lblequiid.Name = "lblequiid";
            this.lblequiid.Size = new System.Drawing.Size(146, 28);
            this.lblequiid.TabIndex = 91;
            this.lblequiid.Text = "Equipment_Id";
            // 
            // txtpurchasereturnid
            // 
            this.txtpurchasereturnid.Enabled = false;
            this.txtpurchasereturnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurchasereturnid.Location = new System.Drawing.Point(229, 52);
            this.txtpurchasereturnid.Name = "txtpurchasereturnid";
            this.txtpurchasereturnid.Size = new System.Drawing.Size(152, 22);
            this.txtpurchasereturnid.TabIndex = 90;
            // 
            // lblpurchasereturnid
            // 
            this.lblpurchasereturnid.AutoSize = true;
            this.lblpurchasereturnid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurchasereturnid.ForeColor = System.Drawing.Color.Navy;
            this.lblpurchasereturnid.Location = new System.Drawing.Point(22, 46);
            this.lblpurchasereturnid.Name = "lblpurchasereturnid";
            this.lblpurchasereturnid.Size = new System.Drawing.Size(191, 28);
            this.lblpurchasereturnid.TabIndex = 89;
            this.lblpurchasereturnid.Text = "PurchaseReturn_Id";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Navy;
            this.lblprice.Location = new System.Drawing.Point(399, 136);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(59, 28);
            this.lblprice.TabIndex = 103;
            this.lblprice.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(552, 144);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(152, 22);
            this.txtprice.TabIndex = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(780, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 111);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbidsearch
            // 
            this.cmbidsearch.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidsearch.FormattingEnabled = true;
            this.cmbidsearch.Location = new System.Drawing.Point(25, 32);
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
            this.btnsearch.Location = new System.Drawing.Point(50, 64);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 36);
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
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(780, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 242);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(64, 44);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 30);
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
            this.btnupdate.Location = new System.Drawing.Point(64, 92);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 30);
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
            this.btndelete.Location = new System.Drawing.Point(64, 140);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 30);
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
            this.btnexit.Location = new System.Drawing.Point(64, 188);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(91, 30);
            this.btnexit.TabIndex = 61;
            this.btnexit.Text = "CANCLE";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cmbpurchasereturnid
            // 
            this.cmbpurchasereturnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpurchasereturnid.FormattingEnabled = true;
            this.cmbpurchasereturnid.Location = new System.Drawing.Point(229, 52);
            this.cmbpurchasereturnid.Name = "cmbpurchasereturnid";
            this.cmbpurchasereturnid.Size = new System.Drawing.Size(152, 24);
            this.cmbpurchasereturnid.TabIndex = 107;
            this.cmbpurchasereturnid.SelectedIndexChanged += new System.EventHandler(this.cmbpurchasereturnid_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblavailable);
            this.groupBox1.Controls.Add(this.txtavailable);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.lblpurchasereturnid);
            this.groupBox1.Controls.Add(this.lblequiid);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.datetimedate);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblquantity);
            this.groupBox1.Controls.Add(this.txtsuppliername);
            this.groupBox1.Controls.Add(this.lblreasons);
            this.groupBox1.Controls.Add(this.lblsupplyname);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.txtreasons);
            this.groupBox1.Controls.Add(this.cmbpurchasereturnid);
            this.groupBox1.Controls.Add(this.txtpurchasereturnid);
            this.groupBox1.Controls.Add(this.cmbequiid);
            this.groupBox1.Controls.Add(this.txtequiid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 361);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PurchaseReturn_Details";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnew.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(387, 46);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(68, 36);
            this.btnnew.TabIndex = 109;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtequiid
            // 
            this.txtequiid.Enabled = false;
            this.txtequiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtequiid.Location = new System.Drawing.Point(229, 99);
            this.txtequiid.Name = "txtequiid";
            this.txtequiid.Size = new System.Drawing.Size(152, 22);
            this.txtequiid.TabIndex = 108;
            // 
            // datagridviewpurchasereturn
            // 
            this.datagridviewpurchasereturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewpurchasereturn.Location = new System.Drawing.Point(43, 462);
            this.datagridviewpurchasereturn.Name = "datagridviewpurchasereturn";
            this.datagridviewpurchasereturn.Size = new System.Drawing.Size(892, 189);
            this.datagridviewpurchasereturn.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(549, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Information about Purchase Return";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(552, 234);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(152, 22);
            this.txtquantity.TabIndex = 97;
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.ForeColor = System.Drawing.Color.Navy;
            this.lblavailable.Location = new System.Drawing.Point(22, 181);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(198, 28);
            this.lblavailable.TabIndex = 110;
            this.lblavailable.Text = "Available_Quantity ";
            // 
            // txtavailable
            // 
            this.txtavailable.Enabled = false;
            this.txtavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavailable.Location = new System.Drawing.Point(229, 187);
            this.txtavailable.Name = "txtavailable";
            this.txtavailable.Size = new System.Drawing.Size(152, 22);
            this.txtavailable.TabIndex = 111;
            // 
            // frmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(1047, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewpurchasereturn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPurchaseReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPurchaseReturn";
            this.Load += new System.EventHandler(this.frmPurchaseReturn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpurchasereturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimedate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.Label lblsupplyname;
        private System.Windows.Forms.TextBox txtreasons;
        private System.Windows.Forms.Label lblreasons;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbequiid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblequiid;
        private System.Windows.Forms.TextBox txtpurchasereturnid;
        private System.Windows.Forms.Label lblpurchasereturnid;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cmbpurchasereturnid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagridviewpurchasereturn;
        private System.Windows.Forms.TextBox txtequiid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.TextBox txtavailable;
        private System.Windows.Forms.TextBox txtquantity;
    }
}