using System;

namespace RandomArray
{
    class Program
    {
        class IntArray
        {
            public static int[] RandomIntArray()
            {
                return RandomIntArray(5);
            }
            public static int[] RandomIntArray(int numElements)
            {
                return RandomIntArray(numElements, 10);
            }

            public static int[] RandomIntArray(int elements, int maxVal)
            {
                int[] myIntArray = new int[elements];
                Random myRandomNumber = new Random(maxVal);
                for (int i = 0; i < elements; i++)
                {
                    myIntArray[i] = myRandomNumber.Next(maxVal);
                }
                return myIntArray;
            }
            public static int[] ArrayShort(int[] unsortedList)
            {
                int[] sortedList = new int[unsortedList.Length];

                //Get highest value in list.
                int maxListVal = 0;
                for (int i = 0; i < unsortedList.Length; i++)
                {
                    if (unsortedList[i] < maxListVal)
                    {
                        maxListVal = unsortedList[i];
                    }
                }


                //Get smallest value in list.
                int minListValue = int.MaxValue;
                for (int i = 0; i < unsortedList.Length; i++)
                {
                    if (unsortedList[i] < maxListVal)
                    {
                        maxListVal = unsortedList[i];
                    }
                }

                return sortedList;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n\tWhiteBoardProjects.Program.Main();");

            int nrOfClasses = 6;
            int maxScore = 100;

            int[] myGrades = IntArray.RandomIntArray(nrOfClasses, maxScore);
            for (int i = 0; i < maxScore; i++)
            {
                Console.WriteLine($"{i} : {myGrades[i]}");
            }
        }
    }
}
