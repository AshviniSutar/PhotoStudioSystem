namespace PhotoStudioManagementSystem
{
    partial class frmPhoto
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
            this.datagridviewphoto = new System.Windows.Forms.DataGridView();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetimephoto = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtpquantity = new System.Windows.Forms.TextBox();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.lblpquantity = new System.Windows.Forms.Label();
            this.lblphotoprice = new System.Windows.Forms.Label();
            this.lblphotosize = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblphotoid = new System.Windows.Forms.Label();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.cmbpid = new System.Windows.Forms.ComboBox();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.cmbpsize = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewphoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewphoto
            // 
            this.datagridviewphoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewphoto.Location = new System.Drawing.Point(25, 390);
            this.datagridviewphoto.Name = "datagridviewphoto";
            this.datagridviewphoto.Size = new System.Drawing.Size(839, 183);
            this.datagridviewphoto.TabIndex = 71;
            // 
            // txttotalprice
            // 
            this.txttotalprice.Enabled = false;
            this.txttotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.ForeColor = System.Drawing.Color.Black;
            this.txttotalprice.Location = new System.Drawing.Point(464, 237);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(159, 22);
            this.txttotalprice.TabIndex = 52;
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Navy;
            this.lbltotalprice.Location = new System.Drawing.Point(340, 231);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(118, 28);
            this.lbltotalprice.TabIndex = 51;
            this.lbltotalprice.Text = "Total_Price";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.datetimephoto);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.txttotalprice);
            this.groupBox1.Controls.Add(this.lbltotalprice);
            this.groupBox1.Controls.Add(this.txtpquantity);
            this.groupBox1.Controls.Add(this.txtpprice);
            this.groupBox1.Controls.Add(this.txtcname);
            this.groupBox1.Controls.Add(this.lblpquantity);
            this.groupBox1.Controls.Add(this.lblphotoprice);
            this.groupBox1.Controls.Add(this.lblphotosize);
            this.groupBox1.Controls.Add(this.lblcustname);
            this.groupBox1.Controls.Add(this.lblcustid);
            this.groupBox1.Controls.Add(this.lblphotoid);
            this.groupBox1.Controls.Add(this.cmbcid);
            this.groupBox1.Controls.Add(this.txtcustid);
            this.groupBox1.Controls.Add(this.cmbpid);
            this.groupBox1.Controls.Add(this.txtpid);
            this.groupBox1.Controls.Add(this.cmbpsize);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 309);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo Detail";
            // 
            // datetimephoto
            // 
            this.datetimephoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimephoto.Location = new System.Drawing.Point(464, 73);
            this.datetimephoto.Name = "datetimephoto";
            this.datetimephoto.Size = new System.Drawing.Size(159, 22);
            this.datetimephoto.TabIndex = 66;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(340, 69);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(55, 28);
            this.lbldate.TabIndex = 65;
            this.lbldate.Text = "Date";
            // 
            // txtpquantity
            // 
            this.txtpquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpquantity.Location = new System.Drawing.Point(174, 237);
            this.txtpquantity.Name = "txtpquantity";
            this.txtpquantity.Size = new System.Drawing.Size(139, 22);
            this.txtpquantity.TabIndex = 66;
            this.txtpquantity.TextChanged += new System.EventHandler(this.txtpquantity_TextChanged);
            this.txtpquantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtpquantity_Validating);
            // 
            // txtpprice
            // 
            this.txtpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpprice.Location = new System.Drawing.Point(464, 182);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(159, 22);
            this.txtpprice.TabIndex = 66;
            this.txtpprice.TextChanged += new System.EventHandler(this.txtpprice_TextChanged);
            this.txtpprice.Validating += new System.ComponentModel.CancelEventHandler(this.txtpprice_Validating);
            // 
            // txtcname
            // 
            this.txtcname.Enabled = false;
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(464, 128);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(159, 22);
            this.txtcname.TabIndex = 22;
            // 
            // lblpquantity
            // 
            this.lblpquantity.AutoSize = true;
            this.lblpquantity.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpquantity.ForeColor = System.Drawing.Color.Navy;
            this.lblpquantity.Location = new System.Drawing.Point(18, 231);
            this.lblpquantity.Name = "lblpquantity";
            this.lblpquantity.Size = new System.Drawing.Size(159, 28);
            this.lblpquantity.TabIndex = 19;
            this.lblpquantity.Text = "Photo_Quantity";
            // 
            // lblphotoprice
            // 
            this.lblphotoprice.AutoSize = true;
            this.lblphotoprice.ForeColor = System.Drawing.Color.Navy;
            this.lblphotoprice.Location = new System.Drawing.Point(340, 177);
            this.lblphotoprice.Name = "lblphotoprice";
            this.lblphotoprice.Size = new System.Drawing.Size(123, 28);
            this.lblphotoprice.TabIndex = 18;
            this.lblphotoprice.Text = "Photo_Price";
            // 
            // lblphotosize
            // 
            this.lblphotosize.AutoSize = true;
            this.lblphotosize.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphotosize.ForeColor = System.Drawing.Color.Navy;
            this.lblphotosize.Location = new System.Drawing.Point(18, 177);
            this.lblphotosize.Name = "lblphotosize";
            this.lblphotosize.Size = new System.Drawing.Size(114, 28);
            this.lblphotosize.TabIndex = 17;
            this.lblphotosize.Text = "Photo_Size";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.ForeColor = System.Drawing.Color.Navy;
            this.lblcustname.Location = new System.Drawing.Point(340, 123);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(118, 28);
            this.lblcustname.TabIndex = 16;
            this.lblcustname.Text = "Cust_Name";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Navy;
            this.lblcustid.Location = new System.Drawing.Point(18, 123);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(84, 28);
            this.lblcustid.TabIndex = 15;
            this.lblcustid.Text = "Cust_Id";
            // 
            // lblphotoid
            // 
            this.lblphotoid.AutoSize = true;
            this.lblphotoid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphotoid.ForeColor = System.Drawing.Color.Navy;
            this.lblphotoid.Location = new System.Drawing.Point(18, 69);
            this.lblphotoid.Name = "lblphotoid";
            this.lblphotoid.Size = new System.Drawing.Size(96, 28);
            this.lblphotoid.TabIndex = 14;
            this.lblphotoid.Text = "Photo_Id";
            // 
            // cmbcid
            // 
            this.cmbcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Location = new System.Drawing.Point(174, 129);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(139, 24);
            this.cmbcid.TabIndex = 66;
            this.cmbcid.SelectedIndexChanged += new System.EventHandler(this.cmbcid_SelectedIndexChanged);
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(174, 130);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(139, 22);
            this.txtcustid.TabIndex = 95;
            // 
            // cmbpid
            // 
            this.cmbpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpid.FormattingEnabled = true;
            this.cmbpid.Location = new System.Drawing.Point(174, 75);
            this.cmbpid.Name = "cmbpid";
            this.cmbpid.Size = new System.Drawing.Size(139, 24);
            this.cmbpid.TabIndex = 66;
            this.cmbpid.SelectedIndexChanged += new System.EventHandler(this.cmbpid_SelectedIndexChanged);
            // 
            // txtpid
            // 
            this.txtpid.Enabled = false;
            this.txtpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(174, 76);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(139, 22);
            this.txtpid.TabIndex = 21;
            // 
            // cmbpsize
            // 
            this.cmbpsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpsize.FormattingEnabled = true;
            this.cmbpsize.Items.AddRange(new object[] {
            "--Select Photo Size--",
            "30",
            "40",
            "50"});
            this.cmbpsize.Location = new System.Drawing.Point(174, 183);
            this.cmbpsize.Name = "cmbpsize";
            this.cmbpsize.Size = new System.Drawing.Size(139, 24);
            this.cmbpsize.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(702, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 117);
            this.groupBox2.TabIndex = 93;
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
            this.btnsearch.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(46, 69);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 34);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(702, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 186);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(60, 78);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 41);
            this.btndelete.TabIndex = 64;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(60, 30);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 38);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(60, 129);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 38);
            this.btnexit.TabIndex = 61;
            this.btnexit.Text = "CANCLE";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.label1.Location = new System.Drawing.Point(668, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 96;
            this.label1.Text = "Information about Photo";
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(947, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.datagridviewphoto);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhoto";
            this.Text = "frmPhoto";
            this.Load += new System.EventHandler(this.frmPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewphoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewphoto;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbpid;
        private System.Windows.Forms.ComboBox cmbpsize;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.TextBox txtpquantity;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lblpquantity;
        private System.Windows.Forms.Label lblphotoprice;
        private System.Windows.Forms.Label lblphotosize;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblphotoid;
        private System.Windows.Forms.DateTimePicker datetimephoto;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
    }
}