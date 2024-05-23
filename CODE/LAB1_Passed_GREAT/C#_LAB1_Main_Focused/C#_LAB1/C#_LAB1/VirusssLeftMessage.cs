﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// quen voi nhung con so

namespace C__LAB1
{
    public partial class VirusssLeftMessage : UserControl
    {
        float startX = new float();
        float endX = new float();

        public VirusssLeftMessage()
        {
            InitializeComponent();
        }

        public Color SetColor
        {
            set
            {
                pnlChat.BackColor = value;
                rtxText.BackColor = value;

                if (value == System.Drawing.Color.Black)
                {
                    rtxText.ForeColor = System.Drawing.Color.White;
                }
                if (value == System.Drawing.Color.White)
                {
                    rtxText.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        public string SetText
        {
            get { return rtxText.Text; }
            set { rtxText.Text = value; }
        }

        public System.Drawing.Image AddEmotion
        {
            set
            {
                System.Drawing.Image img = value;
                Clipboard.SetImage(img);
                rtxText.AppendText(" ");
                rtxText.Paste();
            }
        }

        public void AddLabelHighlight(object sender)
        {
            //Rectangle r = new Rectangle();
            //Graphics g = CreateGraphics();
            //var label = (Label)sender;
            //PaintEventArgs e = new PaintEventArgs(g, r);
            //e.Graphics.DrawRectangle(new Pen(Color.DeepPink, 12), label.R);
        }

        private void lblText_MouseDown(object sender, MouseEventArgs e)
        {

            //this.AddLabelHighlight(lblText);
            startX = e.Location.X;
            
        }

        private void lblText_MouseMove(object sender, MouseEventArgs e)
        {
            endX = e.Location.X;


            Rectangle r = new Rectangle();
            Graphics g = CreateGraphics();
            //var label = (System.Windows.Forms.Label) sender;
            PaintEventArgs pe = new PaintEventArgs(g, r);
            //pe.Graphics.DrawRectangle(new Pen(Color.DeepPink, 10),
            //    startX, endX, lblText.Width, lblText.Height);
            pe.Graphics.FillRectangle(new SolidBrush(Color.DeepPink), pe.ClipRectangle);


        }


        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void lblText_Paint(object sender, PaintEventArgs e)
        {
            //// Specify the text to draw
            //string text = "Text to draw";

            //// Specify the font and color for the text
            //Font font = lblText.Font;
            //Brush brush = new SolidBrush(lblText.ForeColor);

            //// Calculate the position to draw the text
            //SizeF textSize = e.Graphics.MeasureString(text, font);
            //float x = (lblText.Width - textSize.Width) / 2;
            //float y = (lblText.Height - textSize.Height) / 2;

            //// Draw the text on the label
            //e.Graphics.DrawString(text, font, brush, x, y);
        }

      




        //public void AddImagePictureBox()
        //{
        //    PictureBox pic = new PictureBox();
        //    Image imageTest = Image.FromFile(@"D:\\Emotion\\emo2.png");
        //    pic.Image = imageTest;
        //    this.Controls.Add(pic);
        //}


    }
}
