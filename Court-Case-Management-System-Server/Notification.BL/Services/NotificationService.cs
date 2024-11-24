using MailKit.Net.Smtp;
using MimeKit;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using Shred.Models.DTO;
using Shared.Messaging;
using Notification.BL.Services.Interfaces;

namespace NotificationService.BL.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IConnection _rabbitMqConnection;

        public NotificationService(RabbitMQConnection rabbitMqConnection)
        {
            _rabbitMqConnection = rabbitMqConnection.GetConnection();
        }

        public void Start()
        {
            using (var channel = _rabbitMqConnection.CreateModel())
            {
                channel.QueueDeclare(queue: "case_created",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    var notificationMessage = JsonSerializer.Deserialize<NotificationMessage>(message);

                    // Sending an email message
                    SendEmailNotification(notificationMessage);
                };

                channel.BasicConsume(queue: "case_created",
                                     autoAck: true,
                                     consumer: consumer);
            }
        }

        private void SendEmailNotification(NotificationMessage notificationMessage)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Your App", "your-email@example.com"));
            emailMessage.To.Add(new MailboxAddress("Recipient", "recipient-email@example.com"));
            emailMessage.Subject = "New Case Created";
            emailMessage.Body = new TextPart("plain")
            {
                Text = $"A new case with ID {notificationMessage.CaseId} has been created. Message: {notificationMessage.Message}"
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.example.com", 587, false);
                client.Authenticate("your-email@example.com", "your-email-password");
                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }
    }
}