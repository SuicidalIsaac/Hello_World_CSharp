using HeloWorldCsharp.Application.Models.Abstract;

namespace HeloWorldCsharp.Application.Models
{
    public class Message : AbstractMessage
    {
        public override void SetMessage(string newMessageContent)
        {
            base.MessageContent = newMessageContent;
        }
    }
}