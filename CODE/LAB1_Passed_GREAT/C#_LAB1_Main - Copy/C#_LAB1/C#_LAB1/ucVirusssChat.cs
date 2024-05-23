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
        int yAxis = 120;
        public ucVirusssChat()
        {
            InitializeComponent();
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
           
            VirusssLeftMessage leftMessage = new VirusssLeftMessage();
            leftMessage.SetLabelText = rtxMessage.Text;
            //leftMessage.AddImagePictureBox();
            leftMessage.Location = new System.Drawing.Point(xAxis, yAxis);
            yAxis += 60;
            pnlChat.Controls.Add(leftMessage);
            rtxMessage.Text = null;
            //leftMessage.MouseUp += new MouseEventHandler(
            //              delegate (object sender1, MouseEventArgs e1)
            //              { HideCaret((sender1 as Control).Handle); });
            //leftMessage.Paint += AddLabelHighlight;


            
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
