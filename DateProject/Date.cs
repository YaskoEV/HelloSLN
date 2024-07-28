using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    public class Date
    {
        public int year { get; set; }
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.chekMonth = month;
            this.chekDay = day;
        }

        public int chekMonth
        {
            get { return this.month; }
            set
            {
                if (value > 0 && value < 13)
                    month = value;
                else
                    throw new ArgumentException($"Месяц указан не верно = {value}");
            }
        }

        public int chekDay
        {
            get { return this.day; }
            set 
            {
                if (((value > 0 & value < 32) & (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                  || ((value > 0 & value < 31) & (month == 4 || month == 6 || month == 9 || month == 11)) 
                  || ((value > 0 & value < 30) & (month == 2) & (year%4 == 0))
                  || ((value > 0 & value < 29) & (month == 2))) 
                    day = value;
                else
                    throw new ArgumentException($"День указан не верно = {value}");
            }
        }

        public void PrintInfo()
        {
            string monthStr, dayStr;
            if (month < 10) monthStr = "0" + month.ToString();
            else monthStr = month.ToString();

            if (day < 10) dayStr = "0" + day.ToString();
            else dayStr = day.ToString();
            Console.WriteLine("Дата = {0}-{1}-{2}", year, monthStr, dayStr);
        }
    }
}
