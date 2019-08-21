using System;

namespace JulianDate
{
    public class Calendar
    {
        public static int JulianDate(int mon, int day)
        {
            int[] month = {0,
                           31,28,31,30,31,30,
                           31,31,30,31,30,31};
            int julian = day;
            for (int i = 0; i < mon; i++)
            {
                julian += month[i];
            }
            return julian;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tJulianDate.Calendar.Main()");
            Console.WriteLine(Calendar.JulianDate(7, 7));

        }
    }
}