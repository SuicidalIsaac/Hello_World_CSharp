using HeloWorldCsharp.Application.Services;

namespace HeloWorldCsharp.Presentation.Infrastructure.Services
{
    public interface IUI
    {
        void OutputMessage(IMessage message);
    }
}