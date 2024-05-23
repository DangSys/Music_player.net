using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.IO;

namespace LAB2
{


    public partial class DashBoard : Form
    {
        ucHome ucHome = new ucHome();
        ucMusic ucMusic = new ucMusic();


        public DashBoard()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            picHome.BackColor = Color.White;
            picMusic.BackColor = Color.Gray;
            picDownload.BackColor = Color.Gray;
            picLove.BackColor = Color.Gray;


            ucHome.Location = new System.Drawing.Point(0, 0);
            pnlDashBoard.Controls.Add(ucHome);
            pnlDashBoard.Controls.Remove(ucMusic);
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            picMusic.BackColor = Color.White;
            picHome.BackColor = Color.Gray;
            picDownload.BackColor = Color.Gray;
            picLove.BackColor = Color.Gray;

            ucMusic.Location = new System.Drawing.Point(0, 0);
            pnlDashBoard.Controls.Add(ucMusic);
            pnlDashBoard.Controls.Remove(ucHome);
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            picDownload.BackColor = Color.White;
            picHome.BackColor = Color.Gray;
            picMusic.BackColor = Color.Gray;
            picLove.BackColor = Color.Gray;
        }

        private void picLove_Click(object sender, EventArgs e)
        {
            picLove.BackColor = Color.White;
            picHome.BackColor = Color.Gray;
            picMusic.BackColor = Color.Gray;
            picDownload.BackColor = Color.Gray;
        }

        private void pnlDashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //Read Data from file
            // Just for those who do not understand: If you have a database
            // like MySQL or MongoDB or sth. Just setup and your database 
            // always there. Just query from database.
            // This is the file. So when your need sth, the first thing
            // is to import datas into format you can use them. Just once!

            //May tk em pass duoc VoIP day, ko sao :D

            var MusicLines = File.ReadAllLines(Class1.fullPath);

            //string[] videoURLArr = new string[30];

            //string[] songArr = new string[30];

            //string[] singerArr = new string[30];


            foreach (var musicLine in MusicLines)
            {
                // Must know what you are doing !!!
                // Please be awaked !!!
                var music = musicLine.Split('*');

                //Class1.pictureBoxUriArr[Class1.index] = new Uri(music[1].Trim());

                //Class1.picArr[Class1.index].Image =
                //    new System.Drawing.Bitmap(Class1.pictureBoxUriArr[Class1.index]);

                //string fileName = music[1].Trim();

                

                Class1.picArr[Class1.index] = new PictureBox();

                Class1.picArr[Class1.index].Image = Image.FromFile(music[1].Trim());

                //Class1.picArr[Class1.index].Image = 
                //    Image.FromFile
                //    ("C:\\Users\\CCNP Enterprise Core\\Desktop\\C#" +
                //    "\\DataStructure\\Music\\Picture\\n.jpg");

                Class1.videoURLArr[Class1.index] = music[2].Trim();

                Class1.songArr[Class1.index] = music[3].Trim();

                Class1.singerArr[Class1.index] = music[4].Trim();

                Class1.index++;

                //Class1.picArr[Class1.index].ImageLocation =
                //    music[1].Trim();

                //string uriString = @music[1].Trim();
                //picArr[index].Image = new System.Drawing.Bitmap(new Uri(uriString as Uri));    
            }
        }
    }
}
