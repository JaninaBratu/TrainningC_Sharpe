using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_14
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public List<Order> Orders { get; } = new List<Order>();
        
    }
}
