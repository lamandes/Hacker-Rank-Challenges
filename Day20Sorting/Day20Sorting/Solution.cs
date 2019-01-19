using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int totalSwap = 0;
        //Bubblesort which has runtime O(n^2)
        for (int i = 0; i < a.Length; i++)
        {
            int numberOfSwapsInCurrentRun = 0;
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    //Swap elements
                    int tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                    numberOfSwapsInCurrentRun++;
                }
            }

            //Break if array is sorted
            if (numberOfSwapsInCurrentRun == 0)
            {
                break;
            }
            totalSwap += numberOfSwapsInCurrentRun;
        }

        Console.WriteLine("Array is sorted in {0} swaps.\nFirst Element: {1}\nLast Element: {2}", totalSwap, a[0], a[a.Length - 1]);
    }
}