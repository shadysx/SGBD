using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string ACCOUNT_EMAIL { get; set; }
        public string ACCOUNT_USERNAME { get; set; }
        public string ACCOUNT_PASSWORD { get; set; }

        public string ACCOUNT_LAST_NAME { get; set; }
        public string ACCOUNT_FIRST_NAME { get; set; }
        public DateTime ACCOUNT_BIRTH_DATE { get; set; }
        public string ACCOUNT_ADDRESS { get; set; }
        public string ACCOUNT_CITY { get; set; }
        public string ACCOUNT_POSTAL_CODE { get; set; }
        public string ACCOUNT_COUNTRY { get; set; }
        public string ACCOUNT_ROLE { get; set; }
        public override string ToString()
        {
            return "ACCOUNT_EMAIL: " + ACCOUNT_EMAIL + "\n" +
                    "ACCOUNT_USERNAME: " + ACCOUNT_USERNAME + "\n" +
                    "ACCOUNT_PASSWORD: " + ACCOUNT_PASSWORD + "\n" +
                    "ACCOUNT_LAST_NAME: " + ACCOUNT_LAST_NAME + "\n" +
                    "ACCOUNT_FIRST_NAME: " + ACCOUNT_FIRST_NAME + "\n" +
                    "ACCOUNT_BIRTH_DATE: " + ACCOUNT_BIRTH_DATE + "\n" +
                    "ACCOUNT_ADDRESS: " + ACCOUNT_ADDRESS + "\n" +
                    "ACCOUNT_CITY: " + ACCOUNT_CITY + "\n" +
                    "ACCOUNT_POSTAL_CODE: " + ACCOUNT_POSTAL_CODE + "\n" +
                    "ACCOUNT_COUNTRY: " + ACCOUNT_COUNTRY + "\n" +
                    "ACCOUNT_ROLE: " + ACCOUNT_ROLE + "\n";
        }

    }


}
