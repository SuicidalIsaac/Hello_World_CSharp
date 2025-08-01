using Microsoft.Extensions.DependencyInjection;
using HeloWorldCsharp.Application.Models;
using HeloWorldCsharp.Application.Services;


namespace HeloWorldCsharp.Application.DependencyInjection
{
    public static class DependencyInjectionMessage
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Регистрация сервисов
            services.AddSingleton<IMessage, Message>();

            return services.BuildServiceProvider();
        }
    }
}