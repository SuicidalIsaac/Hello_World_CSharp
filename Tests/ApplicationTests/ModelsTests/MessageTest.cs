using HeloWorldCsharp.Application.Models;
using System;

namespace HeloWorldCsharp.Tests.ApplicationTests.ModelsTests
{
    public class MessageTest
    {
        Message _message = new();
        string _expectedMessage = "Hello";
        string _receivedMessage = "";
        public bool RunMessageTests()
        {
            SetMessageTest();
            GetMessageTest();
            return _receivedMessage == _expectedMessage;
        }
        private void SetMessageTest()
        {
            _message.SetMessage(_expectedMessage);
        }
        private void GetMessageTest()
        {
            _receivedMessage = _message.GetMessage();
        }
    }
}