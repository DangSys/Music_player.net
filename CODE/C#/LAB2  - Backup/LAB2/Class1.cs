using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;

namespace LAB2
{
    internal class Class1
    {
        //windows V: show clipboard history
        //Windows Tab

        public static string fullPath = "C:\\Users\\CCNP Enterprise Core" +
           "\\Desktop\\C#\\DataStructure\\Sample.txt";
        
        public static int index = 0;

        public static PictureBox[] picArr = new PictureBox[30];

        public static string[] videoURLArr = new string[30];    

        public static string[] songArr = new string[30];

        public static string[] singerArr = new string[30];

        //public static WindowsMediaPlayer axWMP =
        //    new WindowsMediaPlayer();
    }
}
