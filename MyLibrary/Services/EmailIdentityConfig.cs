using SendGrid.Helpers.Mail;
using System.Diagnostics;
using System.Net;
using SendGrid;
using System.Net;
using System.Configuration;
using System.Diagnostics;

namespace MyLibrary.Services
{
    public class EmailIdentityConfig
    {
        private static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}