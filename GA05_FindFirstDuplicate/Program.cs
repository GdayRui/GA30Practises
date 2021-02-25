using System;

namespace GA05_FindFirstDuplicate
{
    class Program
    {
        private static int duplicateNum;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FindFirstDuplicate(new int[] { 6, 7, 4, 5, 3, 5, 1, 7 });
            Console.WriteLine(duplicateNum);
        }

        // given a list of unordered numbers with at least duplicate number

        // write a function that returns the first pair you found

        // for example in the following array of numbers, 5 is the duplicate number

        // [6,7,4,5,3,5,1] //=> 5

        static int FindFirstDuplicate(int[] givenNums)
        {

            int arrLength = givenNums.Length;

            bool isFound = false;
            for (int i=0; i<givenNums.Length && !isFound; i++)
            {
                for (int j=i+1; j<givenNums.Length; j++)
                {
                    int firstNum = givenNums[i];
                    int secondNum = givenNums[j];
                    if (firstNum == secondNum)
                    {
                        duplicateNum = givenNums[i];
                        isFound = true;
                    }
                }
            }

            return duplicateNum;
        }
    }
}
