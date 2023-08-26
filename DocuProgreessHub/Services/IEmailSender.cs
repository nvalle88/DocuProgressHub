
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaCalidad.Models;

namespace SmartAdminSaludsa.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailAsync(List<string> emailsTo, string subject, string message);

        string CuerpoCreateUser(string titulo, string nombreApellido, string email, string password, string emailLink);
    }
}