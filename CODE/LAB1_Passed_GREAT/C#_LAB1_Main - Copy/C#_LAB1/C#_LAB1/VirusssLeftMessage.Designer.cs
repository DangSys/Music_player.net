namespace C__LAB1
{
    partial class VirusssLeftMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirusssLeftMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
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
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.lblText);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(629, 70);
            this.panel.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblText.Location = new System.Drawing.Point(102, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(457, 31);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Trust me pls!!! I will finish this project";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            this.lblText.Paint += new System.Windows.Forms.PaintEventHandler(this.lblText_Paint);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseDown);
            this.lblText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseMove);
            // 
            // VirusssLeftMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel);
            this.Name = "VirusssLeftMessage";
            this.Size = new System.Drawing.Size(633, 73);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblText;
    }
}
