namespace C__LAB1
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTypePass = new System.Windows.Forms.Label();
            this.lblTypeEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTypeUsername = new System.Windows.Forms.Label();
            this.lblUsernameGetPass = new System.Windows.Forms.Label();
            this.txtUsernameGetPass = new System.Windows.Forms.TextBox();
            this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblENG = new System.Windows.Forms.LinkLabel();
            this.llbVIE = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Console", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(134, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(132, 37);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(37, 78);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(102, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(42, 180);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(351, 32);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(256, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 25;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(81)))), ((int)(((byte)(199)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(42, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(357, 49);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForgotPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblForgotPass.Location = new System.Drawing.Point(203, 336);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(180, 20);
            this.lblForgotPass.TabIndex = 27;
            this.lblForgotPass.Text = "Forgot your password?";
            // 
            // picBackground
            // 
            this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(521, 15);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(454, 465);
            this.picBackground.TabIndex = 28;
            this.picBackground.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(45, 356);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 25);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email Address";
            // 
            // lblTypePass
            // 
            this.lblTypePass.AutoSize = true;
            this.lblTypePass.BackColor = System.Drawing.SystemColors.Window;
            this.lblTypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTypePass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTypePass.Location = new System.Drawing.Point(45, 182);
            this.lblTypePass.Name = "lblTypePass";
            this.lblTypePass.Size = new System.Drawing.Size(233, 25);
            this.lblTypePass.TabIndex = 24;
            this.lblTypePass.Text = "Type your password here";
            // 
            // lblTypeEmail
            // 
            this.lblTypeEmail.AutoSize = true;
            this.lblTypeEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblTypeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTypeEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTypeEmail.Location = new System.Drawing.Point(51, 396);
            this.lblTypeEmail.Name = "lblTypeEmail";
            this.lblTypeEmail.Size = new System.Drawing.Size(195, 25);
            this.lblTypeEmail.TabIndex = 32;
            this.lblTypeEmail.Text = "Type your email here";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(48, 394);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 32);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCopyright.Location = new System.Drawing.Point(453, 526);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(177, 20);
            this.lblCopyright.TabIndex = 34;
            this.lblCopyright.Text = "Copyright © dangvq.uit";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(81)))), ((int)(((byte)(199)))));
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmail.Location = new System.Drawing.Point(42, 477);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(357, 49);
            this.btnEmail.TabIndex = 35;
            this.btnEmail.Text = "Get password through email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(42, 106);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(351, 32);
            this.txtUsername.TabIndex = 20;
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseDown);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPass.Location = new System.Drawing.Point(37, 152);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(98, 25);
            this.lblPass.TabIndex = 22;
            this.lblPass.Text = "Password";
            // 
            // lblTypeUsername
            // 
            this.lblTypeUsername.AutoSize = true;
            this.lblTypeUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblTypeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTypeUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTypeUsername.Location = new System.Drawing.Point(45, 109);
            this.lblTypeUsername.Name = "lblTypeUsername";
            this.lblTypeUsername.Size = new System.Drawing.Size(236, 25);
            this.lblTypeUsername.TabIndex = 30;
            this.lblTypeUsername.Text = "Type your username here";
            // 
            // lblUsernameGetPass
            // 
            this.lblUsernameGetPass.AutoSize = true;
            this.lblUsernameGetPass.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsernameGetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsernameGetPass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsernameGetPass.Location = new System.Drawing.Point(51, 439);
            this.lblUsernameGetPass.Name = "lblUsernameGetPass";
            this.lblUsernameGetPass.Size = new System.Drawing.Size(236, 25);
            this.lblUsernameGetPass.TabIndex = 37;
            this.lblUsernameGetPass.Text = "Type your username here";
            // 
            // txtUsernameGetPass
            // 
            this.txtUsernameGetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsernameGetPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsernameGetPass.Location = new System.Drawing.Point(48, 436);
            this.txtUsernameGetPass.Multiline = true;
            this.txtUsernameGetPass.Name = "txtUsernameGetPass";
            this.txtUsernameGetPass.Size = new System.Drawing.Size(351, 32);
            this.txtUsernameGetPass.TabIndex = 36;
            this.txtUsernameGetPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsernameGetPass_MouseClick);
            this.txtUsernameGetPass.TextChanged += new System.EventHandler(this.txtUsernameGetPass_TextChanged);
            // 
            // llbCreateAccount
            // 
            this.llbCreateAccount.AutoSize = true;
            this.llbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llbCreateAccount.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.llbCreateAccount.Location = new System.Drawing.Point(83, 301);
            this.llbCreateAccount.Name = "llbCreateAccount";
            this.llbCreateAccount.Size = new System.Drawing.Size(282, 20);
            this.llbCreateAccount.TabIndex = 38;
            this.llbCreateAccount.TabStop = true;
            this.llbCreateAccount.Text = "Do not have an account? Create one";
            this.llbCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(429, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 31);
            this.label7.TabIndex = 51;
            this.label7.Text = "|";
            // 
            // btnDark
            // 
            this.btnDark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDark.Location = new System.Drawing.Point(451, 43);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(59, 35);
            this.btnDark.TabIndex = 50;
            this.btnDark.UseVisualStyleBackColor = false;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLight.Location = new System.Drawing.Point(370, 43);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(59, 35);
            this.btnLight.TabIndex = 49;
            this.btnLight.UseVisualStyleBackColor = false;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(429, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "|";
            // 
            // lblENG
            // 
            this.lblENG.AutoSize = true;
            this.lblENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENG.Location = new System.Drawing.Point(446, 15);
            this.lblENG.Name = "lblENG";
            this.lblENG.Size = new System.Drawing.Size(54, 25);
            this.lblENG.TabIndex = 47;
            this.lblENG.TabStop = true;
            this.lblENG.Text = "ENG";
            this.lblENG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblENG_LinkClicked);
            // 
            // llbVIE
            // 
            this.llbVIE.AutoSize = true;
            this.llbVIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbVIE.Location = new System.Drawing.Point(385, 15);
            this.llbVIE.Name = "llbVIE";
            this.llbVIE.Size = new System.Drawing.Size(44, 25);
            this.llbVIE.TabIndex = 46;
            this.llbVIE.TabStop = true;
            this.llbVIE.Text = "VIE";
            this.llbVIE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbVIE_LinkClicked);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1000, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblENG);
            this.Controls.Add(this.llbVIE);
            this.Controls.Add(this.llbCreateAccount);
            this.Controls.Add(this.lblUsernameGetPass);
            this.Controls.Add(this.txtUsernameGetPass);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblTypeEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTypeUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTypePass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 20);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTypePass;
        private System.Windows.Forms.Label lblTypeEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTypeUsername;
        private System.Windows.Forms.Label lblUsernameGetPass;
        private System.Windows.Forms.TextBox txtUsernameGetPass;
        private System.Windows.Forms.LinkLabel llbCreateAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lblENG;
        private System.Windows.Forms.LinkLabel llbVIE;
    }
}