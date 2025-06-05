using Application.Interfaces;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Domain.Constants;

namespace Application.Services
{
    public class EmailService: IEmailService
    {

        public async Task SendPasswordRecoveryEmailAsync(string email, string token)
        {
            // Crear el mensaje de correo
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("platita.api@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "Recuperación de Contraseña";

            // Crear el cuerpo del correo con el enlace para restablecer la contraseña

            string resetLink = $"http://localhost:5173/recover-password?token={token}";
            var builder = new BodyBuilder
            {
                HtmlBody = $@"
                    <p>Estimado/a usuario/a,</p>
                    <p>Hemos recibido una solicitud para restablecer su contraseña.</p>
                    <p>
                    <a href='{resetLink}' style='background-color: #4CAF50; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;'>
                    Recuperar contraseña
                    </a>
                    </p>
                    <p>Si usted no solicitó este cambio, puede ignorar este mensaje.</p>
                    <p>Atentamente,<br/>El equipo de Platita</p>
"
            };
            
            message.Body = builder.ToMessageBody();

            // Enviar el correo
            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await client.AuthenticateAsync("platita.api@gmail.com", "pifgyomaspxewudz");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        public async Task SendNotificationEmailAsync(string email, string userName, CategoryNotificationsEnum category)
        {
            // Crear el mensaje de correo
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("platita.api@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));

            switch (category)
                {
                case CategoryNotificationsEnum.PostulantSelected:
                    message.Subject = "Fuiste elegido";
                    var builder = new BodyBuilder
                    {
                        HtmlBody = $@"
                        <p>Estimado/a {userName},</p>
                        <p>Se te ha confirmado como postulante.</p>
                        <p>Atentamente,<br/>El equipo de Platita</p>"
                    };
                    message.Body = builder.ToMessageBody();
                    break;

                case CategoryNotificationsEnum.PostulantRejected:
                    message.Subject = "Fuiste rechazado";
                    var builder1 = new BodyBuilder
                    {
                        HtmlBody = $@"
                        <p>Estimado/a {userName},</p>
                        <p>Se te ha rechazado como postulante.</p>
                        <p>Atentamente,<br/>El equipo de Platita</p>"
                    };
                    message.Body = builder1.ToMessageBody();
                    break;

                case CategoryNotificationsEnum.PostulantCancelled:
                    message.Subject = "Fuiste cancelado";
                    var builder2 = new BodyBuilder
                    {
                        HtmlBody = $@"
                        <p>Estimado/a {userName},</p>
                        <p>Se ha cancelado el trabajo al que fuiste asignado.</p>
                        <p>Atentamente,<br/>El equipo de Platita</p>"
                    };
                    message.Body = builder2.ToMessageBody();
                    break;
            }

            // Enviar el correo
            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await client.AuthenticateAsync("platita.api@gmail.com", "pifgyomaspxewudz");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}
