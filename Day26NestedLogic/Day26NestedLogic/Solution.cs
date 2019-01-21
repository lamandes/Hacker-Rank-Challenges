using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26NestedLogic
{
    class Solution
    {
        static int caculateFine(string[] szActual, string[] szExpected)
        {
            //szActual, szExpected [0]  = Day
            //szActual, szExpected [1]  = Month
            //szActual, szExpected [2]  = Year
            int fine = 0;
            int actualDay, actualMonth, actualYear;
            int expectedDay, expectedMonth, expectedYear;
            actualDay = int.Parse(szActual[0]);
            actualMonth = int.Parse(szActual[1]);
            actualYear = int.Parse(szActual[2]);
            expectedDay = int.Parse(szExpected[0]);
            expectedMonth = int.Parse(szExpected[1]);
            expectedYear = int.Parse(szExpected[2]);

            if (actualYear > expectedYear)
            {
                fine = 10000;
            }
            else if ((actualYear == expectedYear) && (actualMonth > expectedMonth))
            {
                fine = 500 * (actualMonth - expectedMonth);
            }
            else if ((actualYear == expectedYear) && (actualMonth == expectedMonth) && (actualDay > expectedDay))
            {
                fine = 15 * (actualDay - expectedDay);
            }
            else
            {
                fine = 0;
            }
            return fine;
        }

        static void Main(string[] args)
        {
            string[] szActualReturn = Console.ReadLine().Split(' ').ToArray();
            string[] szExpectedReturn = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(caculateFine(szActualReturn, szExpectedReturn));
        }
    }
}
