using AxWMPLib;
using C__LAB1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace C__LAB1
{
    public partial class CodeDaoLeftMediaPlayer : UserControl
    {
        AxWindowsMediaPlayer axwmp = new AxWindowsMediaPlayer();
        
        //WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public CodeDaoLeftMediaPlayer()
        {
            InitializeComponent();
            this.axwmp.Enabled = true;
            this.axwmp.Location = new System.Drawing.Point(109, 4);
            this.axwmp.Name = "axWindowsMediaPlayer1";
            this.axwmp.Size = new System.Drawing.Size(491, 366);
            this.axwmp.TabIndex = 2;
        }

        public string SetMediaPlayerURL
        {
            set
            {
                axwmp.URL = value;
            }
        }


    }
}
