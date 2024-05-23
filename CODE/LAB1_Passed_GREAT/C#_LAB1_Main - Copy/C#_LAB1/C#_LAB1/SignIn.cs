using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

// Ae NetBeans IDE
// May nuoc kieu ngheo hon day :)))) b hay quoa LD
// ko phan bien do`:D
// Fearow
// Karants
// Levents
// Teelabs
// Underbroken
// Tia an lz a`
// ngu si do`:D :D b thi kinh roi`, thuong dang q10

// me thac si do` :D
// tai lieu tieng han` //smart logistics, supply chain do`:D
// ko bik so chu lecture trg minh nhu lz

// breath in, breath through, breath deep, breath out

namespace C__LAB1
{
    public partial class frmSignIn : Form
    {

        public static string fullPath
                     = "D:\\Database.txt";
        //public static string fullPath = "D:\\UIT_VNU\\2023-2024 HK2\\C#----------.NET_Front-End"+
        //    "\\Labs\\C#_LAB1_Main - Copy\\Database";

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var credentialLines = File.ReadAllLines(fullPath);

            bool trueLogin = false;

            foreach (var credentialLine in credentialLines)
            {
                var credential = credentialLine.Split('*');

                var username = credential[3].Trim();

                var password = credential[4].Trim();

                if (username == txtUsername.Text && password == txtPassword.Text)
                {
                    trueLogin = true;
                }
                //MessageBox.Show(username.ToString());
                //MessageBox.Show(password.ToString());
            }

            if (trueLogin == true)
            {
                MessageBox.Show("Successful Login", "Login", MessageBoxButtons.OK);
                this.Visible = false;
                frmAppChat appFrm = new frmAppChat();
                appFrm.Show();
            }
            else
                MessageBox.Show("Wrong Username or Password");

            //MessageBox.Show(txtUsername.Text);
            //MessageBox.Show(txtPassword.Text);  



            //MessageBox.Show(password.ToString());
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //smtpClient.EnableSsl = true;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new NetworkCredential("etheriumminerreal@gmail.com", "Mypast1234$");

            //MailMessage mailMessage = new MailMessage();
            //mailMessage.From = new MailAddress("etheriumminerreal@gmail.com");
            //mailMessage.To.Add("dangvq.uit@gmail.com");
            //mailMessage.Subject = "Hello from .NET";
            //mailMessage.Body = "This is a test email sent through Gmail SMTP in .NET";
            //smtpClient.Send(mailMessage);

            using (MailMessage mail = new MailMessage())
            {
                var credentialLines = File.ReadAllLines(fullPath);

                bool trueEmail = false;

                bool trueUsername = false;

                string password = null;

                foreach (var credentialLine in credentialLines)
                {
                    var credential = credentialLine.Split('*');

                    var email = credential[2].Trim();

                    var username = credential[3].Trim();

                    password = credential[4].Trim();

                    if (username == txtUsernameGetPass.Text)
                        trueUsername = true;

                    if (email == txtEmail.Text)
                    {
                        trueEmail = true;

                        
                        //MessageBox.Show(username.ToString());
                        //MessageBox.Show(password.ToString());
                    }
                    //MessageBox.Show("Email Sent."); 
                }

                if (trueEmail == true && trueUsername == true)
                {
                    mail.From = new MailAddress("19520447@gm.uit.edu.vn");
                    mail.To.Add(txtEmail.Text);
                    mail.Subject = "Password Recovery for C# Chatting App";
                    mail.Body = "<h1>Your password: <h1>" + "<h1>" + password + "<h1>";
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("19520447@gm.uit.edu.vn", "1054900370");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }

                    MessageBox.Show("Email Sent.");
                }

                if (trueEmail == false)
                    MessageBox.Show("Wrong Email Address.");

                if (trueUsername == false)
                    MessageBox.Show("Wrong Username");
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
        }

        private void txtUsername_MouseDown(object sender, MouseEventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsernameGetPass_TextChanged(object sender, EventArgs e)
        {
            lblUsernameGetPass.Visible = false;
        }

      
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            lblUsername.Visible = false;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
     
            lblPassword.Visible = false;
        
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            lblEmail.Visible = false;  
        }

        private void txtUsernameGetPass_MouseClick(object sender, MouseEventArgs e)
        {
            lblUsernameGetPass.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmSignUp suFrm = new frmSignUp();
            suFrm.Show();
        }
    }
}
