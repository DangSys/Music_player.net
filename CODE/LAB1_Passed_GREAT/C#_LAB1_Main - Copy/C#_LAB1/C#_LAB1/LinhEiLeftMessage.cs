using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__LAB1
{
    public partial class LinhEiLeftMessage : UserControl
    {
        public LinhEiLeftMessage()
        {
            InitializeComponent();
        }
        public string SetLabelText
        {
            get { return lblText.Text; }
            set
            {
                lblText.Text = value;
            }
        }
    }
}
