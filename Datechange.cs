using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class  Datechange
    {
        public static DateTime ToGeorgianDateTime(this string persianDate)
        {
            int day = Convert.ToInt32(persianDate.Substring(0, 2));
            int month = Convert.ToInt32(persianDate.Substring(3, 2));
            int year = Convert.ToInt32(persianDate.Substring(6, 4));
            DateTime georgianDateTime = new DateTime(year, month, day, new System.Globalization.PersianCalendar());
            return georgianDateTime;
        }



        public static string ToPersianDateTime(this DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }




        public static string DayIdToName(this int dayofweekid)
        {
            string[] DaysName= new string[7]{"یک شنبه","دوشنبه","سه شنبه","چهارشنبه","پنج شنبه","جمعه","شنبه"};
            return DaysName[dayofweekid];
        }




    }
}
