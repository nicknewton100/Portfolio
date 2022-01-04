using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Portfolio_Project.Models.Settings;
using Portfolio_Project.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(ContactViewModel contactViewModel)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse("nick.newton404@gmail.com"));
            email.Subject = "Contact Form - " + contactViewModel.Name;
            var builder = new BodyBuilder();
            builder.TextBody = String.Format(" Name: {0} \n Email: {1} \n Company: {2} \n Phone Number: {3} \n\n Message: {4}", contactViewModel.Name, contactViewModel.Email, contactViewModel.Company, contactViewModel.PhoneNumber, contactViewModel.Message);
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.CheckCertificateRevocation = false;
            await smtp.ConnectAsync(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTlsWhenAvailable);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
