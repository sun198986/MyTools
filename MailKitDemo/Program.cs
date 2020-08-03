/*
 *nuget MailKit
 */
using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace MailKitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey Tribbiani", "334828328@qq.com"));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "334828328@qq.com"));
            message.Subject = "How you doin'?";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey Chandler,

I just wanted to let you know that Monica and I were going to go play some paintball, you in?

-- Joey"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.qq.com", 25, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("334828328@qq.com", "zwsqtqnbefesbjdi");

                client.Send(message);
                client.Disconnect(true);
            }

			Console.WriteLine("Hello World!");
        }
    }
}
