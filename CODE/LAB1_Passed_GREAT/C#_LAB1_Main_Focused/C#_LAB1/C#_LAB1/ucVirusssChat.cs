using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__LAB1
{
    /// <summary>
    /// Tai seo pnl dinh dang trong userControl ko load duoc tarrrr.....
    /// Dung nguoi sai thoi diem :D :D :D :D ahiiiiiiiiiii
    /// Cai gi gioi thi`hay~hoc chuyen sau cai do thoi ae a` :D :D LD
    /// </summary>
    
    public partial class ucVirusssChat : UserControl
    {
        int xAxis = 3;
        int yAxis = 160;

        int emotionIndex = 0;
        Image[] emotionArr = new Image[10];

        int imageIndex = 0;
        Image[] imageArr = new Image[10];

        int imageDateIndex = 0;
        DateTime[] imageDateArr = new DateTime[10];

        public static int historyImageIndex = 0;
        public static Image[] historyImageArr = new Image[10];

        public static int historyMediaPlayerIndex = 0;
        //public static WindowsMediaPlayer[] historyMediaPlayerArr = new WindowsMediaPlayer[10];

        public static int leftMessageIndex = 0;
        public static VirusssLeftMessage[] leftMessagesArr = new VirusssLeftMessage[10];


        string msg;

        public static ucCodeDao It;

        public static int emotionNum = 0;

        int numberHistoryClick = 0;

        Panel pnlHistory = new Panel();

        //ScrollBar vScrollBar1 = new VScrollBar();
        public ucVirusssChat()
        {
            InitializeComponent();

            pnlEmotion.Visible = false;

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


        private void AddLabelHighlight(object sender, PaintEventArgs e)
        {
            var label = sender as Label;
            e.Graphics.DrawRectangle(new Pen(Color.DeepPink, 8), label.ClientRectangle);
        }

        private void RemoveLabelHighlight(object sender, PaintEventArgs e)
        {
            var label = sender as Label;
            e.Graphics.DrawRectangle(new Pen(Color.Green, 8), label.ClientRectangle); // This should return the Label back to original state
        }

        //[DllImport("user32.dll")]
        //public static extern Boolean HideCaret(IntPtr hWnd);

        private void btnSend_Click(object sender, EventArgs e)
        {
            //leftMessage.MouseUp += new MouseEventHandler(
            //              delegate (object sender1, MouseEventArgs e1)
            //              { HideCaret((sender1 as Control).Handle); });
            //leftMessage.Paint += AddLabelHighlight;

            VirusssLeftMessage leftMessage = new VirusssLeftMessage();
            leftMessage.Location = new System.Drawing.Point(xAxis, yAxis);
            leftMessage.SetColor = pnlChat.BackColor;
            // If there is a image ?

            //msg = rtxMessage.Text;
            //leftMessage.AddImagePictureBox();

            leftMessage.SetText = rtxMessage.Text;
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

            //Add leftMessage into array
            leftMessagesArr[leftMessageIndex] = leftMessage;
            leftMessageIndex++;


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

                    //Saving dateTime
                    imageDateArr[imageDateIndex] = DateTime.Now;

                }

                //Remove space of the last element
                yAxis -= 260;

                //End this line
                yAxis += 90;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //Show|Hide HistoryPanel
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

            int dateIndex = 0;

            foreach (Image img in historyImageArr)
            {
                if (img != null)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = img;
                    pictureBox.Size = new Size(500, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new System.Drawing.Point(xAxisHis, yAxisHis);
                    pnlHistory.Controls.Add(pictureBox);

                    Label dateLabel = new Label();
                    dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif",
                        11F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dateLabel.Size = new System.Drawing.Size(100, 40);
                    dateLabel.Text = imageDateArr[imageDateIndex].ToString();
                    dateLabel.Location = new System.Drawing.Point(xAxisHis + 550, yAxisHis + 150);
                    pnlHistory.Controls.Add(dateLabel);

                    yAxisHis += 220;
                    dateIndex++;
                }
            }
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

        private void btnLight_Click(object sender, EventArgs e)
        {
            pnlChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            LeftMessage.SetColor = System.Drawing.Color.White;
            RightMessage.SetColor = System.Drawing.Color.White;

            foreach (VirusssLeftMessage leftMessage in leftMessagesArr)
            {
                if (leftMessage != null)
                    leftMessage.SetColor = Color.White;
            }
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            pnlChat.BackColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Black;

            LeftMessage.SetColor = System.Drawing.Color.Black;
            RightMessage.SetColor = System.Drawing.Color.Black;

            foreach (VirusssLeftMessage leftMessage in leftMessagesArr)
            {
                if (leftMessage != null)
                    leftMessage.SetColor = Color.Black;
            }
        }




        //public string SetLabelText
        //{
        //    get { return lblText.Text; }
        //    set
        //    {
        //        lblText.Text = value;
        //        //Swap qua network thauuuu

        //        //Label lbl = new Label(); 
        //        //Image imageTest = Image.FromFile(@"D:\\Emotion\\emo2.png");
        //        //lbl.Size = imageTest.Size;

        //        //lbl.Image = imageTest;

        //        //lbl.Location = lblText.Location + new Point(20,20);

        //        //lblText.Size = imageTest.Size;
        //        //lbl.BackColor = lblText.BackColor;
        //        //this.Controls.Add(lbl);
        //    }
        //}
    }
}
