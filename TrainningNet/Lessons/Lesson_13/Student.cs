using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_13
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth)
            : base(firstName, lastName, dateOfBirth)
        { }
        public string SchoolName { get; set; }

        public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
    }
}
