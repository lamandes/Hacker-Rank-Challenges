using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            //O(n(n-1) runtime as it is unsorted and requires nested for loop each element
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    int dif = Math.Abs(elements[i] - elements[j]);
                    if (dif > maximumDifference)
                    {
                        maximumDifference = dif;
                    }
                }
            }
        }
        
    } 
}
