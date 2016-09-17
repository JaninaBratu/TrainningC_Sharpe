using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_16
{
    public class PersonAction
    {
        /*
         * How  to find how much ocurences is in a list based on a condition
         * int nrOfOccurence = ((from x in nameOfPersons where x.Equals(result) select x).Count());
         * 
         * http://www.codeproject.com/Tips/69400/Count-number-of-occurences-of-a-value-in-a-List-us
         * */

        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return people;
        }

        public static void GetPersonsByAge()
        {
            List<Person> listOfPersons = GenerateListOfPeople();

            string userInput = GetUserInput();

            var result = listOfPersons.Where(p => p.Age > Int32.Parse(userInput)).ToList();
                if (result != null)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("The persons that are older than " + userInput + " years are: ");
                    foreach (var y in result)
                    {
                        Console.WriteLine(y.FirstName + " " + y.LastName);  
                    }
                }
        }

        public static void GetPersonsByName()
        {
            List<Person> listOfPersons = GenerateListOfPeople();

            string userInput = GetUserInput();

            var result = listOfPersons.Where(p => p.FirstName.Equals(userInput)).ToList();
                if (result != null)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("The persons that are older than " + userInput + " years are: ");
                    foreach (var y in result)
                    {
                        Console.WriteLine(y.FirstName + " " + y.LastName);  
                    }
                }
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Please introduce the age you want to filter by: ");
            return Console.ReadLine().ToString();
        }
    }
}
