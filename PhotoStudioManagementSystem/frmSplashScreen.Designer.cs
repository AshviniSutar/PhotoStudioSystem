namespace PhotoStudioManagementSystem
{
    partial class frmSplashScreen
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
            this.lblstudio = new System.Windows.Forms.Label();
            this.lblsplashtext = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblstudio
            // 
            this.lblstudio.AutoSize = true;
            this.lblstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblstudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblstudio.Font = new System.Drawing.Font("Sitka Heading", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudio.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblstudio.Location = new System.Drawing.Point(159, 28);
            this.lblstudio.Name = "lblstudio";
            this.lblstudio.Size = new System.Drawing.Size(545, 53);
            this.lblstudio.TabIndex = 57;
            this.lblstudio.Text = "Welcome to Digital Photo Studio";
            // 
            // lblsplashtext
            // 
            this.lblsplashtext.AutoSize = true;
            this.lblsplashtext.BackColor = System.Drawing.Color.Transparent;
            this.lblsplashtext.Font = new System.Drawing.Font("Calisto MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsplashtext.ForeColor = System.Drawing.Color.Yellow;
            this.lblsplashtext.Location = new System.Drawing.Point(202, 366);
            this.lblsplashtext.Name = "lblsplashtext";
            this.lblsplashtext.Size = new System.Drawing.Size(60, 24);
            this.lblsplashtext.TabIndex = 56;
            this.lblsplashtext.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar1.Location = new System.Drawing.Point(206, 393);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 14);
            this.progressBar1.TabIndex = 55;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudioManagementSystem.Properties.Resources._1860922402;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 495);
            this.Controls.Add(this.lblstudio);
            this.Controls.Add(this.lblsplashtext);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmSplashScreen";
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudio;
        private System.Windows.Forms.Label lblsplashtext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}