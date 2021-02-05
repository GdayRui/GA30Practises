using System;
using System.Collections.Generic;

namespace GA02_WinnieThePoohsHoney
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            GetOpenHoneyJar();
        }

        static void GetOpenHoneyJar()
        {
           // List<int> indexOfOpenJarList = new List<int>();

            bool[] jarList = new bool[100];

            // 2. Visit the target jars and change their states 100 rounds.
            for (int i = 1; i <= jarList.Length; i++)
            {
                for (int j = i * 1; j <= 100; j += i)
                {
                    // 1. Change the target jars'bool to their opposite state in Array jarList.
                    jarList[j - 1] = !jarList[j - 1];
                }
            }

            // 3. Get all open jars' indexs and put in array indexOfOpenJarList.
            for (int i = 1; i <= jarList.Length; i++)
            {
                if (jarList[i - 1] == true)
                {
                    //indexOfOpenJarList.Add(i);
                    Console.WriteLine(i);
                }
            }

            //for (int i = 0; i < indexOfOpenJarList.Count; i++)
            //{
            //    int index = indexOfOpenJarList[i];
            //    Console.WriteLine(index);
            //}

            //return indexOfOpenJarList;
        }
    }
}
