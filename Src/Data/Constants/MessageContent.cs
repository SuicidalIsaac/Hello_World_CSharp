using HeloWorldCsharp.Data.Services;

namespace HeloWorldCsharp.Data.Constants
{
    public class MessageContentConstantValue : IDataConstant
    {
        public string _value {get{ return "Hello World"; }}
        public string GetValue()
        {
            return _value;
        }
    }
}