using EnviarCorreo;
using Microsoft.Extensions.Configuration;
using SendMails.methods;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartAdminSaludsa.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : IEmailSender
    {

        public IConfiguration Configuration { get; }


        public AuthMessageSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }




        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }

        public async Task SendEmailAsync(List<string> emailsTo, string subject, string message)
        {
            try
            {
                List<Mail> mails = new List<Mail>();
                foreach (var item in emailsTo)
                {
                    mails.Add(new Mail
                    {
                        Body = message,
                        EmailTo = item,
                        NameTo = "Laboratorio de Calidad",
                        Subject = subject
                    });
                }
                await Emails.SendEmailAsync(mails);
            }
            catch (Exception)
            { }
        }

        public string CuerpoCreateUser(string titulo, string nombreApellido, string email, string password, string emailLink)
        {
            var mensaje = Configuration.GetSection("CuerpoUsuarioCreate").Value;
            mensaje = mensaje.Contains("@nombreApellido") ? mensaje.Replace("@nombreApellido", nombreApellido) : mensaje;
            mensaje = mensaje.Contains("@Usuario") ? mensaje.Replace("@Usuario", email) : mensaje;
            mensaje = mensaje.Contains("@password") ? mensaje.Replace("@password", password) : mensaje;
            mensaje = mensaje.Contains("@emailLink") ? mensaje.Replace("@emailLink", emailLink) : mensaje;
            mensaje = mensaje.Contains("@titulo") ? mensaje.Replace("@titulo", titulo) : mensaje;
            return mensaje;
        }
    }
}