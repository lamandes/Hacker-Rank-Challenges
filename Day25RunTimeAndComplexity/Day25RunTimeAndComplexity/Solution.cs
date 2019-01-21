using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] arr = new int[T];
        int i = 0;
        while (T-- > 0)
        {
            arr[i] = int.Parse(Console.ReadLine());
            i++;
        }

        for (int loop = 0; loop < arr.Length; loop++)
        {
            int curNum = arr[loop];
            bool notPrime = false;
            int numOfDivisible = 0;
            int[] divisor = new int[2];
            int index = 0;
            for (int prime = 1; prime < curNum + 1; prime++)
            {
                if (curNum % prime == 0)
                {
                    divisor[index] = prime;
                    numOfDivisible++;
                    if (index < 1)
                    {
                        index++;
                    }
                }
                if (numOfDivisible > 2)
                {
                    //Once there is more than 3 divisor break the loop and print not prime immediately
                    notPrime = true;
                    break;
                }
                
            }
            if (notPrime || !(divisor[0] == 1 && divisor[1] == curNum))
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
            
        }
    }
}

