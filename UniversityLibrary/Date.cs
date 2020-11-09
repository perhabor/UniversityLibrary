using System;
namespace UniversityLibrary
{
    public class Date
    {
        private int day;
        private int month;
        public int Year{get; set;}

        public Date( int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Day = theDay;
            Year = theYear;
            Console.WriteLine($"Day Constructor Called: {this}");
        }

        public int Month
        {
            get{return month;}
            private set
            {
                if((value > 0) && (value <= 12))
                {
                    month = value;
                }else {
                    throw new System.ArgumentOutOfRangeException("Day value is out of range");
                }

            }
        }

        public int Day
        {
            get{return day;}
            set 
            {
                int[] DaysPerMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
                if((value > 0) && (value <= DaysPerMonth[Month - 1]))
                {
                    day = value;
                }else if( (Month == 2 && value == 29) && (Year %  4 == 0 || Year % 400 == 0) && (Year % 100 != 0))
                {
                    day = value;
                }else{
                    throw new System.ArgumentOutOfRangeException("Day value out of range!");
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}