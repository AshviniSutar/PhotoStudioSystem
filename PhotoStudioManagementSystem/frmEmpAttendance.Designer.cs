namespace PhotoStudioManagementSystem
{
    partial class frmEmpAttendance
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
            this.rdbabsent = new System.Windows.Forms.RadioButton();
            this.rdbpresent = new System.Windows.Forms.RadioButton();
            this.datetimedate = new System.Windows.Forms.DateTimePicker();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.cmbempid = new System.Windows.Forms.ComboBox();
            this.lblattendance = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbsearchid = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.datagridviewattendance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewattendance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbabsent);
            this.groupBox1.Controls.Add(this.rdbpresent);
            this.groupBox1.Controls.Add(this.datetimedate);
            this.groupBox1.Controls.Add(this.txtempname);
            this.groupBox1.Controls.Add(this.cmbempid);
            this.groupBox1.Controls.Add(this.lblattendance);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblempname);
            this.groupBox1.Controls.Add(this.lblempid);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(54, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance _Details";
            // 
            // rdbabsent
            // 
            this.rdbabsent.AutoSize = true;
            this.rdbabsent.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbabsent.ForeColor = System.Drawing.Color.Navy;
            this.rdbabsent.Location = new System.Drawing.Point(295, 211);
            this.rdbabsent.Name = "rdbabsent";
            this.rdbabsent.Size = new System.Drawing.Size(95, 32);
            this.rdbabsent.TabIndex = 12;
            this.rdbabsent.TabStop = true;
            this.rdbabsent.Text = "Absent";
            this.rdbabsent.UseVisualStyleBackColor = true;
            this.rdbabsent.CheckedChanged += new System.EventHandler(this.rdbabsent_CheckedChanged);
            // 
            // rdbpresent
            // 
            this.rdbpresent.AutoSize = true;
            this.rdbpresent.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpresent.ForeColor = System.Drawing.Color.Navy;
            this.rdbpresent.Location = new System.Drawing.Point(197, 211);
            this.rdbpresent.Name = "rdbpresent";
            this.rdbpresent.Size = new System.Drawing.Size(101, 32);
            this.rdbpresent.TabIndex = 11;
            this.rdbpresent.TabStop = true;
            this.rdbpresent.Text = "Present";
            this.rdbpresent.UseVisualStyleBackColor = true;
            this.rdbpresent.CheckedChanged += new System.EventHandler(this.rdbpresent_CheckedChanged);
            // 
            // datetimedate
            // 
            this.datetimedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimedate.Location = new System.Drawing.Point(197, 164);
            this.datetimedate.Name = "datetimedate";
            this.datetimedate.Size = new System.Drawing.Size(178, 22);
            this.datetimedate.TabIndex = 10;
            // 
            // txtempname
            // 
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(197, 115);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(178, 22);
            this.txtempname.TabIndex = 2;
            // 
            // cmbempid
            // 
            this.cmbempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbempid.FormattingEnabled = true;
            this.cmbempid.Location = new System.Drawing.Point(197, 65);
            this.cmbempid.Name = "cmbempid";
            this.cmbempid.Size = new System.Drawing.Size(178, 24);
            this.cmbempid.TabIndex = 9;
            this.cmbempid.SelectedIndexChanged += new System.EventHandler(this.cmbempid_SelectedIndexChanged);
            // 
            // lblattendance
            // 
            this.lblattendance.AutoSize = true;
            this.lblattendance.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblattendance.ForeColor = System.Drawing.Color.Navy;
            this.lblattendance.Location = new System.Drawing.Point(23, 215);
            this.lblattendance.Name = "lblattendance";
            this.lblattendance.Size = new System.Drawing.Size(122, 28);
            this.lblattendance.TabIndex = 8;
            this.lblattendance.Text = "Attendance ";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Navy;
            this.lbldate.Location = new System.Drawing.Point(23, 165);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(55, 28);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.ForeColor = System.Drawing.Color.Navy;
            this.lblempname.Location = new System.Drawing.Point(23, 115);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(168, 28);
            this.lblempname.TabIndex = 6;
            this.lblempname.Text = "Employee_Name";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.ForeColor = System.Drawing.Color.Navy;
            this.lblempid.Location = new System.Drawing.Point(23, 65);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(139, 28);
            this.lblempid.TabIndex = 5;
            this.lblempid.Text = "Employee_Id ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(494, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 183);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(101, 131);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(83, 29);
            this.btnexit.TabIndex = 20;
            this.btnexit.Text = "CLEAR";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(101, 35);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(83, 29);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(101, 84);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 29);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbsearchid);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(494, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 74);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cmbsearchid
            // 
            this.cmbsearchid.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearchid.FormattingEnabled = true;
            this.cmbsearchid.Location = new System.Drawing.Point(30, 30);
            this.cmbsearchid.Name = "cmbsearchid";
            this.cmbsearchid.Size = new System.Drawing.Size(121, 27);
            this.cmbsearchid.TabIndex = 48;
            this.cmbsearchid.SelectedIndexChanged += new System.EventHandler(this.cmbsearchid_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(157, 25);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(125, 29);
            this.btnsearch.TabIndex = 49;
            this.btnsearch.Text = "Search By Id";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // datagridviewattendance
            // 
            this.datagridviewattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewattendance.Location = new System.Drawing.Point(54, 413);
            this.datagridviewattendance.Name = "datagridviewattendance";
            this.datagridviewattendance.Size = new System.Drawing.Size(606, 150);
            this.datagridviewattendance.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(478, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "Information about Attendance";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmEmpAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewattendance);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmpAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEmpAttendance";
            this.Load += new System.EventHandler(this.frmEmpAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewattendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbabsent;
        private System.Windows.Forms.RadioButton rdbpresent;
        private System.Windows.Forms.DateTimePicker datetimedate;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.ComboBox cmbempid;
        private System.Windows.Forms.Label lblattendance;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbsearchid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView datagridviewattendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}