using FrameworDemo.Base;
using FrameworDemo.Profiles;
using FrameworDemo.Utilities.LoggerUtility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Pages.AuthenticationPage
{
    public  class AuthenticationPage : TestBase
    {
        private readonly Logger logger = new();
        private readonly By pageheading = By.ClassName("page-heading");

        private readonly By emailsignin_fld = By.Id("email");
        private readonly By passwdsignin_fld = By.Id("passwd");
        private readonly By forgetpasswd_btn = By.ClassName("lost_password");
        private readonly By SubmitLogin_btn = By.Id("SubmitLogin");

        private readonly By email_create_fld = By.Id("email_create");
        private readonly By createaccount_btn = By.ClassName("icon-user");

        public AuthenticationPage CreateNewAccount(string email)
        {

            if(email == null)
            {
                email = userregistrationprofile.Email;
                logger.Info("email was null from user and now has value from faker = : " + email);
            }
            else
            {
                userregistrationprofile.Email = email;
                logger.Info("email has value from user = : " + email);
            }
            driveractions.TextSet(email_create_fld, email);
            driveractions.ClickOn(createaccount_btn);

            return this;
        }

        public AuthenticationPage SignInAccount(string email, string passwd)
        {
            if (email == null)
            {
                email = userregistrationprofile.Email;
                logger.Info("Email has value from faker = : " + email);
            }
            else
            {;}
            if (passwd == null)
            {
                passwd = userregistrationprofile.Password;
                logger.Info("Password has value from faker = : " + passwd);

            }
            else
            {;}

            driveractions.TextSet(emailsignin_fld, email);
            driveractions.TextSet(passwdsignin_fld, passwd);
            driveractions.ClickOn(SubmitLogin_btn);
            logger.Info("email and password are set and submit login is clicked successfully");
            return new AuthenticationPage();
        }
    }
}
