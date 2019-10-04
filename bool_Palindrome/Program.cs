using System;

namespace bool_Palindrome
{
    class Program
    {
        public static bool Palindrome(string input)
        {
            bool flag = false;
            if (input == "")
            {
                Console.WriteLine("Not a valid input");
            }
            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Palindrome("Level"));
        }
    }
}
