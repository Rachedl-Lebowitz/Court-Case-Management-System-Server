using RabbitMQ.Client;

namespace Shared.Messaging
{
    public class RabbitMQConnection
    {
        private readonly IConnection _connection;

        public RabbitMQConnection()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "your-rabbitmq-server-hostname",
                UserName = "your-username",
                Password = "your-password"
            };
            _connection = factory.CreateConnection();
        }

        public IConnection GetConnection()
        {
            return _connection;
        }
    }
}