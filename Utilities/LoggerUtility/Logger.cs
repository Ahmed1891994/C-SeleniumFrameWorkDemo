using System;
using NUnit.Framework;

namespace FrameworDemo.Utilities.LoggerUtility
{
    public class Logger : ILogger_I
    {
        public Logger()
        {
        }
        public void Info(string text)
        {
            TestContext.Progress.WriteLine("INFO — " + text);
        }
        public void Warn(string text)
        {
            TestContext.Progress.WriteLine("LOG — " + text);
        }
        public void Error(string text)
        {
            TestContext.Progress.WriteLine("ERROR — " + text);
        }
    }
}
