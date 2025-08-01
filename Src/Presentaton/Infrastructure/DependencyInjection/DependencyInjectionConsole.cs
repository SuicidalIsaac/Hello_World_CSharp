using Microsoft.Extensions.DependencyInjection;
using HeloWorldCsharp.Presentation.Infrastructure.Services;
using HeloWorldCsharp.Presentation.Infrastructure.ConsoleImplementation;

namespace HeloWorldCsharp.Presentation.Infrastructure.DependencyInjection
{
    public static class DependencyInjectionConsole
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            // Регистрация сервисов
            services.AddSingleton<IUI, ConsoleUI>();
            
            return services.BuildServiceProvider();
        }
    }
}