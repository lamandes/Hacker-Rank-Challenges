using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29BitwiseAnd
{
    class Solution
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int maxNum = -1;
                //Between 1 to n
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = i + 1; j < n + 1; j++)
                    {
                        int curNum = i & j;
                        if (curNum > maxNum && curNum < k)
                        {
                            maxNum = curNum;
                        }
                    }
                }
                Console.WriteLine(maxNum);
            }
        }
    }
}
