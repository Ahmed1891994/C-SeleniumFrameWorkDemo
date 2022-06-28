using System;
using FrameworDemo.Utilities.LoggerUtility;
using NUnit.Framework;
using static FrameworDemo.Constants.Browser;

namespace FrameworDemo.DriverFactory
{
    public class DriverManagerFactory
    {
        private readonly Logger logger;
        BrowserType browsertype;
        public DriverManagerFactory()
        {
            logger = new();
        }
        public DriverManagerAbstract GetManager(String browser)
        {
            DriverManagerAbstract returndrivermanager = null;
            logger.Info("Create Browser driver instance from Browser : " + browser);

            if (Enum.TryParse<BrowserType>(browser, true, out browsertype))
            {
                switch (browsertype)
                {
                    case BrowserType.CHROME:
                        returndrivermanager = new ChromeDriveManager();
                        break;
                    case BrowserType.FIREFOX:
                        returndrivermanager = new FireFoxDriverManager();
                        break;
                    case BrowserType.IE:
                        break;
                    case BrowserType.EDGE:
                        break;
                    default: throw new InvalidOperationException("Unexpected value: " + browsertype);
                }
            }
            else
            {
                ;
            }

            logger.Info("Browser driver manager is created and instace has been made successfully");
            return returndrivermanager;
        }
    }
}
