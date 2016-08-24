using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class PeriodOfDay
    {
        public string startHour { get; set; }
        public string endHour { get; set; }
        public string startMinute { get; set; }
        public string endMinute { get; set; }
        public string points { get; set; }
        public string space { get; set; }
        public string anteMeridiem { get; set; }
        public string postMeridiem { get; set; }

        public PeriodOfDay(string startHour, string endHour, string startMinute, string endMinute,
                           string points, string space, string anteMeridiem, string postMeridiem)
        {
            startHour = startHour;
            endHour = endHour;
            startMinute = startMinute;
            endMinute = endMinute;
            points = points;
            space = space;
            anteMeridiem = anteMeridiem;
            postMeridiem = postMeridiem;
        }
    }
}