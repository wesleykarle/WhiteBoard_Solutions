using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] myArray = { 1, 2, 3, 4, 5 };
            foreach (int i in myArray)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
