using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Interfaces
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int divisor = 1; divisor < n + 1; divisor++)
            {
                if (n % divisor == 0)
                {
                    sum += divisor;
                }
            }
            return sum;
        }
    }
}
