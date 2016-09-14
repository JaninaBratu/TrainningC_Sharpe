using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_14
{
    public class Order
    {
        public Order(string orderNumber)
        {
            OrderNumber = orderNumber;
        }
        public string OrderNumber { get; }

        public DateTime OrderDate { get; set; }
    }
}
