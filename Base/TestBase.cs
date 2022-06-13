﻿using FrameworDemo.Constants;
using FrameworDemo.DriverActions;
using FrameworDemo.Factory;
using FrameworDemo.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace FrameworDemo.Base
{
    public class TestBase
    {
        public DriverMethods driverActions;
        public Debugging debugging = new();
        public Logger logger = new();
        protected DriverManagerFactory drivermanagerfactory = new();
        private readonly ThreadLocal<DriverManagerAbstract> drivermanager = new();
        private readonly ThreadLocal<IWebDriver> driver = new ();
        private Properties prop;
        private String browser;
        private String website;

        [SetUp]
        public void InitializeDriver()
        {
            prop = new("settings");
            browser = prop.Get("browser");
            website = prop.Get("website");
            logger.Info("Data from Settings properties file is successfully restored");

            SetDriverManager(drivermanagerfactory.GetManager(browser));
            logger.Info("Driver Manager is created successfully and saved in thread");

            SetDriver(GetDriverManager().GetDriver());
            logger.Info("Driver is created successfully and saved it in thread");

            
            driverActions = new DriverMethods(GetDriver());
            logger.Info("Driver action instance  is created successfully and push driver parameter to it");

            driverActions.OpenURL_History(website);
            logger.Info("Website Opened successfully");
        }


        private void SetDriverManager(DriverManagerAbstract driverManager)
        {
            logger.Info("save driver manager value" + driverManager);
            this.drivermanager.Value = driverManager;
        }

        protected DriverManagerAbstract GetDriverManager()
        {
            logger.Info("return driver manager value" + this.drivermanager.Value);
            return this.drivermanager.Value;
        }

        private void SetDriver(IWebDriver driver)
        {
            logger.Info("save driver value" + driver);
            this.driver.Value = driver;
        }

        protected IWebDriver GetDriver()
        {
            logger.Info("return driver value" + this.driver.Value);
            return this.driver.Value;
        }

        

        
    }
}
