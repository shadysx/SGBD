using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Text.RegularExpressions;

namespace BLL
{
    public class RulesBookAccount : AbstractValidator<Account>
    {
        public RulesBookAccount()
        {
            RuleFor(a => a.ACCOUNT_EMAIL).Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
            RuleFor(a => a.ACCOUNT_USERNAME).Matches("^[A-Za-z][A-Za-z0-9_]{4,25}$");
            RuleFor(a => a.ACCOUNT_USERNAME).Length(4,25);
            RuleFor(a => a.ACCOUNT_PASSWORD).Length(8,49);
            RuleFor(a => a.ACCOUNT_LAST_NAME).Matches("^[a-zA-Z ,.'-]+$");
            RuleFor(a => a.ACCOUNT_LAST_NAME).Length(1, 99);
            RuleFor(a => a.ACCOUNT_FIRST_NAME).Matches("^[a-zA-Z ,.'-]+$");
            RuleFor(a => a.ACCOUNT_FIRST_NAME).Length(1, 99);
            RuleFor(a => a.ACCOUNT_BIRTH_DATE).InclusiveBetween(new DateTime(1880, 1, 1), DateTime.Now);
            RuleFor(a => a.ACCOUNT_ADDRESS).Length(1, 249);
            RuleFor(a => a.ACCOUNT_CITY).Length(1,49);
            RuleFor(a => a.ACCOUNT_POSTAL_CODE).Matches("^([0-9]+)(([-]|[0-9])*)([0-9]+)$");
            RuleFor(a => a.ACCOUNT_POSTAL_CODE).Length(1, 49);
            RuleFor(a => a.ACCOUNT_COUNTRY).Matches("^[a-zA-Z ,.'-]+$");
            RuleFor(a => a.ACCOUNT_COUNTRY).Length(1, 49);                        
        }
    }
}
