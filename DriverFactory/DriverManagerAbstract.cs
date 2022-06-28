using OpenQA.Selenium;

namespace FrameworDemo.DriverFactory
{
    public abstract class DriverManagerAbstract
    {
        protected IWebDriver driver;

        protected abstract void StartDriver();

        public void QuitDriver(IWebDriver driver)
        {
            if (driver != null)
            {
                driver.Quit();
            }
            else
            {
                ;
            }
        }

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                 StartDriver();
            }
            else
            {
                ;
            }

            return driver;
        }
    }
}
