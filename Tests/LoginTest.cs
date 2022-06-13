using FrameworDemo.Base;
using FrameworDemo.DriverActions;
using NUnit.Framework;


namespace FrameworDemo.Tests
{
    class LoginTest : TestBase
    {
        [Test]
        public void Test()
        {
            driverActions.CloseAllWindows();
        }
    }
}
