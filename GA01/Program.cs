using System;
using System.Collections.Generic;

namespace GA01_RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            ConvertToRomanNumber(110);
        }

        static string ConvertToRomanNumber1(int num)
        {
            // I1, V5, X10, L50, C100, D500, M1000

            string thousands = "", hundreds = "", tens = "", ones = "", romanNumber = "";

            // if the given number is 4 digits and maxmam is 3000
            //if (digit / 1000 >= 1 && digit / 1000 <= 3)
            //{
                
            //    int integer = Decimal.ToInt32(digit / 1000);
            //    if (integer == 1)
            //    {
            //        thousands = "M";
            //    }
            //    if (integer == 2)
            //    {
            //        thousands = "MM";
            //    }
            //    if (integer == 3)
            //    {
            //        thousands = "MMM";
            //    }

            //    // if the given number is 3 digits
            //    if (digit / 1000 < 1)
            //    {
            //        int integer2 = Decimal.ToInt32(digit / 100);
            //        if (digit / 100 >= 1)
            //        {
            //            if (integer2 == 9)
            //            {
            //                hundreds = "CM";
            //            }
            //            //if (integer2 < 9 && integer2 > 5)
            //            //{
            //            //    hundreds = "";
            //            //}
            //            if (integer2 == 8)
            //            {
            //                hundreds = "DCCC";
            //            }
            //            if (integer2 == 7)
            //            {
            //                hundreds = "DCC";
            //            }
            //            if (integer2 == 6)
            //            {
            //                hundreds = "DC";
            //            }
            //            if (integer2 == 5)
            //            {
            //                hundreds = "D";
            //            }
            //            if (integer2 == 4)
            //            {
            //                hundreds = "XC";
            //            }
            //            //if (integer2 > 1 && integer2 < 4)
            //            //{
            //            //    hundreds = "";
            //            //}
            //            if (integer2 == 3)
            //            {
            //                hundreds = "CCC";
            //            }
            //            if (integer2 == 2)
            //            {
            //                hundreds = "CC";
            //            }
            //            if (integer2 == 1)
            //            {
            //                hundreds = "C";
            //            }
            //        }
            //        else
            //        {
            //            // if the given number is 2 digits
            //            if (digit / 10 >= 1)
            //            {
            //                int integer3 = Decimal.ToInt32(digit / 10);
            //                if (integer3 == 9)
            //                {
            //                    tens = "CX";
            //                }
            //                if (integer3 == 8)
            //                {
            //                    tens = "LXXX";
            //                }
            //                if (integer3 == 5)
            //                {
            //                    tens = "L";
            //                }
            //                if (integer3 == 4)
            //                {
            //                    tens = "XL";
            //                }
            //                if (integer3 == 3)
            //                {
            //                    tens = "XXX";
            //                }
            //                if (integer3 == 2)
            //                {
            //                    tens = "XX";
            //                }
            //                if (integer3 == 1)
            //                {
            //                    tens = "X";
            //                }
            //            }
            //            else
            //            {
            //                // if the given number is 1 digit
            //                if (digit == 9)
            //                {
            //                    ones = "IX";
            //                }
            //                if (digit == 8)
            //                {
            //                    ones = "VIII";
            //                }
            //                if (digit == 7)
            //                {
            //                    ones = "VII";
            //                }
            //                if (digit == 6)
            //                {
            //                    ones = "VI";
            //                }
            //                if (digit == 5)
            //                {
            //                    ones = "V";
            //                }
            //                if (digit == 4)
            //                {
            //                    ones = "IV";
            //                }
            //                if (digit == 3)
            //                {
            //                    ones = "III";
            //                }
            //                if (digit == 2)
            //                {
            //                    ones = "II";
            //                }
            //                if (digit == 1)
            //                {
            //                    ones = "I";
            //                }
            //            }
            //        }
            //    }

            //    romanNumber = String.Concat(thousands, hundreds, tens, ones);
            //    //return romanNumber;
            //}
            //else if (digit > 3000)
            //{
            //    Console.WriteLine("The given number is out of scope and cannot convert to Roman number");
            //    //return String.Empty;
            //}

            // get each digit of the given number
            List<int> digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num = num / 10;
            }
            //digits.Reverse();
            digits.ToArray();

            int n = digits.Count;
            // thousands
            if (n == 4)
            {
                switch (digits[4])
                {
                    case 1:
                        thousands = "M";
                        break;
                    case 2:
                        thousands = "MM";
                        break;
                    case 3:
                        thousands = "MMM";
                        break;
                    default:
                        break;

                }
            }
            // hundres
            switch (digits[3])
            {
                case 1:
                    hundreds = "C";
                    break;
                case 2:
                    hundreds = "CC";
                    break;
                case 3:
                    hundreds = "CCC";
                    break;
                case 4:
                    hundreds = "CD";
                    break;
                case 5:
                    hundreds = "D";
                    break;
                case 6:
                    hundreds = "DC";
                    break;
                case 7:
                    hundreds = "DCC";
                    break;
                case 8:
                    hundreds = "DCCC";
                    break;
                case 9:
                    hundreds = "CM";
                    break;
                default:
                    break;
            }

            switch (digits[1])
            {
                case 1:
                    tens = "X";
                    break;
                case 2:
                    tens = "XX";
                    break;
                case 3:
                    tens = "XXX";
                    break;
                case 4:
                    tens = "XL";
                    break;
                case 5:
                    tens = "L";
                    break;
                case 6:
                    tens = "LX";
                    break;
                case 7:
                    tens = "LXX";
                    break;
                case 8:
                    tens = "LXXX";
                    break;
                case 9:
                    tens = "XC";
                    break;
                default:
                    break;
            }

            switch (digits[0])
            {
                case 1:
                    ones = "I";
                    break;
                case 2:
                    ones = "II";
                    break;
                case 3:
                    ones = "III";
                    break;
                case 4:
                    ones = "IV";
                    break;
                case 5:
                    ones = "V";
                    break;
                case 6:
                    ones = "VI";
                    break;
                case 7:
                    ones = "VII";
                    break;
                case 8:
                    ones = "VIII";
                    break;
                case 9:
                    ones = "IX";
                    break;
                default:
                    break;
            }

            romanNumber = String.Concat(thousands, hundreds, tens, ones);

            Console.WriteLine(romanNumber);
            return romanNumber;
        }

        static string ConvertToRomanNumber(int num)
        {
            // 1. Get each digit of the given number and make them in an array.
            List<int> digits = new List<int>();
            if (num <= 0)
            {
                Console.WriteLine("The given number is out of scop.");
            }
            while (num > 0)
            {
                digits.Add(num % 10);
                num = num / 10;
            }
            
            digits.ToArray();

            // 2. Init each position of Roman number.
            string ones = "", tens = "", hundreds = "", thousands = "";

            // 3. Convert given number to Roman number from ones position.
            if (digits.Count > 0)
            {
                switch (digits[0])
                {
                    case 1:
                        ones = "I";
                        break;
                    case 2:
                        ones = "II";
                        break;
                    case 3:
                        ones = "III";
                        break;
                    case 4:
                        ones = "IV";
                        break;
                    case 5:
                        ones = "V";
                        break;
                    case 6:
                        ones = "VI";
                        break;
                    case 7:
                        ones = "VII";
                        break;
                    case 8:
                        ones = "VIII";
                        break;
                    case 9:
                        ones = "IX";
                        break;
                    default:
                        break;
                }
            }

            if (digits.Count > 1)
            {
                switch (digits[1])
                {
                    case 1:
                        tens = "X";
                        break;
                    case 2:
                        tens = "XX";
                        break;
                    case 3:
                        tens = "XXX";
                        break;
                    case 4:
                        tens = "XL";
                        break;
                    case 5:
                        tens = "L";
                        break;
                    case 6:
                        tens = "LX";
                        break;
                    case 7:
                        tens = "LXX";
                        break;
                    case 8:
                        tens = "LXXX";
                        break;
                    case 9:
                        tens = "XC";
                        break;
                    default:
                        break;
                }

            }

            if (digits.Count > 2)
            {
                switch (digits[2])
                {
                    case 1:
                        hundreds = "C";
                        break;
                    case 2:
                        hundreds = "CC";
                        break;
                    case 3:
                        hundreds = "CCC";
                        break;
                    case 4:
                        hundreds = "CD";
                        break;
                    case 5:
                        hundreds = "D";
                        break;
                    case 6:
                        hundreds = "DC";
                        break;
                    case 7:
                        hundreds = "DCC";
                        break;
                    case 8:
                        hundreds = "DCCC";
                        break;
                    case 9:
                        hundreds = "CM";
                        break;
                    default:
                        break;
                }
            }

            if (digits.Count > 3)
            {
                switch (digits[3])
                {
                    case 1:
                        thousands = "M";
                        break;
                    case 2:
                        thousands = "MM";
                        break;
                    case 3:
                        thousands = "MMM";
                        break;
                    default:
                        Console.WriteLine("The given number is out of scop.");
                        break;
                }

            }

            string romanNumber = String.Concat(thousands, hundreds, tens, ones);

            Console.WriteLine("The result Roman number is "+romanNumber);
            return romanNumber;
        }
    }
}
