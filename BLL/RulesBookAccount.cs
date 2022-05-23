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
            RuleFor(a => a.ACCOUNT_EMAIL).Matches(@"^((.{4,50})([@])([a-z]{2,10})[.]([a-z]{2,3}))$");
            RuleFor(a => a.ACCOUNT_USERNAME).Matches("^\\S+$");
            RuleFor(a => a.ACCOUNT_USERNAME).Length(4,99);
            RuleFor(a => a.ACCOUNT_PASSWORD).Length(8,49);
            RuleFor(a => a.ACCOUNT_LAST_NAME).Matches("^((([A-Z]{1})([a-z]+))((((\\s|[-]))[A-Z]{1})([a-z]+))*)$");
            RuleFor(a => a.ACCOUNT_LAST_NAME).Length(1, 99);
            RuleFor(a => a.ACCOUNT_FIRST_NAME).Matches("^((([A-Z]{1})([a-z]+))((((\\s|[-]))[A-Z]{1})([a-z]+))*)$");
            RuleFor(a => a.ACCOUNT_FIRST_NAME).Length(1, 99);
            RuleFor(a => a.ACCOUNT_BIRTH_DATE).InclusiveBetween(new DateTime(1880, 1, 1), DateTime.Now);
            RuleFor(a => a.ACCOUNT_ADDRESS).Length(1, 249);
            RuleFor(a => a.ACCOUNT_CITY).Length(1,49);
            RuleFor(a => a.ACCOUNT_POSTAL_CODE).Matches("^([0-9]+)(([-]|[0-9])*)([0-9]+)$");
            RuleFor(a => a.ACCOUNT_POSTAL_CODE).Length(1, 49);
            RuleFor(a => a.ACCOUNT_COUNTRY).Matches("^(\\D)+$");
            RuleFor(a => a.ACCOUNT_COUNTRY).Length(1, 49);                        
        }
    }
}
