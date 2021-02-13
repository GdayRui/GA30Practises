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
            MakeFriendlyDates(new string[] { "2016-07-31", "2016-09-21" });
            MakeFriendlyDates(new string[] { "2016-07-01", "2016-07-31" });
            MakeFriendlyDates(new string[] { "2016-07-31", "2021-02-12" });
            MakeFriendlyDates(new string[] { "2021-02-12", "2021-02-13" });
        }

        static string[] MakeFriendlyDates(string[] givenDates)
        {
            string[] friendlyDates = new string[2];

            //string beginningFriendlyDate = "";
            //string endFrindlyDate = "";

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
            int month = int.Parse(beginningDate[1]);
            friendlyMonthOfBeginning = months[month-1] + " ";

            // beginning day
            int day = int.Parse(beginningDate[2]);
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    friendlyDayOfBeginning = day.ToString() + "st";
                    break;
                case 2:
                case 22:
                    friendlyDayOfBeginning = day.ToString() + "nd";
                    break;
                case 3:
                case 23:
                    friendlyDayOfBeginning = day.ToString() + "rd";
                    break;
                default:
                    friendlyDayOfBeginning = day.ToString() + "th";
                    break;
            }

            string beginningFriendlyDate = friendlyMonthOfBeginning + friendlyDayOfBeginning + friendlyYearOfBeginning;

            // 3. If the end year is same as beginning year, convert the end date without displaying the year; month following
            //    otherwise, convert them all
            if (endDate[0] != beginningDate[0])
            {
                friendlyYearOfEnd = ", " + endDate[0];
            }
            // end month
            int monthOfEnd = int.Parse(endDate[1]);
            if (endDate[1] != beginningDate[1])
                friendlyMonthOfEnd = months[monthOfEnd - 1] + " ";

            // end day
            int dayOfEnd = int.Parse(endDate[2]);
            switch (dayOfEnd)
            {
                case 1:
                case 21:
                case 31:
                    friendlyDayOfEnd = dayOfEnd.ToString() + "st";
                    break;
                case 2:
                case 22:
                    friendlyDayOfEnd = dayOfEnd.ToString() + "nd";
                    break;
                case 3:
                case 23:
                    friendlyDayOfEnd = dayOfEnd.ToString() + "rd";
                    break;
                default:
                    friendlyDayOfEnd = dayOfEnd.ToString() + "th";
                    break;
            }

            string endFrindlyDate = friendlyMonthOfEnd + friendlyDayOfEnd + friendlyYearOfEnd;

            friendlyDates[0] = beginningFriendlyDate;
            friendlyDates[1] = endFrindlyDate;

            Console.WriteLine("The friendly date is ['{0}', '{1}']", friendlyDates[0], friendlyDates[1]);
            return friendlyDates;

        }
    }
}
