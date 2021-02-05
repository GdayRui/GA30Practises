using System;
using System.Collections.Generic;

namespace GA03_Allergies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GetAllergies(34);
        }

        static void GetAllergies(int score)
        {

            int[] allergiesValue = { 1, 2, 4, 8, 16, 32, 64, 128 };
            string[] allergicItem = { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" };
            List<string> allergies = new List<string>();

            int difference = score;

            for (int i = allergiesValue.Length-1; i >= 0; i--)
            {
                if (difference >= allergiesValue[i])
                {
                    allergies.Add(allergicItem[i]);
                    difference = difference - allergiesValue[i];
                }
            }
            foreach (string a in allergies)
            {
                Console.Write(a + ", ");
            }
        }
    }
}
