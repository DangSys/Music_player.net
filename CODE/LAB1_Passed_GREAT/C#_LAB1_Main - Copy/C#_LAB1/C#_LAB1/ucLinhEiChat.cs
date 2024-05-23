using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace C__LAB1
{
    public partial class ucLinhEiChat : UserControl
    {
        int xAxis = 3;
        int yAxis = 120;

        public ucLinhEiChat()
        {
            InitializeComponent();
        }

        private void pnlLinhEiChat_Load(object sender, EventArgs e)
        {
            pnlEmotion.Visible = false;
        }

        private void btnSendL_Click(object sender, EventArgs e)
        {
            LinhEiLeftMessage leftMessage = new LinhEiLeftMessage();
            leftMessage.SetLabelText = rtxMessage.Text;
            //leftMessage.AddImagePictureBox();
            leftMessage.Location = new System.Drawing.Point(xAxis, yAxis);
            yAxis += 60;
            pnlChat.Controls.Add(leftMessage);
            rtxMessage.Text = null;


        }
    }
}
