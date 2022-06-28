using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Profiles
{
    public class UserRegistrationProfile
    {
        private static int gender;
        private static string firstname;
        private static string lastname;
        private static string email;
        private static string password;
        private static int day;
        private static int month;
        private static int year;
        private static string company;
        private static string address1;
        private static string address2;
        private static string city;
        private static string state;
        private static string postalCode;
        private static string country;
        private static string additionalinformation;
        private static string homephone;
        private static string mobilephone;
        private static string futureaddress;
        private static bool FlagsAttribute = false;
        public UserRegistrationProfile()
        {
            if (FlagsAttribute == false)
            {
                Gender = new Bogus.Randomizer().Number(1, 2);
                Firstname = new Bogus.DataSets.Name("en").FirstName(GetGender(Gender));
                Lastname = new Bogus.DataSets.Name("en").LastName();
                Email = new Bogus.DataSets.Internet().Email();
                Password = new Bogus.DataSets.Internet().Password();
                Day = new Bogus.Randomizer().Number(1, 31);//////
                Month = new Bogus.Randomizer().Number(1, 12);//////
                Year = new Bogus.Randomizer().Number(1944, 2022);//////
                Company = new Bogus.DataSets.Company().CompanyName();
                Address1 = new Bogus.DataSets.Address().StreetAddress();
                Address2 = new Bogus.DataSets.Address().StreetAddress();
                City = new Bogus.DataSets.Address().City();
                State = new Bogus.DataSets.Address().State();
                Country = "United States";
                PostalCode = new Bogus.DataSets.Address().ZipCode("#####");//
                Additionalinformation = new Bogus.DataSets.Lorem().Slug();
                Homephone = new Bogus.DataSets.PhoneNumbers().PhoneNumberFormat();
                Mobilephone = new Bogus.DataSets.PhoneNumbers().PhoneNumberFormat();
                Futureaddress = new Bogus.DataSets.Address().StreetAddress();
                FlagsAttribute = true;
            }
        }
        public static Bogus.DataSets.Name.Gender GetGender(int gender)
        {
            Bogus.DataSets.Name.Gender gendertype = Bogus.DataSets.Name.Gender.Male;
            if (gender == 1)
            {
                gendertype =  Bogus.DataSets.Name.Gender.Male;
            }
            else if (gender == 2)
            {
                gendertype =  Bogus.DataSets.Name.Gender.Female;
            }
            return gendertype;
        }
        

        public int Gender { get => gender; set => gender = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Country { get => country; set => country = value; }
        public string Additionalinformation { get => additionalinformation; set => additionalinformation = value; }
        public string Homephone { get => homephone; set => homephone = value; }
        public string Mobilephone { get => mobilephone; set => mobilephone = value; }
        public string Futureaddress { get => futureaddress; set => futureaddress = value; }
    }
}
