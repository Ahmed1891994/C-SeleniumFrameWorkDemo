using FrameworDemo.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using NUnit.Framework;
using FrameworDemo.Utilities;

namespace FrameworDemo.DriverActions
{
    public class DriverMethods
    {
        private readonly IWebDriver driver;
        public Logger logger;
        public DriverMethods(IWebDriver driver)
        {
            logger = new();
            
            this.driver = driver;
            logger.Info("driver is saved in private variable successsfully" + driver);
        }
        // ************************************URLNavigation**********************************************
        // open url using navigate
        public void OpenURL_History(String URL)
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info("navigate to url :  " + URL + " done successfully");
        }

        public void GoForward()
        {
            driver.Navigate().Forward();
            logger.Info("navigate to forward page successfully");
        }

        public void GoBack()
        {
            driver.Navigate().Back();
            logger.Info("navigate to back page successfully");
        }

        // refresh page
        public void ReloadPage()
        {
            driver.Navigate().Refresh();
            logger.Info("reloading page successfully");
        }
        // ***************************************Keyboard************************************************
        //Keyboard control simulation
        public void KeyboardControlPress(String Keys)
        {
            Actions action = new(driver);
            action.KeyDown(Keys).KeyUp(Keys).Perform();
            logger.Info("Key (("+ Keys + ")) is pressed successfully");
        }

        // ****************************************Buttons************************************************
        // click on button
        public void ClickOn(By element)
        {
            //wait.until(ExpectedConditions.elementToBeClickable(element));
            driver.FindElement(element).Click();
            //logger.Info("button ((" ")) is clicked successfully");
        }

        // ***************************************TextFields**********************************************
        // put text in field after clearing it
        public void TextSet(By element, String text)
        {
            //wait.until(ExpectedConditions.visibilityOfElementLocated(element));
            driver.FindElement(element).Clear();
            logger.Info("Text is cleared successfully");
            driver.FindElement(element).SendKeys(text);
            logger.Info("Text ((" + text + ")) is written successfully");
        }

        // Get text from element
        public String TextGet(By element)
        {
            //wait.until(ExpectedConditions.visibilityOfElementLocated(element));
            String result = driver.FindElement(element).Text;
            logger.Info("Text ((" + result + ")) is returned from Element successfully");
            return result;
        }

        // **************************************WindowClosure***************************************
        public void CloseCurrentWindow()
        {
            driver.Close();
            logger.Info("current window is closed successfully");
        }

        public void CloseAllWindows()
        {
            driver.Quit();
            logger.Info("All windows are closed successfully");
        }

        // ******************************************Cookies*****************************************
        public void DeleteAllCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            logger.Info("All cookies are deleted successfully");
        }

        // ***************************************CheckElements**************************************
        public bool IsDisplayed(By element)
        {
            bool flag;
            if (driver.FindElement(element).Displayed)
            {
                flag = true;
                logger.Info("Element is displayed successfully");
            }
            else
            {
                flag = false;
                logger.Warn("Element is not displayed successfully");
            }
            return flag;
        }

        public bool IsNotExist(By element)
        {
            bool flag;
            if (driver.FindElements(element) == null)
            {
                flag = true;
                logger.Warn("Element is Not Exist");
            }
            else
            {
                flag = false;
                logger.Info("Element "+ driver.FindElement(element).Text + " is Exist");
            }
            return flag;
        }

        public bool CheckElementType(By element, String type)
        {
            bool flag;
            if (driver.FindElement(element).GetAttribute("type").Equals(type))
            {
                flag = true;
                logger.Info("Element " + driver.FindElement(element).Text + "has right type " + type);
            }
            else
            {
                flag = false;
                logger.Warn("Element " + driver.FindElement(element).Text + "has wrong type " + type);
            }
            return flag;
        }
    }
}
