using EmployeePortal.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmployeePortal.Services
{

    public class MailService : IMailService
    {
        private readonly string _smtpServer = "smtp.ethereal.email";             // SMTP server
        private readonly int _smtpPort = 587;                                   // port
        private readonly string _smtpUsername = "helga.mann26@ethereal.email"; //  username
        private readonly string _smtpPassword = "kjpVv59hsqDBg4VWWv";         //  password
        private readonly string _fromEmail = "helga.mann26@ethereal.email";  // From email address

        public async Task SendEmailAsync(Contactus contactus)
        {
            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                client.EnableSsl = true;

                var message = new MailMessage
                {
                    From = new MailAddress(_fromEmail),
                    Subject = $"Thanks for Reaching Us : {contactus.FirstName} {contactus.LastName}",
                    Body = $@"
                                <h3>Resolving Issues </h3><br/>
                                <p>Hello <strong> {contactus.FirstName} {contactus.LastName}</strong></p><br/>
                                <p>We Can Resolve Your Below Issue/Query Within 8 Working Days </p><br/>
                                <p>Your Query/Issue: <br/> {contactus.Query}</p
                            ",
                    IsBodyHtml = true
                };

                message.To.Add(contactus.Email);

                try
                {
                    await client.SendMailAsync(message);
                }
                catch (SmtpException ex)
                {
                    throw new Exception($"Error sending email: {ex.Message}");
                }
            }
        }
    }
}
