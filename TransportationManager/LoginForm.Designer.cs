namespace TransportationManager
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
            this.tblUsername = new System.Windows.Forms.TextBox();
            this.tblPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tblUsername
            // 
            this.tblUsername.Location = new System.Drawing.Point(50, 78);
            this.tblUsername.Name = "tblUsername";
            this.tblUsername.Size = new System.Drawing.Size(223, 20);
            this.tblUsername.TabIndex = 0;
            // 
            // tblPassword
            // 
            this.tblPassword.Location = new System.Drawing.Point(50, 113);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.Size = new System.Drawing.Size(223, 20);
            this.tblPassword.TabIndex = 1;
            this.tblPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Location = new System.Drawing.Point(50, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(92, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Error: Login field ! ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(341, 178);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Config database ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransportationManager.Properties.Resources.loginBg;
            this.ClientSize = new System.Drawing.Size(459, 211);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tblPassword);
            this.Controls.Add(this.tblUsername);
            this.MaximumSize = new System.Drawing.Size(475, 250);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Login www.ninhbinhcoop.com";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblUsername;
        private System.Windows.Forms.TextBox tblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

