using Messaging.Interfaces;
using RabbitMQ.Client;
using Shred.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Messaging
{
    public class RabbitMqMessagePublisher : IMessagePublisher
    {
        private readonly IConnection _connection;

        public RabbitMqMessagePublisher(IConnection connection)
        {
            _connection = connection;
        }

        public Task PublishAsync(NotificationMessage message)
        {
            using (var channel = _connection.CreateModel())
            {
                var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
                channel.BasicPublish(exchange: "notification_exchange",
                                     routingKey: "",
                                     basicProperties: null,
                                     body: body);
            }
            return Task.CompletedTask;
        }
    }
}
