﻿using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mail = new MailMessage();
            var client = new SmtpClient("smtpcorp.com", 2525) 
            {
                Credentials = new NetworkCredential("ishantuf@gmail.com", "nvidiagtx680"),
                EnableSsl = true
            };
            mail.From = new MailAddress("info@ACME.com");
            mail.To.Add(txtForgetMail.Text);
            mail.Subject = "Password Lost";
            var plainView = AlternateView.CreateAlternateViewFromString("This is a text message", null, "text/plain");
            var htmlView = AlternateView.CreateAlternateViewFromString("<b>This is a html message</b>", null, "text/html");
            mail.AlternateViews.Add(plainView);
            mail.AlternateViews.Add(htmlView);
            client.Send(mail);
            
        }
        LogIn log;
        private void label1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Start();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Height <= 150)
            {
                panel1.Height += 5;
            }
                     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            panel1.Height = 0;
        }
    }
}
