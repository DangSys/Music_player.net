namespace LAB2
{
    partial class ucMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusic));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.pnlSongList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(123, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ballad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCountry
            // 
            this.btnCountry.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.btnCountry.Location = new System.Drawing.Point(234, 15);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(126, 33);
            this.btnCountry.TabIndex = 6;
            this.btnCountry.Text = "Country";
            this.btnCountry.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Teal;
            this.txtSearch.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 55);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(440, 53);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Search Song Here";
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Teal;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(394, 62);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(37, 35);
            this.picSearch.TabIndex = 8;
            this.picSearch.TabStop = false;
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Lavender;
            this.pnlSongList.Location = new System.Drawing.Point(12, 114);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(440, 655);
            this.pnlSongList.TabIndex = 9;
            this.pnlSongList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSongList_Paint);
            // 
            // ucMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pnlSongList);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ucMusic";
            this.Size = new System.Drawing.Size(455, 772);
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Panel pnlSongList;

    }
}
