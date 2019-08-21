using System;

// Wil return count of input for all variables.
namespace ReturnNum
{
    class Program
    {
        public static int Count(string input)
        {
            input = "Hello123!!";
            int count = 0;
            foreach (var item in input)
            {
                count++;
            }
            return count;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Count(""));
        }
    }
}
