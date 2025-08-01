using HeloWorldCsharp.Tests.ApplicationTests.ModelsTests;

namespace HeloWorldCsharp.Tests
{
    public class RunTests
    {
        public static void Run()
        {
            MessageTest messageTest = new();
            WriteResult("Message Test", messageTest.RunMessageTests());
        }
        private static void WriteResult(string testName, bool result)
        {
            Console.WriteLine($"{testName} result is {result}");
        }
    }
}