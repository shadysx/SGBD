using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Text.RegularExpressions;


namespace BLL
{
    public class LogicLayer
    {
        public static bool[] CheckValidityNewAccount(Account newAccount, List<Account> accounts, bool[] tabErrors )
        {
            try
            {
                /* CHECK IF USERNAME ALREADY EXIST  (ERROR [0])  */

                foreach (Account a in accounts)
                {
                    if (a.ACCOUNT_USERNAME == newAccount.ACCOUNT_USERNAME)
                        tabErrors[0] = true;
                }

                /* CHECK IF USERNAME HAVE AN "ESPACE"  (ERROR [1])  */

                if (!Regex.Match(newAccount.ACCOUNT_USERNAME, "^\\S+$").Success)
                    tabErrors[1] = true;

                /* CHECK USERNAME LENGTH (minimum 4, maximum 99)  (ERROR [2])  */

                foreach (Account a in accounts)
                {
                    if (a.ACCOUNT_USERNAME.Length > 99)
                        tabErrors[2] = true;
                }

                /* CHECK IF EMAIL PATTERN IS OK (ERROR[3]) */

                if (!Regex.Match(newAccount.ACCOUNT_EMAIL.ToLower(), @"^((.{4,50})([@])([a-z]{2,10})[.]([a-z]{2,3}))$").Success)
                    tabErrors[3] = true;


                /* CHECK IF EMAIL ALREADY EXIST (ERROR[4]) */

                foreach (Account a in accounts)
                {
                    if (a.ACCOUNT_EMAIL == newAccount.ACCOUNT_EMAIL)
                        tabErrors[4] = true;
                }

                /* CHECK PASSWORD SIZE (ERROR[5]) */

                if (!Regex.Match(newAccount.ACCOUNT_PASSWORD, "^((.){8,49})$").Success)
                    tabErrors[5] = true;


                /* CHECK LAST NAME PATTERN (ERROR[6]) */

                if (!Regex.Match(newAccount.ACCOUNT_LAST_NAME, "^((([A-Z]{1})([a-z]+))((((\\s|[-]))[A-Z]{1})([a-z]+))*)$").Success)
                    tabErrors[6] = true;

                /* CHECK LAST NAME LENGTH (ERROR[7]) */

                if (newAccount.ACCOUNT_LAST_NAME.Length > 99)
                    tabErrors[7] = true;

                /* CHECK FIRST NAME PATTERN (ERROR[8]) */

                if (!Regex.Match(newAccount.ACCOUNT_FIRST_NAME, "^((([A-Z]{1})([a-z]+))((((\\s|[-]))[A-Z]{1})([a-z]+))*)$").Success)
                    tabErrors[8] = true;

                /* CHECK FIRST NAME LENGTH (ERROR[9]) */

                if (newAccount.ACCOUNT_FIRST_NAME.Length > 99)
                    tabErrors[9] = true;

                /* CHECK DATE VALIDITY BETWEEN [1880 and Now] (ERROR[10]) */

                if (newAccount.ACCOUNT_BIRTH_DATE < new DateTime(1880, 1, 1) || newAccount.ACCOUNT_BIRTH_DATE > DateTime.Now)
                    tabErrors[10] = true;

                /* CHECK ADDRESS LENGTH (ERROR[11]) */

                if (newAccount.ACCOUNT_ADDRESS.Length > 249)
                    tabErrors[11] = true;

                /* CHECK CITY LENGTH (ERROR[12]) */

                if (newAccount.ACCOUNT_CITY.Length > 49)
                    tabErrors[12] = true;

                /* CHECK POSTAL CODE PATTERN (ERROR[13]) */

                if (!Regex.Match(newAccount.ACCOUNT_POSTAL_CODE, "^([0-9]+)(([-]|[0-9])*)([0-9]+)$").Success)
                    tabErrors[13] = true;

                /* CHECK POSTAL CODE (ERROR[14]) */

                if (newAccount.ACCOUNT_POSTAL_CODE.Length > 49)
                    tabErrors[14] = true;

                /* CHECK COUNTRY PATTERN (ERROR[15]) */

                if (!Regex.Match(newAccount.ACCOUNT_COUNTRY, "^(\\D)+$").Success)
                    tabErrors[15] = true;

                /* CHECK COUNTRY LENGTH (ERROR[16]) */

                if (newAccount.ACCOUNT_COUNTRY.Length > 49)
                    tabErrors[16] = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

            return tabErrors;

        }
    }
}
