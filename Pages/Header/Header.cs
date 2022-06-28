using FrameworDemo.Base;
using OpenQA.Selenium;


namespace FrameworDemo.Pages.Header
{
    public class Header : TestBase
    {
        private readonly By signin_btn = By.ClassName("login"); 
        private readonly By signout_btn = By.ClassName("logout");
        private readonly By contact_btn = By.Id("contact-link"); 
        private readonly By myaccount_btn = By.ClassName("account");

        public Header Authentication()
        {
            driveractions.ClickOn(signin_btn);
            return new Header();
        }
        public Header Myaccount()
        {
            driveractions.ClickOn(myaccount_btn);
            return new Header();
        }
        public Header SignOut()
        {
            driveractions.ClickOn(signout_btn);
            return new Header();
        }

        public Header ContactNumber()
        {
            driveractions.ClickOn(contact_btn);
            return new Header();
        }
    }
}
