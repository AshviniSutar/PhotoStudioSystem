namespace PhotoStudioManagementSystem
{
    partial class frmOrder
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
            this.txtphotoid = new System.Windows.Forms.TextBox();
            this.cmborderid = new System.Windows.Forms.ComboBox();
            this.datetimedeliverydate = new System.Windows.Forms.DateTimePicker();
            this.datetimeorderdate = new System.Windows.Forms.DateTimePicker();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.lbldeliverydate = new System.Windows.Forms.Label();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.lblphotoid = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblorderid = new System.Windows.Forms.Label();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.btnnewphoto = new System.Windows.Forms.Button();
            this.btnneworder = new System.Windows.Forms.Button();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbidsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.datagridvieworder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvieworder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtphotoid
            // 
            this.txtphotoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphotoid.Location = new System.Drawing.Point(183, 208);
            this.txtphotoid.Name = "txtphotoid";
            this.txtphotoid.Size = new System.Drawing.Size(158, 22);
            this.txtphotoid.TabIndex = 76;
            // 
            // cmborderid
            // 
            this.cmborderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmborderid.FormattingEnabled = true;
            this.cmborderid.Location = new System.Drawing.Point(183, 65);
            this.cmborderid.Name = "cmborderid";
            this.cmborderid.Size = new System.Drawing.Size(158, 24);
            this.cmborderid.TabIndex = 75;
            this.cmborderid.SelectedIndexChanged += new System.EventHandler(this.cmborderid_SelectedIndexChanged);
            // 
            // datetimedeliverydate
            // 
            this.datetimedeliverydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimedeliverydate.Location = new System.Drawing.Point(183, 302);
            this.datetimedeliverydate.Name = "datetimedeliverydate";
            this.datetimedeliverydate.Size = new System.Drawing.Size(158, 22);
            this.datetimedeliverydate.TabIndex = 74;
            // 
            // datetimeorderdate
            // 
            this.datetimeorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeorderdate.Location = new System.Drawing.Point(183, 256);
            this.datetimeorderdate.Name = "datetimeorderdate";
            this.datetimeorderdate.Size = new System.Drawing.Size(158, 22);
            this.datetimeorderdate.TabIndex = 73;
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderid.Location = new System.Drawing.Point(183, 65);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(158, 22);
            this.txtorderid.TabIndex = 71;
            // 
            // lbldeliverydate
            // 
            this.lbldeliverydate.AutoSize = true;
            this.lbldeliverydate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeliverydate.ForeColor = System.Drawing.Color.Navy;
            this.lbldeliverydate.Location = new System.Drawing.Point(33, 298);
            this.lbldeliverydate.Name = "lbldeliverydate";
            this.lbldeliverydate.Size = new System.Drawing.Size(144, 28);
            this.lbldeliverydate.TabIndex = 70;
            this.lbldeliverydate.Text = "Delivery_Date";
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.ForeColor = System.Drawing.Color.Navy;
            this.lblorderdate.Location = new System.Drawing.Point(33, 250);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(119, 28);
            this.lblorderdate.TabIndex = 69;
            this.lblorderdate.Text = "Order_Date";
            // 
            // lblphotoid
            // 
            this.lblphotoid.AutoSize = true;
            this.lblphotoid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphotoid.ForeColor = System.Drawing.Color.Navy;
            this.lblphotoid.Location = new System.Drawing.Point(32, 202);
            this.lblphotoid.Name = "lblphotoid";
            this.lblphotoid.Size = new System.Drawing.Size(95, 28);
            this.lblphotoid.TabIndex = 68;
            this.lblphotoid.Text = "Photo_id";
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustid.ForeColor = System.Drawing.Color.Navy;
            this.lblcustid.Location = new System.Drawing.Point(33, 106);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(84, 28);
            this.lblcustid.TabIndex = 67;
            this.lblcustid.Text = "Cust_Id";
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderid.ForeColor = System.Drawing.Color.Navy;
            this.lblorderid.Location = new System.Drawing.Point(33, 58);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(96, 28);
            this.lblorderid.TabIndex = 66;
            this.lblorderid.Text = "Order_Id";
            // 
            // cmbcustid
            // 
            this.cmbcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(183, 112);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(158, 24);
            this.cmbcustid.TabIndex = 72;
            this.cmbcustid.SelectedIndexChanged += new System.EventHandler(this.cmbcustid_SelectedIndexChanged);
            // 
            // btnnewphoto
            // 
            this.btnnewphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnewphoto.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewphoto.ForeColor = System.Drawing.Color.White;
            this.btnnewphoto.Location = new System.Drawing.Point(359, 208);
            this.btnnewphoto.Name = "btnnewphoto";
            this.btnnewphoto.Size = new System.Drawing.Size(73, 36);
            this.btnnewphoto.TabIndex = 78;
            this.btnnewphoto.Text = "NEW";
            this.btnnewphoto.UseVisualStyleBackColor = false;
            this.btnnewphoto.Click += new System.EventHandler(this.btnnewphoto_Click);
            // 
            // btnneworder
            // 
            this.btnneworder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnneworder.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnneworder.ForeColor = System.Drawing.Color.White;
            this.btnneworder.Location = new System.Drawing.Point(359, 61);
            this.btnneworder.Name = "btnneworder";
            this.btnneworder.Size = new System.Drawing.Size(73, 35);
            this.btnneworder.TabIndex = 81;
            this.btnneworder.Text = "NEW";
            this.btnneworder.UseVisualStyleBackColor = false;
            this.btnneworder.Click += new System.EventHandler(this.btnneworder_Click);
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(183, 114);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(158, 22);
            this.txtcustid.TabIndex = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbidsearch);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(534, 85);
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
            this.btnsearch.Location = new System.Drawing.Point(50, 65);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 31);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(534, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 224);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(60, 42);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 30);
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
            this.btnexit.Location = new System.Drawing.Point(60, 174);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 33);
            this.btnexit.TabIndex = 61;
            this.btnexit.Text = "CANCLE";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblorderid);
            this.groupBox1.Controls.Add(this.btnneworder);
            this.groupBox1.Controls.Add(this.lblcustid);
            this.groupBox1.Controls.Add(this.txtcname);
            this.groupBox1.Controls.Add(this.lblphotoid);
            this.groupBox1.Controls.Add(this.lblcustname);
            this.groupBox1.Controls.Add(this.lblorderdate);
            this.groupBox1.Controls.Add(this.btnnewphoto);
            this.groupBox1.Controls.Add(this.lbldeliverydate);
            this.groupBox1.Controls.Add(this.txtphotoid);
            this.groupBox1.Controls.Add(this.datetimeorderdate);
            this.groupBox1.Controls.Add(this.datetimedeliverydate);
            this.groupBox1.Controls.Add(this.cmborderid);
            this.groupBox1.Controls.Add(this.txtorderid);
            this.groupBox1.Controls.Add(this.cmbcustid);
            this.groupBox1.Controls.Add(this.txtcustid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(41, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 362);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // txtcname
            // 
            this.txtcname.Enabled = false;
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(183, 160);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(158, 22);
            this.txtcname.TabIndex = 80;
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.ForeColor = System.Drawing.Color.Navy;
            this.lblcustname.Location = new System.Drawing.Point(33, 154);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(118, 28);
            this.lblcustname.TabIndex = 79;
            this.lblcustname.Text = "Cust_Name";
            // 
            // datagridvieworder
            // 
            this.datagridvieworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridvieworder.Location = new System.Drawing.Point(41, 467);
            this.datagridvieworder.Name = "datagridvieworder";
            this.datagridvieworder.Size = new System.Drawing.Size(675, 196);
            this.datagridvieworder.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(496, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Information about Order";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(60, 86);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 30);
            this.btnupdate.TabIndex = 62;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(60, 130);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 30);
            this.btndelete.TabIndex = 63;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(776, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridvieworder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvieworder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtphotoid;
        private System.Windows.Forms.ComboBox cmborderid;
        private System.Windows.Forms.DateTimePicker datetimedeliverydate;
        private System.Windows.Forms.DateTimePicker datetimeorderdate;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label lbldeliverydate;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.Label lblphotoid;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.ComboBox cmbcustid;
        private System.Windows.Forms.Button btnnewphoto;
        private System.Windows.Forms.Button btnneworder;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbidsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagridvieworder;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}