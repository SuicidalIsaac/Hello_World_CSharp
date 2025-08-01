using Microsoft.Extensions.DependencyInjection;
using HeloWorldCsharp.Presentation.Infrastructure.DependencyInjection;
using HeloWorldCsharp.Presentation.Infrastructure.Services;
using HeloWorldCsharp.Application.DependencyInjection;
using HeloWorldCsharp.Application.Services;
using HeloWorldCsharp.Data.Constants;
using HeloWorldCsharp.Tests;

namespace HeloWorldCsharp.Presentation
{
    class HelloWorld
    {
        public static void Main(string[] args)
        {
            if (args[0] == "tests"){RunTests.Run(); return;}
            
            var consoleServices = DependencyInjectionConsole.ConfigureServices();
            var messageServices = DependencyInjectionMessage.ConfigureServices();

            IMessage message = messageServices.GetRequiredService<IMessage>();
            IUI consoleUI = consoleServices.GetRequiredService<IUI>();

            MessageContentConstantValue messageContentValue = new();
            message.SetMessage(messageContentValue.GetValue());

            consoleUI.OutputMessage(message);
        }
    }
}