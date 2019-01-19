using System;

namespace Day21Generics
{
    class Printer
    {

        /**
        *    Name: PrintArray
        *    Print each element of the generic array on a new line. Do not return anything.
        *    @param A generic array
        **/
        static void PrintArray<T>(T[] genericArray)
        {
            //Read only generic array
            foreach (T element in genericArray)
            {
                Console.WriteLine(element.ToString());
            }
        }
    

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }
    }
}
