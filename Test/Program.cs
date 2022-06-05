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
            /*
            try
            {
                Console.WriteLine("Hello world");
                Console.Read();
                //Auth.Login("ShadySX", "password");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Auth.CurrentUser);
            */

            decimal d = 420.30m;
            string s = Convert.ToInt32(d).ToString() + "." + d.ToString().Substring(d.ToString().Length - 2);
            
            Console.WriteLine(s);

            Console.Read();
        }
    }
}
