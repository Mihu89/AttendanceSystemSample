namespace MyAttendanceSystem
{
    partial class LoginForm
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
            this.mlUser = new MetroFramework.Controls.MetroLabel();
            this.metroTbUser = new MetroFramework.Controls.MetroTextBox();
            this.mlPassword = new MetroFramework.Controls.MetroLabel();
            this.metroTbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlUser
            // 
            this.mlUser.AutoSize = true;
            this.mlUser.Location = new System.Drawing.Point(40, 130);
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(39, 19);
            this.mlUser.TabIndex = 0;
            this.mlUser.Text = "User:";
            // 
            // metroTbUser
            // 
            this.metroTbUser.Location = new System.Drawing.Point(40, 161);
            this.metroTbUser.Name = "metroTbUser";
            this.metroTbUser.Size = new System.Drawing.Size(171, 23);
            this.metroTbUser.TabIndex = 1;
            // 
            // mlPassword
            // 
            this.mlPassword.AutoSize = true;
            this.mlPassword.Location = new System.Drawing.Point(40, 203);
            this.mlPassword.Name = "mlPassword";
            this.mlPassword.Size = new System.Drawing.Size(66, 19);
            this.mlPassword.TabIndex = 2;
            this.mlPassword.Text = "Password:";
            // 
            // metroTbPassword
            // 
            this.metroTbPassword.Location = new System.Drawing.Point(40, 239);
            this.metroTbPassword.Name = "metroTbPassword";
            this.metroTbPassword.PasswordChar = '*';
            this.metroTbPassword.Size = new System.Drawing.Size(171, 23);
            this.metroTbPassword.TabIndex = 3;
            // 
            // metroBtnLogin
            // 
            this.metroBtnLogin.Location = new System.Drawing.Point(242, 239);
            this.metroBtnLogin.Name = "metroBtnLogin";
            this.metroBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.metroBtnLogin.TabIndex = 4;
            this.metroBtnLogin.Text = "Login";
            this.metroBtnLogin.Click += new System.EventHandler(this.metroBtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyAttendanceSystem.Properties.Resources.attendance;
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(329, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroBtnLogin);
            this.Controls.Add(this.metroTbPassword);
            this.Controls.Add(this.mlPassword);
            this.Controls.Add(this.metroTbUser);
            this.Controls.Add(this.mlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlUser;
        private MetroFramework.Controls.MetroTextBox metroTbUser;
        private MetroFramework.Controls.MetroLabel mlPassword;
        private MetroFramework.Controls.MetroTextBox metroTbPassword;
        private MetroFramework.Controls.MetroButton metroBtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}