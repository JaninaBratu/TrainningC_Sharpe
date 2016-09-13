using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainningNet.Lessons.Lesson_13
{
    public class Course
    {
        
        public string courseName { get; set; }

        public List<Student> listOfStudents { get; set; }

        private void GetNameOfCourse(string name)
        {
            courseName = name;
        }

        private void GetListOfEnroledStudents()
        {
            string birthDateStudent1 = "11/30/2015 12:00:00 AM";
            DateTime birthOfDateStudent1 = Convert.ToDateTime(birthDateStudent1);

            Student student1 = new Student("John", "Smith", birthOfDateStudent1);

            string birthDateStudent2 = "01/12/2015 09:00:00 AM";
            DateTime birthOfDateStudent2 = Convert.ToDateTime(birthDateStudent2);

            Student student2 = new Student("Emy", "Lee", birthOfDateStudent2);

            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
        }
    }
}
