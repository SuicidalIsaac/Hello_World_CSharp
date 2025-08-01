using HeloWorldCsharp.Application.Services;
using HeloWorldCsharp.Presentation.Infrastructure.Services;

namespace HeloWorldCsharp.Presentation.Infrastructure.ConsoleImplementation
{
    public abstract class AbstractConsoleUI : IUI
    {
        public virtual void OutputMessage(IMessage message) { }
    }
}