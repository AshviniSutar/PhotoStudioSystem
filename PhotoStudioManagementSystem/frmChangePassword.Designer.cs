namespace PhotoStudioManagementSystem
{
    partial class frmChangePassword
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
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbloldpassword = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnconfirmpass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.ForeColor = System.Drawing.Color.Navy;
            this.lblconfirmpassword.Location = new System.Drawing.Point(50, 264);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(199, 30);
            this.lblconfirmpassword.TabIndex = 108;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblnewpassword.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.ForeColor = System.Drawing.Color.Navy;
            this.lblnewpassword.Location = new System.Drawing.Point(50, 201);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(160, 30);
            this.lblnewpassword.TabIndex = 107;
            this.lblnewpassword.Text = "New Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Navy;
            this.lblusername.Location = new System.Drawing.Point(50, 75);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(124, 30);
            this.lblusername.TabIndex = 106;
            this.lblusername.Text = "User Name";
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.BackColor = System.Drawing.Color.Transparent;
            this.lbloldpassword.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpassword.ForeColor = System.Drawing.Color.Navy;
            this.lbloldpassword.Location = new System.Drawing.Point(50, 138);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(151, 30);
            this.lbloldpassword.TabIndex = 105;
            this.lbloldpassword.Text = "Old Password";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtoldpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtoldpassword.CausesValidation = false;
            this.txtoldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpassword.Location = new System.Drawing.Point(260, 140);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(260, 29);
            this.txtoldpassword.TabIndex = 110;
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = true;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(260, 77);
            this.txtusername.Name = "txtusername";
            this.txtusername.ShortcutsEnabled = false;
            this.txtusername.Size = new System.Drawing.Size(260, 29);
            this.txtusername.TabIndex = 109;
            this.txtusername.WordWrap = false;
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnewpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtnewpassword.CausesValidation = false;
            this.txtnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.Location = new System.Drawing.Point(260, 203);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(260, 29);
            this.txtnewpassword.TabIndex = 111;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtconfirmpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtconfirmpassword.CausesValidation = false;
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(260, 266);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(260, 29);
            this.txtconfirmpassword.TabIndex = 112;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.ImageKey = "(none)";
            this.btnclear.Location = new System.Drawing.Point(417, 329);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 45);
            this.btnclear.TabIndex = 125;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnconfirmpass
            // 
            this.btnconfirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnconfirmpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconfirmpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmpass.ForeColor = System.Drawing.Color.White;
            this.btnconfirmpass.ImageKey = "(none)";
            this.btnconfirmpass.Location = new System.Drawing.Point(55, 329);
            this.btnconfirmpass.Name = "btnconfirmpass";
            this.btnconfirmpass.Size = new System.Drawing.Size(212, 45);
            this.btnconfirmpass.TabIndex = 124;
            this.btnconfirmpass.Text = "Confirm Password";
            this.btnconfirmpass.UseVisualStyleBackColor = false;
            this.btnconfirmpass.Click += new System.EventHandler(this.btnconfirmpass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.lbloldpassword);
            this.groupBox1.Controls.Add(this.btnconfirmpass);
            this.groupBox1.Controls.Add(this.lblnewpassword);
            this.groupBox1.Controls.Add(this.txtconfirmpassword);
            this.groupBox1.Controls.Add(this.lblconfirmpassword);
            this.groupBox1.Controls.Add(this.txtnewpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.txtoldpassword);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(74, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 405);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.ClientSize = new System.Drawing.Size(734, 540);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbloldpassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnconfirmpass;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}