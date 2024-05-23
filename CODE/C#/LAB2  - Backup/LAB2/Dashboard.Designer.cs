namespace LAB2
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picMusic = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.picLove = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(29, 10);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(66, 61);
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            this.picHome.UseWaitCursor = true;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picMusic
            // 
            this.picMusic.Image = ((System.Drawing.Image)(resources.GetObject("picMusic.Image")));
            this.picMusic.Location = new System.Drawing.Point(145, 10);
            this.picMusic.Name = "picMusic";
            this.picMusic.Size = new System.Drawing.Size(64, 61);
            this.picMusic.TabIndex = 1;
            this.picMusic.TabStop = false;
            this.picMusic.UseWaitCursor = true;
            this.picMusic.Click += new System.EventHandler(this.picMusic_Click);
            // 
            // picDownload
            // 
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(260, 10);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(65, 61);
            this.picDownload.TabIndex = 2;
            this.picDownload.TabStop = false;
            this.picDownload.UseWaitCursor = true;
            this.picDownload.Click += new System.EventHandler(this.picDownload_Click);
            // 
            // picLove
            // 
            this.picLove.Image = ((System.Drawing.Image)(resources.GetObject("picLove.Image")));
            this.picLove.Location = new System.Drawing.Point(363, 10);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(65, 61);
            this.picLove.TabIndex = 3;
            this.picLove.TabStop = false;
            this.picLove.UseWaitCursor = true;
            this.picLove.Click += new System.EventHandler(this.picLove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.picLove);
            this.panel1.Controls.Add(this.picDownload);
            this.panel1.Controls.Add(this.picMusic);
            this.panel1.Controls.Add(this.picHome);
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 74);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(456, 769);
            this.pnlDashBoard.TabIndex = 3;
            this.pnlDashBoard.UseWaitCursor = true;
            this.pnlDashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashBoard_Paint);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 840);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(120000, 200);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picMusic;
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDashBoard;
    }
}

