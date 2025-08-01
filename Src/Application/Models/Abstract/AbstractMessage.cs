using HeloWorldCsharp.Application.Services;

namespace HeloWorldCsharp.Application.Models.Abstract
{
    public abstract class AbstractMessage : IMessage
    {
        protected string? MessageContent = null;
        public string GetMessage()
        {
            try
            {
                return MessageContent!;
            }
            catch
            {
                throw new Exception("Message content is null");
            }
        }

        public virtual void SetMessage(string newMessageContent){}
    }
}