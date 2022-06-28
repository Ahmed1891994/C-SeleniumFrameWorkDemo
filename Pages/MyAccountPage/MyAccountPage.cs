using FrameworDemo.Base;
using FrameworDemo.Utilities.LoggerUtility;
using OpenQA.Selenium;


namespace FrameworDemo.Pages.MyAccountPage
{
    public class MyAccountPage : TestBase
    {
        private readonly Logger logger;

        private readonly By title_chk = By.Id("center_column"); 
        private readonly By navigationpage_chk = By.ClassName("navigation_page");

        public MyAccountPage()
        {
            logger = new();
        }

        public bool Page_Check()
        {
            return driveractions.IsDisplayed(title_chk) && driveractions.IsDisplayed(navigationpage_chk);
        }
    }

   
}
