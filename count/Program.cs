using System;

namespace count
{
    class Program
    {
        public static int CountWords(string str)
        {
      
            int counts = 0;
            int countw = 0;
            foreach (var c in str)
            {
                if (c == ' ' || c > 0)
                {
                    counts++;
                    countw++;
                }
            }
            return countw;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.CountWords("Hello World!"));
        }
    }
}