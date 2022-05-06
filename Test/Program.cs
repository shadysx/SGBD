using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BLL;
using DAL;

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

            Console.WriteLine(Regex.Match("LiDelLaCosta", "^\\S+$").Success);

             

            Console.Read();
        }
    }
}
