using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using FrameworDemo.Utilities;

namespace FrameworDemo.Factory
{
    public class FireFoxDriverManager : DriverManagerAbstract
    {
        private readonly Logger logger;
        public FireFoxDriverManager()
        {
            logger = new();
        }
        protected override void StartDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            logger.Info("Firefox driver has been set up");
        }
    }
}
