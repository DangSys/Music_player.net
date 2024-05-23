namespace LAB2
{
    partial class PlayedRecent
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
            this.picMusicPlayed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicPlayed)).BeginInit();
            this.SuspendLayout();
            // 
            // picMusicPlayed
            // 
            this.picMusicPlayed.Location = new System.Drawing.Point(0, 0);
            this.picMusicPlayed.Name = "picMusicPlayed";
            this.picMusicPlayed.Size = new System.Drawing.Size(76, 101);
            this.picMusicPlayed.TabIndex = 0;
            this.picMusicPlayed.TabStop = false;
            // 
            // PlayedRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picMusicPlayed);
            this.Name = "PlayedRecent";
            this.Size = new System.Drawing.Size(77, 101);
            ((System.ComponentModel.ISupportInitialize)(this.picMusicPlayed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMusicPlayed;
    }
}
