using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] arr = new int[T];
        int add = 0;
        while (T-- > 0)
        {
            arr[add] = int.Parse(Console.ReadLine());
            add++;
        }
        //Using 6k ± 1 optimization, divide by 2, 3, 5, 7, 11, 13 etc... up to square root of number
        for (int loop = 0; loop < arr.Length; loop++)
        {
            int curNum = arr[loop];
            bool bPrime = true;
            if (curNum <= 3)
            {
                bPrime = curNum > 1;
            }
            else if (curNum % 2 == 0 || curNum % 3 == 0)
            {
                bPrime = false;
            }
            else
            {
                int i = 5;
                //int squareRootOfNum = Convert.ToInt32(Math.Ceiling(Math.Sqrt(curNum)));
                while ((i * i) <= curNum)
                {
                    if ((curNum % i == 0) || (curNum % (i + 2) == 0))
                    {
                        bPrime = false;
                        break;
                    }
                    i += 6;
                }
            }
            if (bPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            
        }
    }
}

