using FrameworDemo.Base;
using FrameworDemo.Utilities.LoggerUtility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Pages.RegistrationPage
{
    class RegistrationPage : TestBase
    {
        private readonly By pageheading = By.ClassName("page-heading");

        private readonly By gendermale_rbx = By.Id("id_gender1");
        private readonly By genderfemale_rbx = By.Id("id_gender2");
        private readonly By firstname_fld = By.Id("customer_firstname");
        private readonly By lastname_fld = By.Id("customer_lastname");
        private readonly By firstname__fld = By.Id("firstname");
        private readonly By lastname__fld = By.Id("lastname");
        private readonly By email_fld = By.Id("email");
        private readonly By passwd_fld = By.Id("passwd");
        private readonly By company_fld = By.Id("company");
        private readonly By address1_fld = By.Id("address1");
        private readonly By address2_fld = By.Id("address2");
        private readonly By city_fld = By.Id("city");
        private readonly By state_fld = By.Id("id_state");
        private readonly By postcode_fld = By.Id("postcode");
        private readonly By additioninfo_fld = By.Id("other");
        private readonly By phone_fld = By.Id("phone");
        private readonly By mobile_fld = By.Id("phone_mobile");
        private readonly By futureaddress_fld = By.Id("alias");

        private readonly By days_drbx = By.Id("days");
        private readonly By months_drbx = By.Id("months");
        private readonly By years_drbx = By.Id("years");

        private readonly By country_drbx = By.Id("id_country");

        private readonly By register_btn = By.Id("submitAccount");

        private readonly Logger logger;

        public RegistrationPage()
        {
            logger = new();
        }
        public void SetGender(String Gender)
        {
            int gender = Convert.ToInt32(Gender);
            if (gender == 0)
            {
                gender = userregistrationprofile.Gender;
                logger.Info("Gender was null from user and now has value from faker = : " + Gender);
            }
            else
            {
                userregistrationprofile.Gender = gender;
                logger.Info("Gender has value from user = : " + Gender);
            }

            if(gender == 1)
                driveractions.ClickOn(gendermale_rbx);
            else if(gender == 2)
                driveractions.ClickOn(genderfemale_rbx);
        }
        public void SetFirstName(string firstname)
        {
            if (firstname == null)
            {
                firstname = userregistrationprofile.Firstname;
                logger.Info("firstname was null from user and now has value from faker = : " + firstname);
            }
            else
            {
                userregistrationprofile.Firstname = firstname;
                logger.Info("firstname has value from user = : " + firstname);
            }
            driveractions.TextSet(firstname_fld, firstname); 
            driveractions.TextSet(firstname__fld, firstname);
        }
        public void SetLastName(string lastname)
        {
            if (lastname == null)
            {
                lastname = userregistrationprofile.Lastname;
                logger.Info("lastname was null from user and now has value from faker = : " + lastname);
            }
            else
            {
                userregistrationprofile.Lastname = lastname;
                logger.Info("lastname has value from user = : " + lastname);
            }
            driveractions.TextSet(lastname_fld, lastname);
            driveractions.TextSet(lastname__fld, lastname);
        }

        public void Setemail(string email)
        {
            if (email == null)
            {
                email = userregistrationprofile.Email;
                logger.Info("email was null from user and now has value from faker = : " + email);
            }
            else
            {
                userregistrationprofile.Email = email;
                logger.Info("email has value from user = : " + email);
            }
            driveractions.TextSet(email_fld, email);
        }

        public void SetPasswd(string passwd)
        {
            if (passwd == null)
            {
                passwd = userregistrationprofile.Password;
                logger.Info("passwd was null from user and now has value from faker = : " + passwd);
            }
            else
            {
                userregistrationprofile.Password = passwd;
                logger.Info("passwd has value from user = : " + passwd);
            }
            driveractions.TextSet(passwd_fld, passwd);
        }
        public void SetCompany(string company)
        {
            if (company == null)
            {
                company = userregistrationprofile.Company;
                logger.Info("company was null from user and now has value from faker = : " + company);
            }
            else
            {
                userregistrationprofile.Company = company;
                logger.Info("company has value from user = : " + company);
            }
            driveractions.TextSet(company_fld, company);
        }
        public void SetAddress1(string address1)
        {
            if (address1 == null)
            {
                address1 = userregistrationprofile.Address1;
                logger.Info("address1 was null from user and now has value from faker = : " + address1);
            }
            else
            {
                userregistrationprofile.Address1 = address1;
                logger.Info("address1 has value from user = : " + address1);
            }
            driveractions.TextSet(address1_fld, address1);
        }
        public void SetAddress2(string address2)
        {
            if (address2 == null)
            {
                address2 = userregistrationprofile.Address2;
                logger.Info("address2 was null from user and now has value from faker = : " + address2);
            }
            else
            {
                userregistrationprofile.Address2 = address2;
                logger.Info("address2 has value from user = : " + address2);
            }
            driveractions.TextSet(address2_fld, address2);
        }
        public void SetCity(string city)
        {
            if (city == null)
            {
                city = userregistrationprofile.City;
                logger.Info("city was null from user and now has value from faker = : " + city);
            }
            else
            {
                userregistrationprofile.City = city;
                logger.Info("city has value from user = : " + city);
            }
            driveractions.TextSet(city_fld, city);
        }
        public void SetState(string state)
        {
            if (state == null)
            {
                state = userregistrationprofile.State;
                logger.Info("state was null from user and now has value from faker = : " + state);
            }
            else
            {
                userregistrationprofile.State = state;
                logger.Info("state has value from user = : " + state);
            }
            driveractions.ChooseByTextInDropBox(state_fld, state);
        }
        public void SetPostCode(string postcode)
        {
            if (postcode == null)
            {
                postcode = userregistrationprofile.PostalCode;
                logger.Info("postcode was null from user and now has value from faker = : " + postcode);
            }
            else
            {
                userregistrationprofile.PostalCode = postcode;
                logger.Info("postcode has value from user = : " + postcode);
            }
            driveractions.TextSet(postcode_fld, postcode);
        }
        public void SetAdditionInfo(string additioninfo)
        {
            if (additioninfo == null)
            {
                additioninfo = userregistrationprofile.Additionalinformation;
                logger.Info("additioninfo was null from user and now has value from faker = : " + additioninfo);
            }
            else
            {
                userregistrationprofile.Additionalinformation = additioninfo;
                logger.Info("additioninfo has value from user = : " + additioninfo);
            }
            driveractions.TextSet(additioninfo_fld, additioninfo);
        }
        public void SetPhone(string phone)
        {
            if (phone == null)
            {
                phone = userregistrationprofile.Homephone;
                logger.Info("phone was null from user and now has value from faker = : " + phone);
            }
            else
            {
                userregistrationprofile.Homephone = phone;
                logger.Info("phone has value from user = : " + phone);
            }
            driveractions.TextSet(phone_fld, phone);
        }
        public void SetMobile(string mobile)
        {
            if (mobile == null)
            {
                mobile = userregistrationprofile.Mobilephone;
                logger.Info("mobile was null from user and now has value from faker = : " + mobile);
            }
            else
            {
                userregistrationprofile.Mobilephone = mobile;
                logger.Info("mobile has value from user = : " + mobile);
            }
            driveractions.TextSet(mobile_fld, mobile);
        }
        public void SetFutureAddress(string futureaddress)
        {
            if (futureaddress == null)
            {
                futureaddress = userregistrationprofile.Futureaddress;
                logger.Info("futureaddress was null from user and now has value from faker = : " + futureaddress);
            }
            else
            {
                userregistrationprofile.Futureaddress = futureaddress;
                logger.Info("futureaddress has value from user = : " + futureaddress);
            }
            driveractions.TextSet(futureaddress_fld, futureaddress);
        }
        public void SetCountry(string country)
        {
            if (country == null)
            {
                country = userregistrationprofile.Country;
                logger.Info("country was null from user and now has value from faker = : " + country);
            }
            else
            {
                userregistrationprofile.Country = country;
                logger.Info("country has value from user = : " + country);
            }
            driveractions.ChooseByTextInDropBox(country_drbx, country);
        }

        public void SetDate(String days, String month , String year)
        {
            if (days == null)
            {
                days = userregistrationprofile.Day.ToString();
                logger.Info("days was null from user and now has value from faker = : " + days);
            }
            else
            {
                userregistrationprofile.Day = Convert.ToInt16(days);
                logger.Info("days has value from user = : " + days);
            }
            if (month == null)
            {
                month = userregistrationprofile.Month.ToString();
                logger.Info("month was null from user and now has value from faker = : " + month);
            }
            else
            {
                userregistrationprofile.Month = Convert.ToInt16(month);
                logger.Info("month has value from user = : " + month);
            }
            if (year == null)
            {
                year = userregistrationprofile.Year.ToString();
                logger.Info("year was null from user and now has value from faker = : " + year);
            }
            else
            {
                userregistrationprofile.Year = Convert.ToInt32(year);
                logger.Info("year has value from user = : " + year);
            }
            driveractions.ChooseByValueInDropBox(years_drbx, year);
            driveractions.ChooseByValueInDropBox(months_drbx, month);
            driveractions.ChooseByValueInDropBox(days_drbx, days);
        }

        public void Pressregisterbutton()
        {
            driveractions.ClickOn(register_btn);
        }
        //***********************************Flows***************************************
        public void AddRegisterationData(String gender,String firstname, String lastname, String email, String passwd,
            String day, String month, String year, String company,String address1,String address2,
            String city, String state, String postalcode,String country , String additionalinfo,
            String homephone, String mobilephone, String futureaddress)
        {
            SetGender(gender);
            SetFirstName(firstname);
            SetLastName(lastname);
            Setemail(email);
            SetPasswd(passwd);
            SetDate(day, month, year);
            SetCompany(company);
            SetAddress1(address1);
            SetAddress2(address2);
            SetCity(city);
            SetState(state);
            SetPostCode(postalcode);
            SetCountry(country);
            SetAdditionInfo(additionalinfo);
            SetPhone(homephone);
            SetMobile(mobilephone);
            SetFutureAddress(futureaddress);

            Pressregisterbutton();
        }
    }
}
