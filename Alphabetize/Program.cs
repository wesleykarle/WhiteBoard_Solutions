using System;
using System.Linq;

namespace Alphabetize
{
    public class Program
    {
        public static string Alphabetize(string word)
        {
            string results = string.Empty;
            foreach (char nextchar in "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz")
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (nextchar == word[i])
                    {
                        results += nextchar;
                    }
                }
            }
            return results;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Alphabetize("abcABC"));
        }
    }
}
