using Application.Interfaces;
using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Domain.Entities;

namespace Application.Services
{
    public class EmailService: IEmailService
    {
        private readonly SmtpSettings _smtpSettings;

        public EmailService(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public async Task SendPasswordRecoveryEmailAsync(string email, string token)
        {
            // Crear el mensaje de correo
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Tu nombre o empresa", _smtpSettings.FromEmail));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = "Recuperación de Contraseña";

            // Crear el cuerpo del correo con el enlace para restablecer la contraseña
            var body = $"<p>Haz clic en el siguiente enlace para recuperar tu contraseña:</p>" +
                       $"<a href='https://tusitio.com/reset-password?token={token}'>Restablecer contraseña</a>";

            message.Body = new TextPart("html")
            {
                Text = body
            };

            // Enviar el correo
            using var client = new SmtpClient();
            await client.ConnectAsync(_smtpSettings.Host, _smtpSettings.Port, _smtpSettings.UseSsl);
            await client.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}
