using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Auth.Login("ShadySX", "password");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Auth.CurrentUser);



            Console.Read();
        }
    }
}
