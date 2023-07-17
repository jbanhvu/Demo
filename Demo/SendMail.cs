using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SendMailFrom = "vufabio@gmail.com";
            String SendMailTo = "jbanhvu@gmail.com";
            String SendMailSubject = "Có yêu cầu báo giá cần duyệt của dự án ABC";
            String SendMailBody = "Có yêu cầu báo giá cần duyệt của dự án ABC";

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, "rmpaliyuaehhmpcg");
                SmtpServer.Send(email);

                MessageBox.Show("Send mail successfully!", "Notice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Notice");
            }

        }
    }
}
