using HeloWorldCsharp.Application.Services.IMessageServices;

namespace HeloWorldCsharp.Application.Services
{
    public interface IMessage : IGetMessage, ISetMessage
    {
    }
}