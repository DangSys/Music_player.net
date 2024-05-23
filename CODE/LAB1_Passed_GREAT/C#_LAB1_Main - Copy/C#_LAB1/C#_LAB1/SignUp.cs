using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__LAB1
{

    //static string linkDB;
    public partial class frmSignUp : Form
    {
        public static string fullPath
                    = "D:\\Database.txt";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFirstName.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblConfirmPassword.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password is not as the same as Confirm Password. Please try a again.");
            }
            else if (rdoTerm.Checked == false)
            {
                MessageBox.Show("Please accept our Terms of Use and Privacy Policy.");
            }
            else
            {
                MessageBox.Show("Signing up Successful.");

                //string fullPath
                //    = "D:\\Database.txt";

                StreamWriter sw = File.AppendText(fullPath);
                sw.WriteLine(txtFirstName.Text + " * " + txtLastName.Text + " * "
                    + txtEmail.Text + " * " + txtUsername.Text + " * "
                    + txtPassword.Text + " * " + lblLinkAvatar.Text + "");
                sw.Close();
            }
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmSignIn siFrm = new frmSignIn();
            siFrm.Show();

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = @ "D:\";
            openFileDialog1.Title = "Save text Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFileDialog1.FileName;
                lblLinkAvatar.Text = openFileDialog1.FileName;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
        }



        //frmSignIn siFrm = new frmSignIn();
        //siFrm.ShowDialog();
        //    siFrm.Visible
    }
}
