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

        public List<Student> studentList { get; set; } = new List<Student>();

        public Course(string name)
        {
            this.SetNameOfCourse(name);
            this.SetListOfEnroledStudents();
        }

        public void SetNameOfCourse(string name)
        {
            courseName = name;
        }

        public List<Student> SetListOfEnroledStudents()
        {
            string birthDateStudent1 = "11/30/2015 12:00:00 AM";
            DateTime birthOfDateStudent1 = Convert.ToDateTime(birthDateStudent1);

            Student student1 = new Student("John", "Smith", birthOfDateStudent1);
            student1.SchoolName = "School nr 18";

            string birthDateStudent2 = "01/12/2015 09:00:00 AM";
            DateTime birthOfDateStudent2 = Convert.ToDateTime(birthDateStudent2);

            Student student2 = new Student("Emy", "Lee", birthOfDateStudent2);
            student2.SchoolName = "School nr 27";

            studentList.Add(student1);
            studentList.Add(student2);

            return studentList;
        }
    }
}
