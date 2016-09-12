using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class OperatorAction
    {

        public static readonly DateTime morningMinHour = DateTime.Parse("2012/12/12 03:00");
        public static readonly DateTime morningMaxHour = DateTime.Parse("2012/12/12 11:00"); 
        public static readonly DateTime afternoonMinHour = DateTime.Parse("2012/12/12 12:00");
        public static readonly DateTime afternoonMaxHour = DateTime.Parse("2012/12/12 13:00");
        public static readonly DateTime eveningMinHour = DateTime.Parse("2012/12/12 14:00");
        public static readonly DateTime eveningMaxHour = DateTime.Parse("2012/12/12 17:00");
        public static readonly DateTime nightMinHour = DateTime.Parse("2012/12/12 18:00");
        public static readonly DateTime nightMaxHour = DateTime.Parse("2012/12/12 02:00");


        public static void GreetByPeriodDay(DateTime dateToSend)
        {
            if (morningMinHour.TimeOfDay <= dateToSend.TimeOfDay && dateToSend.TimeOfDay <= morningMaxHour.TimeOfDay)
            {
                Console.WriteLine("Good morning!");
            }
            if (afternoonMinHour.TimeOfDay <= dateToSend.TimeOfDay && dateToSend.TimeOfDay <= afternoonMaxHour.TimeOfDay)
            {
                Console.WriteLine("Good afternoon!");
            }
            if (eveningMinHour.TimeOfDay <= dateToSend.TimeOfDay && dateToSend.TimeOfDay <= eveningMaxHour.TimeOfDay)
            {
                Console.WriteLine("Good evening!");
            }
            if (nightMinHour.TimeOfDay <= dateToSend.TimeOfDay && dateToSend.TimeOfDay <= nightMaxHour.TimeOfDay)
            {
                Console.WriteLine("Good night!");
            }
            Console.ReadLine();
        }
    }
}
