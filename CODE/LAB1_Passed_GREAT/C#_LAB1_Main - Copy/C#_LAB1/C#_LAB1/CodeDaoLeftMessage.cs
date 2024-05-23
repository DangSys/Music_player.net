using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace C__LAB1
{
    public partial class CodeDaoLeftMessage : UserControl
    {
        public CodeDaoLeftMessage()
        {
            InitializeComponent();
        }

        public string SetLabelText
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
                //PictureBox pic = new PictureBox();
                //pic.Image = img;
                //pic.Size = img.Size;

                //Point p = rtxText.Location;

                ////if (ucCodeDao.Message != null)

                //pic.Location = new 
                //        System.Drawing.Point(p.X + rtxText.Text.Length * 9 
                //        + ucCodeDao.emotionNum * 50 
                //        + 10, p.Y - 20);
                //    MessageBox.Show("Khac null");


                ////if (ucCodeDao.Message == null)
                ////{
                ////    pic.Location = new System.Drawing.Point(p.X, p.Y - 20);
                ////    MessageBox.Show("Bang null");
                ////}

                //pnlChat.Controls.Add(pic);
                //MessageBox.Show(rtxText.Text.Length.ToString());


                Clipboard.SetImage(img);
                rtxText.AppendText(" ");
                rtxText.Paste();
            }
        }

    }
      
        
    
}
