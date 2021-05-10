namespace PhotoStudioManagementSystem
{
    partial class frmPhotoreturn
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
            this.datetimedeliverydate = new System.Windows.Forms.DateTimePicker();
            this.lbldeliverydate = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.lblcutname = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblphotoid = new System.Windows.Forms.Label();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.cmbreturnid = new System.Windows.Forms.ComboBox();
            this.lblreturnid = new System.Windows.Forms.Label();
            this.txtphotoid = new System.Windows.Forms.TextBox();
            this.btnnewreturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtreturnid = new System.Windows.Forms.TextBox();
            this.datagridviewreturnphoto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewreturnphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimedeliverydate
            // 
            this.datetimedeliverydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimedeliverydate.Location = new System.Drawing.Point(176, 222);
            this.datetimedeliverydate.Name = "datetimedeliverydate";
            this.datetimedeliverydate.Size = new System.Drawing.Size(155, 22);
            this.datetimedeliverydate.TabIndex = 76;
            // 
            // lbldeliverydate
            // 
            this.lbldeliverydate.AutoSize = true;
            this.lbldeliverydate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeliverydate.ForeColor = System.Drawing.Color.Navy;
            this.lbldeliverydate.Location = new System.Drawing.Point(27, 218);
            this.lbldeliverydate.Name = "lbldeliverydate";
            this.lbldeliverydate.Size = new System.Drawing.Size(144, 28);
            this.lbldeliverydate.TabIndex = 75;
            this.lbldeliverydate.Text = "Delivery_Date";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Enabled = false;
            this.txttotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.ForeColor = System.Drawing.Color.Black;
            this.txttotalprice.Location = new System.Drawing.Point(175, 264);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(156, 22);
            this.txttotalprice.TabIndex = 82;
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Navy;
            this.lbltotalprice.Location = new System.Drawing.Point(27, 258);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(118, 28);
            this.lbltotalprice.TabIndex = 81;
            this.lbltotalprice.Text = "Total_Price";
            // 
            // txtcname
            // 
            this.txtcname.Enabled = false;
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(175, 140);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(156, 22);
            this.txtcname.TabIndex = 80;
            // 
            // lblcutname
            // 
            this.lblcutname.AutoSize = true;
            this.lblcutname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcutname.ForeColor = System.Drawing.Color.Navy;
            this.lblcutname.Location = new System.Drawing.Point(27, 134);
            this.lblcutname.Name = "lblcutname";
            this.lblcutname.Size = new System.Drawing.Size(118, 28);
            this.lblcutname.TabIndex = 79;
            this.lblcutname.Text = "Cust_Name";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Navy;
            this.lblcustid.Location = new System.Drawing.Point(27, 93);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(84, 28);
            this.lblcustid.TabIndex = 78;
            this.lblcustid.Text = "Cust_Id";
            // 
            // lblphotoid
            // 
            this.lblphotoid.AutoSize = true;
            this.lblphotoid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphotoid.ForeColor = System.Drawing.Color.Navy;
            this.lblphotoid.Location = new System.Drawing.Point(27, 175);
            this.lblphotoid.Name = "lblphotoid";
            this.lblphotoid.Size = new System.Drawing.Size(96, 28);
            this.lblphotoid.TabIndex = 77;
            this.lblphotoid.Text = "Photo_Id";
            // 
            // cmbcid
            // 
            this.cmbcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Location = new System.Drawing.Point(175, 99);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(156, 24);
            this.cmbcid.TabIndex = 84;
            this.cmbcid.SelectedIndexChanged += new System.EventHandler(this.cmbcid_SelectedIndexChanged);
            // 
            // cmbreturnid
            // 
            this.cmbreturnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbreturnid.FormattingEnabled = true;
            this.cmbreturnid.Location = new System.Drawing.Point(176, 58);
            this.cmbreturnid.Name = "cmbreturnid";
            this.cmbreturnid.Size = new System.Drawing.Size(156, 24);
            this.cmbreturnid.TabIndex = 86;
            this.cmbreturnid.SelectedIndexChanged += new System.EventHandler(this.cmbreturnid_SelectedIndexChanged);
            // 
            // lblreturnid
            // 
            this.lblreturnid.AutoSize = true;
            this.lblreturnid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturnid.ForeColor = System.Drawing.Color.Navy;
            this.lblreturnid.Location = new System.Drawing.Point(27, 55);
            this.lblreturnid.Name = "lblreturnid";
            this.lblreturnid.Size = new System.Drawing.Size(106, 28);
            this.lblreturnid.TabIndex = 85;
            this.lblreturnid.Text = "Return_Id";
            // 
            // txtphotoid
            // 
            this.txtphotoid.Enabled = false;
            this.txtphotoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphotoid.Location = new System.Drawing.Point(175, 181);
            this.txtphotoid.Name = "txtphotoid";
            this.txtphotoid.Size = new System.Drawing.Size(156, 22);
            this.txtphotoid.TabIndex = 87;
            // 
            // btnnewreturn
            // 
            this.btnnewreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnewreturn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewreturn.ForeColor = System.Drawing.Color.White;
            this.btnnewreturn.Location = new System.Drawing.Point(338, 52);
            this.btnnewreturn.Name = "btnnewreturn";
            this.btnnewreturn.Size = new System.Drawing.Size(68, 36);
            this.btnnewreturn.TabIndex = 88;
            this.btnnewreturn.Text = "&New";
            this.btnnewreturn.UseVisualStyleBackColor = false;
            this.btnnewreturn.Click += new System.EventHandler(this.btnnewreturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(550, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 117);
            this.groupBox2.TabIndex = 95;
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
            this.btnsearch.Location = new System.Drawing.Point(39, 64);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(135, 36);
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
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(550, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 216);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Transparent;
            this.btnsave.Location = new System.Drawing.Point(73, 27);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 30);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnupdate.Location = new System.Drawing.Point(73, 75);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(85, 30);
            this.btnupdate.TabIndex = 59;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(73, 123);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(85, 30);
            this.btndelete.TabIndex = 60;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Transparent;
            this.btnexit.Location = new System.Drawing.Point(73, 171);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 30);
            this.btnexit.TabIndex = 61;
            this.btnexit.Text = "CANCLE";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbcid);
            this.groupBox1.Controls.Add(this.txtcid);
            this.groupBox1.Controls.Add(this.btnnewreturn);
            this.groupBox1.Controls.Add(this.cmbreturnid);
            this.groupBox1.Controls.Add(this.lbltotalprice);
            this.groupBox1.Controls.Add(this.lblreturnid);
            this.groupBox1.Controls.Add(this.lbldeliverydate);
            this.groupBox1.Controls.Add(this.lblphotoid);
            this.groupBox1.Controls.Add(this.lblcutname);
            this.groupBox1.Controls.Add(this.txtphotoid);
            this.groupBox1.Controls.Add(this.lblcustid);
            this.groupBox1.Controls.Add(this.txtreturnid);
            this.groupBox1.Controls.Add(this.txtcname);
            this.groupBox1.Controls.Add(this.txttotalprice);
            this.groupBox1.Controls.Add(this.datetimedeliverydate);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(69, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 339);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photoreturn Details";
            // 
            // txtcid
            // 
            this.txtcid.Enabled = false;
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(175, 99);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(156, 22);
            this.txtcid.TabIndex = 98;
            // 
            // txtreturnid
            // 
            this.txtreturnid.Enabled = false;
            this.txtreturnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturnid.Location = new System.Drawing.Point(176, 58);
            this.txtreturnid.Name = "txtreturnid";
            this.txtreturnid.Size = new System.Drawing.Size(156, 22);
            this.txtreturnid.TabIndex = 89;
            // 
            // datagridviewreturnphoto
            // 
            this.datagridviewreturnphoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewreturnphoto.Location = new System.Drawing.Point(69, 427);
            this.datagridviewreturnphoto.Name = "datagridviewreturnphoto";
            this.datagridviewreturnphoto.Size = new System.Drawing.Size(670, 184);
            this.datagridviewreturnphoto.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(478, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 98;
            this.label1.Text = "Information about PhotoReturn";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPhotoreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(809, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewreturnphoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhotoreturn";
            this.Text = "frmPhotoreturn";
            this.Load += new System.EventHandler(this.frmPhotoreturn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewreturnphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimedeliverydate;
        private System.Windows.Forms.Label lbldeliverydate;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label lblcutname;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblphotoid;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.ComboBox cmbreturnid;
        private System.Windows.Forms.Label lblreturnid;
        private System.Windows.Forms.TextBox txtphotoid;
        private System.Windows.Forms.Button btnnewreturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtreturnid;
        private System.Windows.Forms.DataGridView datagridviewreturnphoto;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}