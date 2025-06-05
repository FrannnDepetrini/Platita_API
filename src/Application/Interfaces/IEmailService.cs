using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmailService
    {
        Task SendPasswordRecoveryEmailAsync(string email, string token);
        Task SendNotificationEmailAsync(string email, string userName, CategoryNotificationsEnum category);
    }
}
