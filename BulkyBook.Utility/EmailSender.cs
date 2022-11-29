using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;


namespace BulkyBook.Utility
{
    //public class EmailSender : IEmailSender
    //{
    //    //public string SendGridSecret { get; set; }

    //    //public EmailSender(IConfiguration _config)
    //    //{
    //    //    SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
    //    //}

    //    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    //    {
    //        var emailToSend = new MimeMessage();
    //        emailToSend.From.Add(MailboxAddress.Parse("leventym@gmail.com"));
    //        emailToSend.To.Add(MailboxAddress.Parse(email));
    //        emailToSend.Subject = subject;
    //        emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

    //        //send email
    //        using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
    //        {
    //            emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
    //            emailClient.Authenticate("leventym@gmail.com", "");
    //            emailClient.Send(emailToSend);
    //            emailClient.Disconnect(true);
    //        }

    //        return Task.CompletedTask;

    //        //var client = new SendGridClient(SendGridSecret);
    //        //var from = new EmailAddress("leventym@gmail.com", "Bulky Book");
    //        //var to = new EmailAddress(email);
    //        //var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
    //        //return client.SendEmailAsync(msg);

    //    }
    //}
}

