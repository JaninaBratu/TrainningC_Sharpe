using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class OperatorAction
    {
        

        public static string GetPeriodOfDay(DateTime actualTime)
        {
            return null;
        }

        /*
         * "Good Morning"
         * "Good Afternoon"
         * "Good Evening"
         * "Good Night"
         * 
         */


        public static StringBuilder SetMorningPeriod()
        {
            string startHour = "03";
            string endHour = "11";
            string startMinute = "00";
            string endMinute = "59";
            string points = ":";
            string space = " ";
            string anteMeridiem = "AM";

            StringBuilder morningPeriodBuilder = new StringBuilder();
            morningPeriodBuilder.Append(startHour).Append(points).Append(endHour).Append(points)
                         .Append(startMinute).Append(points).Append(endMinute).Append(space).Append(anteMeridiem);

            return morningPeriodBuilder;
        }

        public static StringBuilder SetAfternoonPeriod()
        {
            string startHour = "12";
            string endHour = "13";
            string startMinute = "00";
            string endMinute = "59";
            string points = ":";
            string space = " ";
            string anteMeridiem = "AM";

            StringBuilder periodBuilder = new StringBuilder();
            periodBuilder.Append(startHour).Append(points).Append(endHour).Append(points)
                         .Append(startMinute).Append(points).Append(endMinute).Append(space).Append(anteMeridiem);

            return periodBuilder;
        }

        public static StringBuilder SetEveningPeriod()
        {
            string startHour = "14";
            string endHour = "17";
            string startMinute = "00";
            string endMinute = "59";
            string points = ":";
            string space = " ";
            string postMeridiem = "PM";

            StringBuilder periodBuilder = new StringBuilder();
            periodBuilder.Append(startHour).Append(points).Append(endHour).Append(points)
                         .Append(startMinute).Append(points).Append(endMinute).Append(space).Append(postMeridiem);

            return periodBuilder;
        }

        public static StringBuilder SetNightPeriod()
        {
            string startHour = "18";
            string endHour = "02";
            string startMinute = "00";
            string endMinute = "59";
            string points = ":";
            string space = " ";
            string postMeridiem = "PM";

            StringBuilder periodBuilder = new StringBuilder();
            periodBuilder.Append(startHour).Append(points).Append(endHour).Append(points)
                         .Append(startMinute).Append(points).Append(endMinute).Append(space).Append(postMeridiem);

            return periodBuilder;
        }
    }
}
