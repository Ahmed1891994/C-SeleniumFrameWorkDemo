using System;
using NUnit.Framework;

namespace FrameworDemo.Utilities
{
    public class Logger : ILogger_I
    {
        public Logger()
        {
        }
        public void Info(String text)
        {
            TestContext.Progress.WriteLine("INFO — " + text);
        }
        public void Warn(String text)
        {
            TestContext.Progress.WriteLine("LOG — " + text);
        }
        public void Error(String text)
        {
            TestContext.Progress.WriteLine("ERROR — " + text);
        }
    }
}
