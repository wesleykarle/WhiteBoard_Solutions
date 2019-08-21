using System;

namespace OccurrenceCount
{
    public class Program
    {
        public static int CountOccurrence(string input, char testchar)
        {
            int count = 0;
            foreach (char nextchar in input)
            {
                if (nextchar == testchar)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.CountOccurrence("supercalifragilisticexpialidocious", 'i'));
        }
    }
}
