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

        private void llbVIE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSignUp.Text = "Đăng ký";
            lblFirstName.Text = "Tên";
            lblLastName.Text = "Họ";
            lblEmail.Text = "Hòm thư điện tử";
            lblUsername.Text = "Tên đăng nhập";
            lblPassword.Text = "Mật khẩu";
            lblConfirmPassword.Text = "Xác nhận mật khẩu";
            btnAvatar.Text = "Cập nhật ảnh đại diện";
            lblLinkAvatar.Text = "Đường dẫn ảnh đại diện";
            lblTerm.Text = "Đồng ý với các chính sách bảo mật của chúng tôi";
            btnSignUp.Text = "Đăng ký";
            lblAlready.Text = "Bạn đã có tài khoản?";
            llbLogin.Text = "Đăng nhập tại đây";
            lblCopyright.Text = "Bản quyền thuộc về © dangvq.uit";
        }

        private void lblENG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSignUp.Text = "Sign Up";
            lblFirstName.Text = "First Name";
            lblLastName.Text = "Last Name";
            lblEmail.Text = "Email";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            lblConfirmPassword.Text = "Confirm Password";
            btnAvatar.Text = "Update your avatar";
            lblLinkAvatar.Text = "Link Avatar";
            lblTerm.Text = "I accept the Terms of Use and Privacy Policy";
            btnSignUp.Text = "Sign Up";
            lblAlready.Text = "Already have an account?";
            llbLogin.Text = "Login here";
            lblCopyright.Text = "Copyright © dangvq.uit";
        }


        private void btnLight_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            lblSignUp.ForeColor = Color.Black;
            lblFirstName.ForeColor = Color.Black;
            lblLastName.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblUsername.ForeColor = Color.Black;
            lblPassword.ForeColor = Color.Black;
            lblConfirmPassword.ForeColor = Color.Black;
            btnAvatar.BackColor = Color.White;
            btnAvatar.ForeColor = Color.Black;
            lblTerm.ForeColor = Color.Black;
            btnSignUp.BackColor = Color.White;
            btnSignUp.ForeColor = Color.Black;
            lblAlready.ForeColor = Color.Black;
            llbLogin.LinkColor = System.Drawing.Color.Black;
            lblCopyright.ForeColor = Color.Black;

        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(53)))), ((int)(((byte)(105)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None; ;
            lblSignUp.ForeColor = System.Drawing.SystemColors.Control;
            lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            lblLastName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            lblEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            btnAvatar.BackColor = System.Drawing.Color.DimGray;
            btnAvatar.ForeColor = System.Drawing.SystemColors.ControlText;
            lblTerm.ForeColor = Color.White;
            btnSignUp.BackColor = System.Drawing.Color.DimGray;
            btnSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            lblAlready.ForeColor = Color.White;
            llbLogin.ForeColor = Color.White;
            lblCopyright.ForeColor = Color.White;
        }




        //frmSignIn siFrm = new frmSignIn();
        //siFrm.ShowDialog();
        //    siFrm.Visible
    }
}
