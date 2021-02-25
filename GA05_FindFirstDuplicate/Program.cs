using System;
using System.Collections.Generic;

namespace GA05_FindFirstDuplicate
{
    class Program
    {
        //private static int[] duplicateNums;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FindFirstDuplicate(new int[] { 6, 7, 4, 5, 3, 5, 1, 7 });
            FindFirstDuplicate(new int[] { 6 });
            FindFirstDuplicate(new int[] { 6, 7, 4, 5, 3 });
            
        }

        // given a list of unordered numbers with at least duplicate number

        // write a function that returns the first pair you found

        // for example in the following array of numbers, 5 is the duplicate number

        // [6,7,4,5,3,5,1] //=> 5

        static List<int> FindFirstDuplicate(int[] givenNums)
        {
            List<int> duplicateNums = new List<int>();

            if (givenNums.Length <= 1)
                Console.WriteLine("Please give a number list that includes more than 2 numbers.");

            else
            {
                // Set a flag to break the loop once find the first duplicate
                bool isFound = false;
                for (int i = 0; i < givenNums.Length && !isFound; i++)
                {
                    for (int j = i + 1; j < givenNums.Length; j++)
                    {
                        int firstNum = givenNums[i];
                        int secondNum = givenNums[j];
                        if (firstNum == secondNum)
                        {
                            duplicateNums.Add(givenNums[i]);
                            duplicateNums.Add(givenNums[j]);
                            isFound = true;
                        }
                    }
                }

                if (duplicateNums.Count == 2)
                    Console.WriteLine("The duplicate numbers are ['{0}', '{1}']", duplicateNums[0], duplicateNums[1]);
                else
                    Console.WriteLine("There are not duplicate numbers in this list.");

            }

            return duplicateNums;

        }
    }
}
