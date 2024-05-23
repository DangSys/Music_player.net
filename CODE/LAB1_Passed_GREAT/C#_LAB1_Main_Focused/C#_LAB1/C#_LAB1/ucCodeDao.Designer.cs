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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnEmotion = new System.Windows.Forms.Button();
            this.pnlEmotion = new System.Windows.Forms.Panel();
            this.btnEmotion6 = new System.Windows.Forms.Button();
            this.btnEmotion5 = new System.Windows.Forms.Button();
            this.btnEmotion1 = new System.Windows.Forms.Button();
            this.btnEmotion2 = new System.Windows.Forms.Button();
            this.btnEmotion3 = new System.Windows.Forms.Button();
            this.btnEmotion4 = new System.Windows.Forms.Button();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.RightMessage = new C__LAB1.CodeDaoRightMessage();
            this.LeftMessage = new C__LAB1.CodeDaoLeftMessage();
            this.pnlChat.SuspendLayout();
            this.pnlEmotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlChat.Controls.Add(this.label2);
            this.pnlChat.Controls.Add(this.RightMessage);
            this.pnlChat.Controls.Add(this.btnDark);
            this.pnlChat.Controls.Add(this.btnLight);
            this.pnlChat.Controls.Add(this.LeftMessage);
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(909, 567);
            this.pnlChat.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(797, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 31);
            this.label2.TabIndex = 88;
            this.label2.Text = "|";
            // 
            // btnDark
            // 
            this.btnDark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDark.Location = new System.Drawing.Point(819, 25);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(59, 35);
            this.btnDark.TabIndex = 87;
            this.btnDark.UseVisualStyleBackColor = false;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLight.Location = new System.Drawing.Point(738, 25);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(59, 35);
            this.btnLight.TabIndex = 86;
            this.btnLight.UseVisualStyleBackColor = false;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(843, 649);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 72);
            this.btnSend.TabIndex = 72;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEmotion
            // 
            this.btnEmotion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEmotion.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotion.Image")));
            this.btnEmotion.Location = new System.Drawing.Point(770, 649);
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
            this.pnlEmotion.Location = new System.Drawing.Point(168, 592);
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
            // rtxMessage
            // 
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rtxMessage.Location = new System.Drawing.Point(168, 649);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(602, 72);
            this.rtxMessage.TabIndex = 76;
            this.rtxMessage.Text = "Coding make me feel the life deeper.";
            // 
            // btnHistory
            // 
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(42, 577);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(74, 72);
            this.btnHistory.TabIndex = 85;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideo.Image")));
            this.btnVideo.Location = new System.Drawing.Point(82, 649);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 72);
            this.btnVideo.TabIndex = 84;
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.Location = new System.Drawing.Point(3, 649);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(74, 72);
            this.btnAttach.TabIndex = 83;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // RightMessage
            // 
            this.RightMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightMessage.Location = new System.Drawing.Point(197, 79);
            this.RightMessage.Name = "RightMessage";
            this.RightMessage.Size = new System.Drawing.Size(691, 72);
            this.RightMessage.TabIndex = 1;
            // 
            // LeftMessage
            // 
            this.LeftMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftMessage.Location = new System.Drawing.Point(3, 3);
            this.LeftMessage.Name = "LeftMessage";
            this.LeftMessage.SetLabelText = "How about your coding?";
            this.LeftMessage.Size = new System.Drawing.Size(701, 70);
            this.LeftMessage.TabIndex = 0;
            // 
            // ucCodeDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnEmotion);
            this.Controls.Add(this.rtxMessage);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pnlEmotion);
            this.Name = "ucCodeDao";
            this.Size = new System.Drawing.Size(909, 732);
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.pnlEmotion.ResumeLayout(false);
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
        private CodeDaoRightMessage RightMessage;
        private CodeDaoLeftMessage LeftMessage;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnLight;
    }
}
