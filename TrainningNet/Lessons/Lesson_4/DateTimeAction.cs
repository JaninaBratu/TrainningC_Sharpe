using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class DateTimeAction
    {
        public static void CalculateAge(DateTime birthDate)
        {
            TimeSpan daysOld = new TimeSpan();
            
            if (birthDate != DateTime.Now)
            {
                daysOld = DateTime.Now - birthDate;
                Console.WriteLine("Days old : " + daysOld.Days);
            }
        }

        public static void CalculateNextBirthday(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime next = birthDate.AddYears(today.Year - birthDate.Year);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;

            Console.WriteLine("The number of days untill next birthday is: " + numDays); //including the current date
        }
    }
}
