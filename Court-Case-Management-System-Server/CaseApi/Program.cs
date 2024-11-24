using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Messaging;
using Case.BL.Services.Interfaces;
using Messaging.Interfaces;
using Shared.Messaging;
using CaseService.DAL.Repositories;
using CaseService.BL.Services;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddSingleton<RabbitMQConnection>();

        services.AddSingleton<IMessagePublisher, RabbitMqMessagePublisher>();

        services.AddScoped<ICaseRepository, CaseRepository>();
        services.AddScoped<ICaseService, CaseServic>();

    });
}