using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB2
{
    public partial class ucSong : UserControl
    {
        int index;

        public ucSong()
        {
            InitializeComponent();
        }

        public int SetIndex
        {
            set
            {
                index = value;
            }

        }

        public string SetLabelSong
        {
            set
            {
                lblSong.Text = value;
            }
        }

        public string SetLabelSinger
        {
            set
            {
               lblSinger.Text = value;
            }
        }

        public Image SetImage
        {
            set
            {
                picPicture.Image = value;
            }
        }

        private void ucSong_Load(object sender, EventArgs e)
        {

        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            //Class1.axWMP.URL = Class1.videoURLArr[index];
            



        }
    }
}
