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

        public static Color LightBlue
        {
            get
            {
                return Color.FromArgb(37, 38, 88);
            }
        }

        public static Color White
        {
            get
            {
                return Color.FromArgb(240, 240, 240);
            }
        }
    }
}
