using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public static class CustomColor
    {
        public static Color DarkBlue 
        {
            get        
            {                
                return Color.FromArgb(7, 8, 38);
            }
        }

        public static Color Orange
        {
            get
            {
                return Color.FromArgb(254, 137, 8);
            }
        }

        public static Color Custom3
        {
            get
            {
                return Color.FromArgb(198, 139, 89);
            }
        }

        public static Color Custom4
        {
            get
            {
                return Color.FromArgb(215, 177, 157);
            }
        }
    }
}
