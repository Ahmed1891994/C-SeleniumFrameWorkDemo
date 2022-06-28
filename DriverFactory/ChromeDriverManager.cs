using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using FrameworDemo.Utilities.LoggerUtility;

namespace FrameworDemo.DriverFactory
{
    class ChromeDriveManager : DriverManagerAbstract
    {
        private readonly Logger logger;
        public ChromeDriveManager()
        {
            logger = new();
        }
        protected override void StartDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            logger.Info("Chrome driver has been set up");
        }
    }
}
