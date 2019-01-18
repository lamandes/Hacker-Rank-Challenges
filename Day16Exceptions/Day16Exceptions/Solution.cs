using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Exceptions
{
    class Solution
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                Console.WriteLine(int.Parse(s));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Bad String");
            }

            //Optional to use finally
            finally
            {
                Console.WriteLine("Program exiting!");
            }
        }
    }
}
