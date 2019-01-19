using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17MoreExceptions
{
    class Calculator
    {
        public Calculator()
        {
            //Empty Constructor
        }

        public int power(int n, int p)
        {
            //1.Throw exception for n and p should be negative
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            //2. Check if power is zero, then reuturn 1
            if (p == 0)
            {
                return 1;
            }

            //3. Else calculate p power of n
            int result = n;
            while (p > 1)
            {
                result *= n;
                p--;
            }
            return result;
        }
    }
}
