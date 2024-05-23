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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsernameGetPass = new System.Windows.Forms.Label();
            this.txtUsernameGetPass = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(190, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(203, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Forgot your password?";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPassword.Location = new System.Drawing.Point(45, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(233, 25);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Type your password here";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEmail.Location = new System.Drawing.Point(51, 396);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(195, 25);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Type your email here";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(453, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Copyright © dangvq.uit";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(37, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsername.Location = new System.Drawing.Point(45, 109);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(236, 25);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Type your username here";
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.Location = new System.Drawing.Point(83, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(282, 20);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Do not have an account? Create one";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1000, 557);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblUsernameGetPass);
            this.Controls.Add(this.txtUsernameGetPass);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameGetPass;
        private System.Windows.Forms.TextBox txtUsernameGetPass;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}