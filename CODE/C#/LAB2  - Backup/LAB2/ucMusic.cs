using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB2
{
    public partial class ucMusic : UserControl
    {
        ucSong[] ucSongArr = new ucSong[30];

        // Kernel programming is different with network programming
        // Power of this is great. Need to more positive altitude....


        public ucMusic()
        {
            InitializeComponent();
        }

        private void pnlSongList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Music_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ucSongArr.Length; i++)
            {
                ucSongArr[i] = new ucSong();
                
                ucSongArr[i].SetIndex = i;

                ucSongArr[i].SetImage = Class1.picArr[i].Image;

                ucSongArr[i].SetLabelSinger = Class1.singerArr[i];

                ucSongArr[i].SetLabelSong = Class1.songArr[i];

                //85

                ucSongArr[i].Location = new Point(0, i * 85);

                pnlSongList.Controls.Add(ucSongArr[i]);

                // Ngay xua choi game xep gach ma`dau dau`, h hoc cntt
                
                //mua bao cat

                
            }

            //ucSong song1 = new ucSong();

            //song1.SetImage = Class1.picArr[0].Image;

            //song1.SetLabelSinger = Class1.singerArr[0];

            //song1.SetLabelSong = Class1.songArr[0]; 

            //song1.Location = new System.Drawing.Point(0, 0);

            //pnlSongList.Controls.Add(song1);
        }
    }
}
