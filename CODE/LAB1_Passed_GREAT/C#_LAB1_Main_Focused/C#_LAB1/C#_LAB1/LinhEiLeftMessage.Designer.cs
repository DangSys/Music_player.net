namespace C__LAB1
{
    partial class LinhEiLeftMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinhEiLeftMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.rtxText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 56);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlChat.Controls.Add(this.rtxText);
            this.pnlChat.Controls.Add(this.pictureBox1);
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(743, 94);
            this.pnlChat.TabIndex = 4;
            // 
            // rtxText
            // 
            this.rtxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtxText.Location = new System.Drawing.Point(120, 17);
            this.rtxText.Name = "rtxText";
            this.rtxText.Size = new System.Drawing.Size(620, 67);
            this.rtxText.TabIndex = 5;
            this.rtxText.Text = "48 hours to do the deadlines :D";
            // 
            // LinhEiLeftMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlChat);
            this.Name = "LinhEiLeftMessage";
            this.Size = new System.Drawing.Size(743, 94);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.RichTextBox rtxText;
    }
}
