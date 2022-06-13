using FrameworDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworDemo.Factory
{
    class EdgeDriverManager : DriverManagerAbstract
    {
        private readonly Logger logger;
        public EdgeDriverManager()
        {
            logger = new();
        }
        protected override void StartDriver()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            logger.Info("Edge driver has been set up");
        }
    }
}
