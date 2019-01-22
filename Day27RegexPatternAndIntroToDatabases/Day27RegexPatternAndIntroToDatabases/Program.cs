using System.Collections;
using System.Text.RegularExpressions;
using System;

namespace Day27RegexPatternAndIntroToDatabases
{
    public class Solution
    {
        //private varaiables
        private ArrayList array;

        //public constructor
        public Solution()
        {
            this.array = new ArrayList();
        }

        public void insertGmail(string firstName, string emailID)
        {
            string pattern = @"\b(\w+?)\@gmail.com";

            //Regular expression that matches Anything@gmail.com
            Regex rx = new Regex(pattern);
            Match match = rx.Match(emailID);
            if (match.Length != 0)
            {
                array.Add(firstName);
            }
            //else do nothing, no insert to array
        }

        public ArrayList getArray()
        {
            return array;
        }

        public void sort()
        {
            array.Sort();
        }

        /**
         * Main method
         **/
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            //Create an arraylist for storing all @gmail.com and sorting later
            Solution sol = new Solution();
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];
                sol.insertGmail(firstName, emailID);
            }

            //Sort arraylist
            sol.sort();
            foreach (string s in sol.getArray())
            {
                Console.WriteLine(s);
            }
        }
    }
}




