﻿using System;
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
    public partial class LinhEiRightMessage : UserControl
    {
        public LinhEiRightMessage()
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
    }
}
