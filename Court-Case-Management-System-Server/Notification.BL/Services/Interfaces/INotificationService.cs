using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.BL.Services.Interfaces
{
    public interface INotificationService
    {
        void Start();
        void SendEmailNotification(NotificationMessage notificationMessage);
    }
}
