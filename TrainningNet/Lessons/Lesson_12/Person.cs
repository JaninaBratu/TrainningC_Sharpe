using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_12
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress
        {
            get; set;
        }
    }
}
