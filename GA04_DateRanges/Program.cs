using System;

namespace GA04_DateRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string[] givenDates = { "2016-07-31", "2020-09-21" };

            MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
            //MakeFriendlyDates(new string[] { "2016-07-31", "2020-09-21" });
        }

        static string[] MakeFriendlyDates(string[] givenDates)
        {
            string[] friendlyDates = new string[2];

            string beginningFriendlyDate = "";
            string endFrindlyDate = "";

            string friendlyYearOfBeginning = "";
            string friendlyMonthOfBeginning = "";
            string friendlyDayOfBeginning = "";

            string friendlyYearOfEnd = "";
            string friendlyMonthOfEnd = "";
            string friendlyDayOfEnd = "";

            string[] months = { "January", "Feburay", "March", "Apirl", "May", "June", "July", "August", "September", "October", "November", "December" };

            // 1. Separate the given dates to year, month and date, then convert them to int
            DateTime localDate = DateTime.Now;
            string thisYear = localDate.Year.ToString();

            string[] beginningDate = givenDates[0].Split("-");
            string[] endDate = givenDates[1].Split("-");

            // 2. If the beginning date's year is the curren year, convert the beginning date without displaying the year

            // beginning year
            if (beginningDate[0] != thisYear)
            {
                friendlyYearOfBeginning = ", " + beginningDate[0];
            }

            // beginning month
            //int month = Int32.Parse(beginningDate[1].TrimStart(new Char[] { '0' })) ;
            int month = int.Parse(beginningDate[1]);
            Console.WriteLine(month);
            //for (int i = 0; i < months.Length; i++)
            //{
            //    if (month == i+1)
            //    {
            //        friendlyMonthOfBeginning = months[i];
            //    }
            //}

            friendlyMonthOfBeginning = months[month-1];

            //switch (beginningDate[1])
            //{
            //    case "01":
            //        friendlyMonthOfBeginning = "January";
            //        break;
            //    case "02":
            //        friendlyMonthOfBeginning = "Feburay";
            //        break;
            //    case "03":
            //        friendlyMonthOfBeginning = "March";
            //        break;
            //    case "04":
            //        friendlyMonthOfBeginning = "Apirl";
            //        break;
            //    case "05":
            //        friendlyMonthOfBeginning = "May";
            //        break;
            //    case "06":
            //        friendlyMonthOfBeginning = "June";
            //        break;
            //    case "07":
            //        friendlyMonthOfBeginning = "July";
            //        break;
            //    case "08":
            //        friendlyMonthOfBeginning = "August";
            //        break;
            //    case "09":
            //        friendlyMonthOfBeginning = "September";
            //        break;
            //    case "10":
            //        friendlyMonthOfBeginning = "October";
            //        break;
            //    case "11":
            //        friendlyMonthOfBeginning = "November";
            //        break;
            //    case "12":
            //        friendlyMonthOfBeginning = "December";
            //        break;
            //    default:
            //        break;
            //}
            friendlyMonthOfBeginning = friendlyMonthOfBeginning + " ";

            // beginning day
            int num = int.Parse(beginningDate[2]);
            Console.WriteLine(num);

            switch (num)
            {
                case 1:
                case 21:
                case 31:
                    friendlyDayOfBeginning = num.ToString() + "st";
                    break;
                case 2:
                case 22:
                    friendlyDayOfBeginning = num.ToString() + "nd";
                    break;
                case 3:
                case 23:
                    friendlyDayOfBeginning = num.ToString() + "rd";
                    break;
                default:
                    friendlyDayOfBeginning = num.ToString() + "th";
                    break;
            }

            beginningFriendlyDate = friendlyMonthOfBeginning + friendlyDayOfBeginning + friendlyYearOfBeginning;

            // 3. If the end year is same as beginning year, convert the end date without displaying the year; month following
            //    otherwise, convert them all
            if (endDate[0] != beginningDate[0])
            {
                friendlyYearOfEnd = ", " + endDate[0];
            }
            if (endDate[1] != beginningDate[1])
            { 
                switch (endDate[1])
                {
                    case "01":
                        friendlyMonthOfEnd = "January";
                        break;
                    case "02":
                        friendlyMonthOfEnd = "Feburay";
                        break;
                    case "03":
                        friendlyMonthOfEnd = "March";
                        break;
                    case "04":
                        friendlyMonthOfEnd = "Apirl";
                        break;
                    case "05":
                        friendlyMonthOfEnd = "May";
                        break;
                    case "06":
                        friendlyMonthOfEnd = "June";
                        break;
                    case "07":
                        friendlyMonthOfEnd = "July";
                        break;
                    case "08":
                        friendlyMonthOfEnd = "August";
                        break;
                    case "09":
                        friendlyMonthOfEnd = "September";
                        break;
                    case "10":
                        friendlyMonthOfEnd = "October";
                        break;
                    case "11":
                        friendlyMonthOfEnd = "November";
                        break;
                    case "12":
                        friendlyMonthOfEnd = "December";
                        break;
                    default:
                        break;
                }
                friendlyMonthOfEnd = friendlyMonthOfEnd + " ";
            }

            // end day
            int num2 = Int32.Parse(endDate[2].TrimStart(new Char[] { '0' }));
            Console.WriteLine(num2);
            switch (num2)
            {
                case 1:
                case 21:
                case 31:
                    friendlyDayOfEnd = num.ToString() + "st";
                    break;
                case 2:
                case 22:
                    friendlyDayOfEnd = num.ToString() + "nd";
                    break;
                case 3:
                case 23:
                    friendlyDayOfEnd = num.ToString() + "rd";
                    break;
                default:
                    friendlyDayOfEnd = num.ToString() + "th";
                    break;
            }

            endFrindlyDate = friendlyMonthOfEnd + friendlyDayOfEnd + friendlyYearOfEnd;

            friendlyDates[0] = beginningFriendlyDate;
            friendlyDates[1] = endFrindlyDate;

            Console.WriteLine("The friendly date is ['{0}', '{1}']", friendlyDates[0], friendlyDates[1]);
            return friendlyDates;

        }
    }
}
