using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class OperatorAction
    {


        

        public static void GreetByPeriodDay(DateTime actualTime)
        {

            var userInput = Console.ReadLine();

            while ((userInput != null))
            {
                //if (morningMinTime < Convert.ToInt32(actualTime) < Convert.ToInt32(morningMaxTime) )
                //{

                //}
            }
        }

        public List<DateTime> GetListOfPeriodsDay()
        {
            List<DateTime> listOfDates = new List<DateTime>();

            //"Good Morning"
            DateTime morningMinTime = new DateTime();
            DateTime morningMaxTime = new DateTime();

            TimeSpan startMorningTimeStamps = new TimeSpan(03, 00, 0);
            morningMinTime = morningMinTime.Date + startMorningTimeStamps;

            TimeSpan endMorningTimeStamps = new TimeSpan(11, 00, 0);
            morningMaxTime = morningMaxTime + endMorningTimeStamps;

            //"Good Afternoon"
            DateTime afternoonMinTime = new DateTime();
            DateTime afternoonMaxTime = new DateTime();

            TimeSpan startAfternoonTimeStamps = new TimeSpan(12, 00, 0);
            afternoonMinTime = afternoonMinTime.Date + startAfternoonTimeStamps;

            TimeSpan endAfternoonTimeStamps = new TimeSpan(13, 00, 0);
            afternoonMaxTime = afternoonMaxTime + endAfternoonTimeStamps;

            //"Good Evening"
            DateTime eveningMinTime = new DateTime();
            DateTime eveningMaxTime = new DateTime();

            TimeSpan startEveningTimeStamps = new TimeSpan(14, 00, 1);
            eveningMinTime = eveningMinTime.Date + startEveningTimeStamps;

            TimeSpan endEveningTimeStamps = new TimeSpan(17, 00, 1);
            eveningMaxTime = eveningMaxTime + endEveningTimeStamps;

            //"Good Night"
            DateTime nightMinTime = new DateTime();
            DateTime nightMaxTime = new DateTime();

            TimeSpan startNightTimeStamps = new TimeSpan(18, 00, 1);
            nightMinTime = nightMinTime.Date + startNightTimeStamps;

            TimeSpan endNightTimeStamps = new TimeSpan(02, 00, 1);
            nightMaxTime = nightMaxTime + endNightTimeStamps;

            listOfDates.Add(morningMinTime);
            listOfDates.Add(morningMaxTime);

            listOfDates.Add(afternoonMinTime);
            listOfDates.Add(afternoonMaxTime);

            listOfDates.Add(eveningMinTime);
            listOfDates.Add(eveningMaxTime);

            listOfDates.Add(nightMinTime);
            listOfDates.Add(nightMaxTime);

            return listOfDates;
        }


    }
}
