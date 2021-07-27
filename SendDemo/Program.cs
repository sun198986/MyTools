using RabbitMQ.Client;
using System;
using System.Text;

namespace SendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { UserName="sunshijie",Password= "123456", HostName = "192.168.241.128",Port= AmqpTcpEndpoint.UseDefaultPort };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                string nameDeclare= channel.QueueDeclare(queue: "hello",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);
                while (true)
                {
                    var input = Console.ReadLine();
                    string message = input;
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                     routingKey: nameDeclare,
                     basicProperties: null,
                     body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }

            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
