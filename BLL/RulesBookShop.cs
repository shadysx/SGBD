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
    public class RulesBookShop : AbstractValidator<Shop>
    {
        public RulesBookShop()
        {                                    
            RuleFor(s => s.SHOP_NAME).Length(1, 149);                     
            RuleFor(s => s.SHOP_ADDRESS).Length(1, 149);
            RuleFor(s => s.SHOP_CITY).Length(1, 49);
            RuleFor(s => s.SHOP_POSTAL_CODE).Matches("^([0-9]+)(([-]|[0-9])*)([0-9]+)$");
            RuleFor(s => s.SHOP_POSTAL_CODE).Length(1, 14);
            RuleFor(s => s.SHOP_COUNTRY).Matches("^[a-zA-Z ,.'-]+$");
            RuleFor(s => s.SHOP_COUNTRY).Length(1, 49);
        }
    }
}
