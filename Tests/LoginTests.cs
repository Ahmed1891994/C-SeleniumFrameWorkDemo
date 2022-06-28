using FrameworDemo.Base;
using FrameworDemo.Pages.AuthenticationPage;
using FrameworDemo.Pages.Header;
using FrameworDemo.Pages.MyAccountPage;
using FrameworDemo.Pages.RegistrationPage;
using NUnit.Framework;


namespace FrameworDemo.Tests
{
    class LoginTests : TestBase
    {
        [Test]
        public void Test()
        {
            Header header = new();
            header.Authentication();

            AuthenticationPage auth = new();
            auth.CreateNewAccount("xxxxx@yyy.com");

            RegistrationPage registerpage = new();
            registerpage.AddRegisterationData(null,null, null, "xxxxx@yyy.com", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

            MyAccountPage myaccountpage = new();
            myaccountpage.Page_Check();

            header.SignOut();
            auth.SignInAccount(null, null);
            myaccountpage.Page_Check();

            //    Allison.Hauck@yahoo.com
            //    RCS3M5omgQ
        }
    }
}
