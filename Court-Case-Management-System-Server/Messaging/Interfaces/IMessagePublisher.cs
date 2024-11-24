
using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Interfaces
{
    public interface IMessagePublisher
    {
        Task PublishAsync(NotificationMessage message);
    }
}
