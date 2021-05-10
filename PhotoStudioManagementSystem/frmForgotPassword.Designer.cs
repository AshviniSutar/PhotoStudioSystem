namespace PhotoStudioManagementSystem
{
    partial class frmForgotPassword
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
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.lblanswer = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btncheckedpass = new System.Windows.Forms.Button();
            this.cmbquestion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtanswer
            // 
            this.txtanswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtanswer.Location = new System.Drawing.Point(362, 270);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(237, 29);
            this.txtanswer.TabIndex = 121;
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.BackColor = System.Drawing.Color.Transparent;
            this.lblanswer.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblanswer.Location = new System.Drawing.Point(189, 270);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(88, 30);
            this.lblanswer.TabIndex = 120;
            this.lblanswer.Text = "Answer";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.BackColor = System.Drawing.Color.Transparent;
            this.lblquestion.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblquestion.Location = new System.Drawing.Point(190, 209);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(170, 30);
            this.lblquestion.TabIndex = 118;
            this.lblquestion.Text = "Select Question";
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtusername.Location = new System.Drawing.Point(364, 153);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(237, 29);
            this.txtusername.TabIndex = 117;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblusername.Location = new System.Drawing.Point(189, 151);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(158, 30);
            this.lblusername.TabIndex = 116;
            this.lblusername.Text = "Name OF User";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.ImageKey = "(none)";
            this.btncancle.Location = new System.Drawing.Point(471, 332);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(130, 45);
            this.btncancle.TabIndex = 123;
            this.btncancle.Text = "CANCLE";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btncheckedpass
            // 
            this.btncheckedpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncheckedpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncheckedpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckedpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckedpass.ForeColor = System.Drawing.Color.White;
            this.btncheckedpass.ImageKey = "(none)";
            this.btncheckedpass.Location = new System.Drawing.Point(195, 332);
            this.btncheckedpass.Name = "btncheckedpass";
            this.btncheckedpass.Size = new System.Drawing.Size(212, 45);
            this.btncheckedpass.TabIndex = 122;
            this.btncheckedpass.Text = "Cheked Password";
            this.btncheckedpass.UseVisualStyleBackColor = false;
            this.btncheckedpass.Click += new System.EventHandler(this.btncheckedpass_Click);
            // 
            // cmbquestion
            // 
            this.cmbquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbquestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbquestion.FormattingEnabled = true;
            this.cmbquestion.Items.AddRange(new object[] {
            "--Select_Hint_Question--",
            "Mother Name",
            "Birth Place",
            "First School Name",
            "Favourite Cricketor"});
            this.cmbquestion.Location = new System.Drawing.Point(362, 209);
            this.cmbquestion.Name = "cmbquestion";
            this.cmbquestion.Size = new System.Drawing.Size(239, 32);
            this.cmbquestion.TabIndex = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(133, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 398);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgot Password";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources.coral_ombre_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.cmbquestion);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btncheckedpass);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmForgotPassword";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btncheckedpass;
        private System.Windows.Forms.ComboBox cmbquestion;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}