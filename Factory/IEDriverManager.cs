using FrameworDemo.Utilities;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworDemo.Factory 
{

    class IEDriverManager : DriverManagerAbstract
    {
        private readonly Logger logger;
        public IEDriverManager()
        {
            logger = new();
        }
        protected override void StartDriver()
        {
            new DriverManager().SetUpDriver(new InternetExplorerConfig());
            driver = new InternetExplorerDriver();
            logger.Info("Chrome driver has been set up");
        }
    }
}
