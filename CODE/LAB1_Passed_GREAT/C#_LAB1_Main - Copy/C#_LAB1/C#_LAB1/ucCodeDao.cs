using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace C__LAB1
{

    public partial class ucCodeDao : UserControl
    {
        int xAxis = 3;
        int yAxis = 160;

        int emotionIndex = 0;
        Image[] emotionArr = new Image[10];

        int imageIndex = 0;
        Image[] imageArr = new Image[10];

        public static int historyImageIndex = 0;
        public static Image[] historyImageArr = new Image[10];

        public static int historyMediaPlayerIndex = 0;
       //public static WindowsMediaPlayer[] historyMediaPlayerArr = new WindowsMediaPlayer[10];

        string msg;

        public static ucCodeDao It;

        public static int emotionNum = 0;

        int numberHistoryClick = 0;

        Panel pnlHistory = new Panel();

        //ScrollBar vScrollBar1 = new VScrollBar();

        public ucCodeDao()
        {
            InitializeComponent();
            this.pnlEmotion.Visible = false;
            It = this;

            //Autoscroll Of panel Control
            pnlChat.AutoScroll = true;
            pnlChat.AutoScroll = false;
            pnlChat.HorizontalScroll.Enabled = false;
            pnlChat.HorizontalScroll.Visible = false;
            pnlChat.HorizontalScroll.Maximum = 0;
            pnlChat.AutoScroll = true;

            //vScrollbar
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) =>
            //{ pnlChat.VerticalScroll.Value = vScrollBar1.Value; };
            //pnlChat.Controls.Add(vScrollBar1);
            //foreach

            pnlHistory.Size = new System.Drawing.Size(700, 450);
            pnlHistory.Location = new System.Drawing.Point(xAxis, 0);
            pnlHistory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            pnlHistory.AutoScroll = true;
            pnlHistory.Visible = false;
            this.Controls.Add(pnlHistory);
            
        }

        public static String Message
        {
            get { return It.rtxMessage.Text; }
            set { It.rtxMessage.Text = value; }
        }

        public static Image[] emotion
        {
            get { return It.emotionArr; }
            set { It.emotionArr = value; }
        }

        public Boolean SetVisible
        {
            set { pnlChat.Visible = value; }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CodeDaoLeftMessage leftMessage = new CodeDaoLeftMessage();
            leftMessage.Location = new System.Drawing.Point(xAxis, yAxis);
            // If there is a image ?

            //msg = rtxMessage.Text;
            //leftMessage.AddImagePictureBox();

            leftMessage.SetLabelText = rtxMessage.Text;
            foreach (Image emotion in emotionArr)
            {
                if (emotion != null)
                {
                    leftMessage.AddEmotion = emotion;
                    //emotionNum++;
                }

            }

            //Add control into panel
            pnlChat.Controls.Add(leftMessage);

            //End this line 
            yAxis += 90;

            //Reset all variables
            emotionNum = 0;

            for (int i = 0; i < emotionArr.Length; i++)
            {
                emotionArr[i] = null;
            }

            rtxMessage.Text = null;
            emotionIndex = 0;


            //if (rtxMessage.Text != null)
            //{

            //}


            //foreach (Image image in imageArr)
            //{
            //    if (image != null)
            //    {

            //    }
            //}





            //MessageBox.Show("Clicked!!!");




            //for (int i = 0; i < imageArr.Length; i++)
            //{
            //    imageArr[i] = null;
            //}


        }
        private void btnAttach_Click(object sender, EventArgs e)
        {


            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Select Valid Document(*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Add user Avatar

                Image image = Image.FromFile(@"D:\\THIS LAPTOP\\7.png");
                PictureBox picAva = new PictureBox();
                picAva.Image = image;
                picAva.Size = new Size(70, 56);
                picAva.Location = new System.Drawing.Point(xAxis + 12, yAxis);
                pnlChat.Controls.Add(picAva);

                foreach (string fileName in dialog.FileNames)
                {
                    // do something with path
                    Image img = Image.FromFile(fileName);
                    PictureBox picImage = new PictureBox();
                    picImage.Image = img;
                    picImage.Size = new Size(500, 200);
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    picImage.Location = new System.Drawing.Point(xAxis + 80, yAxis);

                    pnlChat.Controls.Add(picImage);

                    yAxis += 220;

                    //Saving Image Files
                    historyImageArr[historyImageIndex] = img;
                    historyImageIndex++;
                }

                //Remove space of the last element
                yAxis -= 260;

                //End this line
                yAxis += 90;
            }

            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Multiselect = false;
            //openFileDialog1.FileName = "";
            //DialogResult result = openFileDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    Image img = Image.FromFile(openFileDialog1.FileName);
            //    CodeDaoLeftPicture leftPicture = new CodeDaoLeftPicture();
            //    leftPicture.AddImages = img;
            //    leftPicture.Location = new System.Drawing.Point(xAxis, yAxis);

            //    //PictureBox pictureBox = new PictureBox();
            //    //pictureBox.Image = img;
            //    //pictureBox.Size = new Size(500, 200);
            //    //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    //pictureBox.Location = new System.Drawing.Point(xAxis + 20, yAxis);


            //    pnlChat.Controls.Add(leftPicture);
            //}

            //yAxis += leftPicture.Location.y;
        }

        private void btnEmotion_Click(object sender, EventArgs e)
        {
            this.pnlEmotion.Visible = true;

        }

        private void btnEmotion1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnEmotion2_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo1.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnEmotion3_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo2.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnEmotion4_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo3.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnEmotion5_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo4.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnEmotion6_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo8.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            rtxMessage.AppendText(" ");
            rtxMessage.Paste();

            pnlEmotion.Visible = false;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Select Valid Document(*.mp3; *.mp4)|*.mp3; *.mp4";
            ////dialog.Multiselect = true;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{          
                
            //    CodeDaoLeftMediaPlayer leftMediaPlayer = new CodeDaoLeftMediaPlayer();
            //    leftMediaPlayer.Location = new System.Drawing.Point(xAxis + 3, yAxis);
            //    leftMediaPlayer.SetMediaPlayerURL = dialog.FileName;
            //    pnlChat.Controls.Add(leftMediaPlayer);

            //    //Saving Video files -- Bugs here :D
            //    historyMediaPlayerArr[historyMediaPlayerIndex].URL = dialog.FileName;
            //    historyMediaPlayerIndex++;
            //}

            ////End this line
            //yAxis += 320; 
        }

        //Need to check
        private void btnHistory_Click(object sender, EventArgs e)
        {
            numberHistoryClick++;

            if (numberHistoryClick % 2 != 0)
            {
                pnlHistory.Visible = true;
                pnlChat.Visible = false;
            }

            if (numberHistoryClick % 2 == 0)
            {
                pnlHistory.Visible = false;
                pnlChat.Visible = true;
            }

            int xAxisHis = 23;
            int yAxisHis = 0;

            foreach (Image img in historyImageArr) 
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = img;
                pictureBox.Size = new Size(500, 200);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(xAxisHis, yAxisHis);
                pnlHistory.Controls.Add(pictureBox);

                yAxisHis += 220;
            }

            //foreach (AxWindowsMediaPlayer video in historyMediaPlayerArr)
            //{
            //    historyVideo ucHistoryVideo = new historyVideo();
            //    ucHistoryVideo.SetMediaPlayer = video;
            //    ucHistoryVideo.Location = new System.Drawing.Point(xAxisHis, yAxisHis);
            //    pnlHistory.Controls.Add(ucHistoryVideo);

            //    yAxisHis += 320;
            //}

        }
    }
}
