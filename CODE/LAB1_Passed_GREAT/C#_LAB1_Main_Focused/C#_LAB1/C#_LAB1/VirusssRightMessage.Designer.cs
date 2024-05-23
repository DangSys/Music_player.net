namespace C__LAB1
{
    partial class VirusssRightMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirusssRightMessage));
            this.pnlChat = new System.Windows.Forms.Panel();
            this.rtxText = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlChat.Controls.Add(this.rtxText);
            this.pnlChat.Controls.Add(this.pictureBox2);
            this.pnlChat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(411, 66);
            this.pnlChat.TabIndex = 6;
            // 
            // rtxText
            // 
            this.rtxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtxText.Location = new System.Drawing.Point(99, 14);
            this.rtxText.Name = "rtxText";
            this.rtxText.Size = new System.Drawing.Size(307, 39);
            this.rtxText.TabIndex = 3;
            this.rtxText.Text = "Sure. Take your time.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 59);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // VirusssRightMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlChat);
            this.Name = "VirusssRightMessage";
            this.Size = new System.Drawing.Size(409, 66);
            this.pnlChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.RichTextBox rtxText;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
