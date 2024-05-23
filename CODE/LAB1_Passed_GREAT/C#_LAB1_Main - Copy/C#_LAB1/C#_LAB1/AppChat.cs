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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;



namespace C__LAB1
{
   

    public partial class frmAppChat : Form
    {
        //int[][] locationArr = new int[4][]; 
        int xAxis = 0;
        int yAxis = 5;

        ucVirusssChat ucV = new ucVirusssChat();
        ucLinhEiChat ucL = new ucLinhEiChat();
        ucCodeDao ucC = new ucCodeDao();  

        int emotionIndex = 0;
        Image[] emotionArr = new Image[30];

        int imageIndex = 0;
        Image[] imageArr = new Image[30];



        public frmAppChat()
        {
            InitializeComponent();
            
        }

       

        private void btnSend_Click(object sender, EventArgs e)
        {

           // VirusssLeftMessage leftMessage = new VirusssLeftMessage();
           //// leftMessage.SetLabelText = rtxMessage.Text;
           // //leftMessage.AddImagePictureBox();
           // leftMessage.Location = new System.Drawing.Point(xAxis, yAxis);
           // yAxis += 60;
            //pnlVirusssChat.Controls.Add(leftMessage);

            // bot weigh dau roi!!!, chien quoa !!!! chuot kieu logitech gx-02

            //foreach (Image emotion in emotionArr)
            //{
            //    if (emotion != null)
            //    {
            //        leftMessage.AddImagePictureBox(emotion);
            //    }
            //}


            //if (rtxMessage.Text != null)
            //{
              
            //}


            //foreach (Image image in imageArr)
            //{
            //    if (image != null)
            //    {

            //    }
            //}





            MessageBox.Show("Clicked!!!");

            //rtxMessage.Text = null;

            for (int i = 0; i < emotionArr.Length; i++)
            {
                emotionArr[i] = null;
            }

            for (int i = 0; i < imageArr.Length; i++)
            {
                imageArr[i] = null;
            }
        }

        //public void InsertImage()
        //{

        //    string lstrFile = OpenfileDialog.FileName;
        //    Bitmap myBitmap = new Bitmap(lstrFile);
        //    // Copy the bitmap to the clipboard.
        //    Clipboard.SetDataObject(myBitmap);
        //    // Get the format for the object type.
        //    DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
        //    // After verifying that the data can be pasted, paste
        //    if (NoteBox.CanPaste(myFormat))
        //    {
        //        NoteBox.Paste(myFormat);
        //    }
        //    else
        //    {
        //        MessageBox.Show("The data format that you attempted site" +
        //          " is not supported by this control.");
        //    }            
        //}

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                imageArr[imageIndex] = img;
                imageIndex++;

                MessageBox.Show(openFileDialog1.FileName.ToString());
                Clipboard.SetImage(img);
                //rtxMessage.Paste();

                //Clipboard.SetImage(img);
                //rtxChat.Paste();
                
                //rtxChat.AppendText(" --- Dang Vo \n");
                //rtxChat.Focus();
            }
            //else
            //{
            //    richTextBox1.Focus();
            //}
        }


    
        private void btnEmotion_Click(object sender, EventArgs e)
        {
            //pnlEmotion.Visible = true;
        }

        

        // mua dien thoai giong hoi`web di, hoac la rot mon thauuuuu, chon di nhanh len....
        private void btnEmotion1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            //rtxMessage.AppendText(" ");
            //rtxMessage.Paste(); 

            //pnlEmotion.Visible = false;
        }

        private void btnEmotion2_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo1.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            //rtxMessage.AppendText(" ");
            //rtxMessage.Paste();

            //pnlEmotion.Visible = false;

        }

        private void btnEmotion3_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo2.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            //rtxMessage.AppendText(" ");
           // rtxMessage.Paste();

            //pnlEmotion.Visible = false;
        }

        private void btnEmotion4_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo3.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            //rtxMessage.AppendText(" ");
           // rtxMessage.Paste();

            //pnlEmotion.Visible = false;
        }

        private void btnEmotion5_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo4.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
            //rtxMessage.AppendText(" ");
           // rtxMessage.Paste();

            //pnlEmotion.Visible = false; 
        }

        private void btnEmotion6_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"D:\\Emotion\\emo5.png");
            emotionArr[emotionIndex] = img;
            emotionIndex++;

            Clipboard.SetImage(img);
           // rtxMessage.AppendText(" ");
            //rtxMessage.Paste();

            //pnlEmotion.Visible = false;
        }

        private void btnVirusss_Click(object sender, EventArgs e)
        {
            //pnlVirusssChat.Visible = true;
            //pnlLinhEi.Visible = false;
            //ucVirusssChat.

            //ucVirusssChat ucViruss = new ucVirusssChat();
            //ucViruss.SetLocation = new Point(395, 10);

            //pnlChatV.Visible = true;
            //pnlChatL.Visible = false;


            // leftMessage.SetLabelText = rtxMessage.Text;
            //leftMessage.AddImagePictureBox();

            //VirusssLeftMessage msgVL = new VirusssLeftMessage();
            //msgVL.Location = new System.Drawing.Point(xAxis, yAxis);
            //pnlChat.Controls.Add(msgVL);
            //yAxis += 60;

            //VirusssRightMessage msgVR = new VirusssRightMessage();
            //msgVR.Location = new System.Drawing.Point(xAxis + 400, yAxis);
            //pnlChat.Controls.Add(msgVR);
            //yAxis += 60;

            ucV.Location = new System.Drawing.Point(0, 0);
            pnlChat.Controls.Add(ucV);
            pnlChat.Controls.Remove(ucL);
            pnlChat.Controls.Remove(ucC);
        }

        private void btnLinh_Click(object sender, EventArgs e)
        {
            //pnlVirusssChat.Visible = false;
            //pnlLinhEi.Visible = true;

            //pnlChatL.Visible = true;
            //pnlChatV.Visible=false;

            
            ucL.Location = new System.Drawing.Point(0, 0);
            pnlChat.Controls.Add(ucL);
            pnlChat.Controls.Remove(ucV);
            pnlChat.Controls.Remove(ucC);
        }
     

        private void btnCodeDao_Click(object sender, EventArgs e)
        {
            ucV.Location = new System.Drawing.Point(0, 0);
            pnlChat.Controls.Add(ucC);
            pnlChat.Controls.Remove(ucV);
            pnlChat.Controls.Remove(ucL);
        }
    }
}

