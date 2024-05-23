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
            this.btnLoveAdd = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylistAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoveAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(3, 3);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(86, 79);
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(99, 6);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(128, 26);
            this.lblSong.TabIndex = 1;
            this.lblSong.Text = "Song Name";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinger.Location = new System.Drawing.Point(99, 56);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(75, 26);
            this.lblSinger.TabIndex = 3;
            this.lblSinger.Text = "Singer";
            // 
            // btnPlaylistAdd
            // 
            this.btnPlaylistAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylistAdd.Image")));
            this.btnPlaylistAdd.Location = new System.Drawing.Point(188, 32);
            this.btnPlaylistAdd.Name = "btnPlaylistAdd";
            this.btnPlaylistAdd.Size = new System.Drawing.Size(57, 50);
            this.btnPlaylistAdd.TabIndex = 5;
            this.btnPlaylistAdd.TabStop = false;
            // 
            // btnLoveAdd
            // 
            this.btnLoveAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnLoveAdd.Image")));
            this.btnLoveAdd.Location = new System.Drawing.Point(251, 32);
            this.btnLoveAdd.Name = "btnLoveAdd";
            this.btnLoveAdd.Size = new System.Drawing.Size(50, 50);
            this.btnLoveAdd.TabIndex = 6;
            this.btnLoveAdd.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(315, 32);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(55, 50);
            this.picPlay.TabIndex = 7;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picDownload
            // 
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(380, 32);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(57, 53);
            this.picDownload.TabIndex = 8;
            this.picDownload.TabStop = false;
            // 
            // ucSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picDownload);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.btnLoveAdd);
            this.Controls.Add(this.btnPlaylistAdd);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.picPicture);
            this.Name = "ucSong";
            this.Size = new System.Drawing.Size(440, 85);
            this.Load += new System.EventHandler(this.ucSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylistAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoveAdd)).EndInit();
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
        private System.Windows.Forms.PictureBox btnLoveAdd;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picDownload;
    }
}
