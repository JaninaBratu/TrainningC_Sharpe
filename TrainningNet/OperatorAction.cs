using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class OperatorAction
    {

        public static readonly int morningMinHour = 03;
        public static readonly int morningMaxHour = 11;
        public static readonly int afternoonMinHour = 12;
        public static readonly int afternoonMaxHour = 01;
        public static readonly int eveningMinHour = 02;
        public static readonly int eveningMaxHour = 05;
        public static readonly int nightMinHour = 06;
        public static readonly int nightMaxHour = 02;

        public static readonly string anteMeridian = "AM";
        public static readonly string postMeridian = "PM";

        public static void GreetByPeriodDay(DateTime dateToSend, string meridianTime)
        {
            var value = dateToSend.Hour;

            string dateTimeStringValue = dateToSend.Hour.ToString(); //dateToSend.ToString("HH:mm:ss");

            int actualTimeIntValue = GetHourOfDay(dateTimeStringValue);

            if (actualTimeIntValue >= morningMinHour  && actualTimeIntValue <= morningMaxHour && meridianTime.Equals(anteMeridian))
            {
                Console.WriteLine("Good morning!");
            }
            if (actualTimeIntValue >= afternoonMinHour && actualTimeIntValue > afternoonMaxHour && meridianTime.Equals(anteMeridian))
            {
                Console.WriteLine("Good afternoon!");
            }
            if(actualTimeIntValue >= eveningMinHour && actualTimeIntValue <= eveningMaxHour && meridianTime.Equals(anteMeridian))
            {
                Console.WriteLine("Good evening!");
            }
            if(actualTimeIntValue >= nightMinHour && actualTimeIntValue > nightMaxHour && meridianTime.Equals(postMeridian))
            {
                Console.WriteLine("Good night!");
            }
        }

        public static int GetHourOfDay(string dateToSend)
        {
            int valueToReturn = 0;
            string[] arrayOfData = dateToSend.Split(':');
            StringBuilder builderOfData = new StringBuilder();

            if (arrayOfData.Length > 0)
            {
               valueToReturn = Int32.Parse(builderOfData.Append(arrayOfData[0]).ToString());

            }

            return valueToReturn;
        }

    }
}
