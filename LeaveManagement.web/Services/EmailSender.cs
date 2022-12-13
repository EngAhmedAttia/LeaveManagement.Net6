using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int smtPort;
        private string fromEmailAdress;

        public EmailSender(string smtpServer, int smtPort, string fromEmailAdress)
        {
            this.smtpServer = smtpServer;
            this.smtPort = smtPort;
            this.fromEmailAdress = fromEmailAdress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAdress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml= true
            };
            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, smtPort);
            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
