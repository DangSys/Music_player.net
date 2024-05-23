using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__LAB1
{
    public partial class LinhEiLeftMessage : UserControl
    {
        public LinhEiLeftMessage()
        {
            InitializeComponent();
        }
        public string SetText
        {
            get { return rtxText.Text; }
            set
            {
                rtxText.Text = value;
            }
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

    }
}
