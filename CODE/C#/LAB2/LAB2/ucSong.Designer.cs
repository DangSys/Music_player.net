namespace LAB2
{
    partial class ucSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSong));
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.btnPlaylistAdd = new System.Windows.Forms.PictureBox();
            this.picLove = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylistAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(3, 8);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(86, 118);
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Cascadia Mono", 13F);
            this.lblSong.Location = new System.Drawing.Point(95, 10);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(130, 29);
            this.lblSong.TabIndex = 1;
            this.lblSong.Text = "Song Name";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Font = new System.Drawing.Font("Cascadia Mono", 13F);
            this.lblSinger.Location = new System.Drawing.Point(95, 47);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(91, 29);
            this.lblSinger.TabIndex = 3;
            this.lblSinger.Text = "Singer";
            // 
            // btnPlaylistAdd
            // 
            this.btnPlaylistAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylistAdd.Image")));
            this.btnPlaylistAdd.Location = new System.Drawing.Point(103, 89);
            this.btnPlaylistAdd.Name = "btnPlaylistAdd";
            this.btnPlaylistAdd.Size = new System.Drawing.Size(57, 50);
            this.btnPlaylistAdd.TabIndex = 5;
            this.btnPlaylistAdd.TabStop = false;
            this.btnPlaylistAdd.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
            // 
            // picLove
            // 
            this.picLove.Image = ((System.Drawing.Image)(resources.GetObject("picLove.Image")));
            this.picLove.Location = new System.Drawing.Point(178, 89);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(50, 50);
            this.picLove.TabIndex = 6;
            this.picLove.TabStop = false;
            this.picLove.Click += new System.EventHandler(this.btnLoveAdd_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(246, 90);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(55, 50);
            this.picPlay.TabIndex = 7;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picDownload
            // 
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(318, 89);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(57, 50);
            this.picDownload.TabIndex = 8;
            this.picDownload.TabStop = false;
            this.picDownload.Click += new System.EventHandler(this.picDownload_Click);
            // 
            // ucSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picDownload);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picLove);
            this.Controls.Add(this.btnPlaylistAdd);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.picPicture);
            this.Name = "ucSong";
            this.Size = new System.Drawing.Size(440, 150);
            this.Load += new System.EventHandler(this.ucSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylistAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.PictureBox btnPlaylistAdd;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picDownload;
    }
}
