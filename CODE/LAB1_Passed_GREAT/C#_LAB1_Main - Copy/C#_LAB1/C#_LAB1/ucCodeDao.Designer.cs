namespace C__LAB1
{
    partial class ucCodeDao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCodeDao));
            this.pnlChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnEmotion = new System.Windows.Forms.Button();
            this.pnlEmotion = new System.Windows.Forms.Panel();
            this.btnEmotion6 = new System.Windows.Forms.Button();
            this.btnEmotion5 = new System.Windows.Forms.Button();
            this.btnEmotion1 = new System.Windows.Forms.Button();
            this.btnEmotion2 = new System.Windows.Forms.Button();
            this.btnEmotion3 = new System.Windows.Forms.Button();
            this.btnEmotion4 = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.codeDaoRightMessage1 = new C__LAB1.CodeDaoRightMessage();
            this.codeDaoLeftMessage1 = new C__LAB1.CodeDaoLeftMessage();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pnlChat.SuspendLayout();
            this.pnlEmotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.Window;
            this.pnlChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChat.BackgroundImage")));
            this.pnlChat.Controls.Add(this.codeDaoLeftMessage1);
            this.pnlChat.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnlChat.Controls.Add(this.codeDaoRightMessage1);
            this.pnlChat.Location = new System.Drawing.Point(0, 1);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(906, 568);
            this.pnlChat.TabIndex = 80;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(835, 647);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 60);
            this.btnSend.TabIndex = 72;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEmotion
            // 
            this.btnEmotion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEmotion.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion.Image")));
            this.btnEmotion.Location = new System.Drawing.Point(759, 639);
            this.btnEmotion.Name = "btnEmotion";
            this.btnEmotion.Size = new System.Drawing.Size(70, 75);
            this.btnEmotion.TabIndex = 74;
            this.btnEmotion.UseVisualStyleBackColor = false;
            this.btnEmotion.Click += new System.EventHandler(this.btnEmotion_Click);
            // 
            // pnlEmotion
            // 
            this.pnlEmotion.BackColor = System.Drawing.SystemColors.Info;
            this.pnlEmotion.Controls.Add(this.btnEmotion6);
            this.pnlEmotion.Controls.Add(this.btnEmotion5);
            this.pnlEmotion.Controls.Add(this.btnEmotion1);
            this.pnlEmotion.Controls.Add(this.btnEmotion2);
            this.pnlEmotion.Controls.Add(this.btnEmotion3);
            this.pnlEmotion.Controls.Add(this.btnEmotion4);
            this.pnlEmotion.Location = new System.Drawing.Point(157, 582);
            this.pnlEmotion.Name = "pnlEmotion";
            this.pnlEmotion.Size = new System.Drawing.Size(672, 57);
            this.pnlEmotion.TabIndex = 75;
            // 
            // btnEmotion6
            // 
            this.btnEmotion6.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion6.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion6.Image")));
            this.btnEmotion6.Location = new System.Drawing.Point(508, 0);
            this.btnEmotion6.Name = "btnEmotion6";
            this.btnEmotion6.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion6.TabIndex = 58;
            this.btnEmotion6.UseVisualStyleBackColor = false;
            this.btnEmotion6.Click += new System.EventHandler(this.btnEmotion6_Click);
            // 
            // btnEmotion5
            // 
            this.btnEmotion5.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion5.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion5.Image")));
            this.btnEmotion5.Location = new System.Drawing.Point(411, 0);
            this.btnEmotion5.Name = "btnEmotion5";
            this.btnEmotion5.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion5.TabIndex = 59;
            this.btnEmotion5.UseVisualStyleBackColor = false;
            this.btnEmotion5.Click += new System.EventHandler(this.btnEmotion5_Click);
            // 
            // btnEmotion1
            // 
            this.btnEmotion1.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion1.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion1.Image")));
            this.btnEmotion1.Location = new System.Drawing.Point(20, 0);
            this.btnEmotion1.Name = "btnEmotion1";
            this.btnEmotion1.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion1.TabIndex = 56;
            this.btnEmotion1.UseVisualStyleBackColor = false;
            this.btnEmotion1.Click += new System.EventHandler(this.btnEmotion1_Click);
            // 
            // btnEmotion2
            // 
            this.btnEmotion2.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion2.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion2.Image")));
            this.btnEmotion2.Location = new System.Drawing.Point(116, 0);
            this.btnEmotion2.Name = "btnEmotion2";
            this.btnEmotion2.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion2.TabIndex = 60;
            this.btnEmotion2.UseVisualStyleBackColor = false;
            this.btnEmotion2.Click += new System.EventHandler(this.btnEmotion2_Click);
            // 
            // btnEmotion3
            // 
            this.btnEmotion3.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion3.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion3.Image")));
            this.btnEmotion3.Location = new System.Drawing.Point(214, 0);
            this.btnEmotion3.Name = "btnEmotion3";
            this.btnEmotion3.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion3.TabIndex = 57;
            this.btnEmotion3.UseVisualStyleBackColor = false;
            this.btnEmotion3.Click += new System.EventHandler(this.btnEmotion3_Click);
            // 
            // btnEmotion4
            // 
            this.btnEmotion4.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmotion4.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion4.Image")));
            this.btnEmotion4.Location = new System.Drawing.Point(312, 0);
            this.btnEmotion4.Name = "btnEmotion4";
            this.btnEmotion4.Size = new System.Drawing.Size(55, 59);
            this.btnEmotion4.TabIndex = 62;
            this.btnEmotion4.UseVisualStyleBackColor = false;
            this.btnEmotion4.Click += new System.EventHandler(this.btnEmotion4_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.Location = new System.Drawing.Point(-3, 647);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(74, 72);
            this.btnAttach.TabIndex = 73;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // rtxMessage
            // 
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rtxMessage.Location = new System.Drawing.Point(157, 639);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(602, 77);
            this.rtxMessage.TabIndex = 76;
            this.rtxMessage.Text = "Developer living with bugs in the dream.";
            // 
            // btnVideo
            // 
            this.btnVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideo.Image")));
            this.btnVideo.Location = new System.Drawing.Point(76, 647);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 72);
            this.btnVideo.TabIndex = 80;
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-20, -19);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 79;
            // 
            // codeDaoRightMessage1
            // 
            this.codeDaoRightMessage1.Location = new System.Drawing.Point(209, 100);
            this.codeDaoRightMessage1.Name = "codeDaoRightMessage1";
            this.codeDaoRightMessage1.Size = new System.Drawing.Size(691, 72);
            this.codeDaoRightMessage1.TabIndex = 78;
            // 
            // codeDaoLeftMessage1
            // 
            this.codeDaoLeftMessage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.codeDaoLeftMessage1.Location = new System.Drawing.Point(-1, 0);
            this.codeDaoLeftMessage1.Name = "codeDaoLeftMessage1";
            this.codeDaoLeftMessage1.SetLabelText = "How about your coding?";
            this.codeDaoLeftMessage1.Size = new System.Drawing.Size(701, 94);
            this.codeDaoLeftMessage1.TabIndex = 81;
            // 
            // btnHistory
            // 
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(36, 575);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(74, 72);
            this.btnHistory.TabIndex = 82;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // ucCodeDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.rtxMessage);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pnlEmotion);
            this.Controls.Add(this.btnEmotion);
            this.Name = "ucCodeDao";
            this.Size = new System.Drawing.Size(906, 720);
            this.pnlChat.ResumeLayout(false);
            this.pnlEmotion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnEmotion;
        private System.Windows.Forms.Panel pnlEmotion;
        private System.Windows.Forms.Button btnEmotion6;
        private System.Windows.Forms.Button btnEmotion5;
        private System.Windows.Forms.Button btnEmotion1;
        private System.Windows.Forms.Button btnEmotion2;
        private System.Windows.Forms.Button btnEmotion3;
        private System.Windows.Forms.Button btnEmotion4;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private CodeDaoRightMessage codeDaoRightMessage1;
        private System.Windows.Forms.Button btnAttach;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnVideo;
        private CodeDaoLeftMessage codeDaoLeftMessage1;
        private System.Windows.Forms.Button btnHistory;
    }
}
