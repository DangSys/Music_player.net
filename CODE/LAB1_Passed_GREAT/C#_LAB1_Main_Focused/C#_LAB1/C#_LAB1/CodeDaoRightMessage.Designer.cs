namespace C__LAB1
{
    partial class CodeDaoRightMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeDaoRightMessage));
            this.pnlChat = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxText = new System.Windows.Forms.RichTextBox();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlChat.Controls.Add(this.rtxText);
            this.pnlChat.Controls.Add(this.pictureBox1);
            this.pnlChat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(691, 74);
            this.pnlChat.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rtxText
            // 
            this.rtxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtxText.Location = new System.Drawing.Point(92, 18);
            this.rtxText.Name = "rtxText";
            this.rtxText.Size = new System.Drawing.Size(588, 40);
            this.rtxText.TabIndex = 4;
            this.rtxText.Text = "It\'s like a box of chocolate, never know before";
            // 
            // CodeDaoRightMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlChat);
            this.Name = "CodeDaoRightMessage";
            this.Size = new System.Drawing.Size(691, 73);
            this.pnlChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtxText;
    }
}
