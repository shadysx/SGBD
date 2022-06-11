using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL;
using DAL;
using DTO;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account()
            {
                ACCOUNT_EMAIL = "testemployee@gmail.com",
                ACCOUNT_USERNAME = "blyat",
                ACCOUNT_PASSWORD = "password",
                ACCOUNT_LAST_NAME = "vladimir",
                ACCOUNT_FIRST_NAME = "putin",
                ACCOUNT_BIRTH_DATE = new DateTime(2008, 3, 1, 7, 0, 0),
                ACCOUNT_COUNTRY = "Russie",
                ACCOUNT_ROLE = "EMPLOYEE",
                ID_SHOP = 3
            };

            

            try
            {
                Auth.SignUp(acc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
