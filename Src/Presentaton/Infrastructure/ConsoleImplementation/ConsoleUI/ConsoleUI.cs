using HeloWorldCsharp.Application.Services;

namespace HeloWorldCsharp.Presentation.Infrastructure.ConsoleImplementation
{
    public class ConsoleUI : AbstractConsoleUI
    {
        public override void OutputMessage(IMessage message)
        {
            Console.WriteLine(message.GetMessage());
        }
    }
}