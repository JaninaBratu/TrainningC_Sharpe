using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningNet.Lessons.Lesson_12;
using TrainningNet.Lessons.Lesson_13;
using TrainningNet.Lessons.Lesson_14;
using TrainningNet.Lessons.Lesson_16;

namespace TrainningNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Example with ConsoleWriteline ");

            //int x = 3;
            //int y = 5;
            //int result = x + y;
            //Console.WriteLine("First example: " + "The result is: "+ result);
            //Console.WriteLine("Second example: " + $"The result is: { result}" + '\n');

            //DateTime currentDate = DateTime.Now;
            //DateTime newDate = currentDate.AddDays(2);

            //Console.WriteLine("First example: " + "The new date is: " + newDate);
            //Console.WriteLine("Second example: " +  $"The new date is: {newDate}" + '\n');



            // Console.WriteLine("Example with string IMMUTABLE");

            //STRINGS are IMMUTABLE

            //string empty1 = "";
            //string empty2 = String.Empty;

            //Console.WriteLine("The lenght of the empty1 string is: " + empty1.Length);
            //Console.WriteLine("The lenght of the empty2 string is: " + empty2.Length);


            // Console.WriteLine("Example with the DIFERENCE BEWTEEN NULL AND EMPTY");

            //DIFERENCE BEWTEEN NULL AND EMPTY

            //string emptyString = String.Empty;
            //string nullString = null;

            //Console.WriteLine(emptyString); // prints nothing
            //Console.WriteLine(nullString); // prints nothing

            //// this line will print 0
            //Console.WriteLine($"1st string is {emptyString.Length} characters long.");

            //// this line will throw an exception (uncomment it to confirm)
            // Console.WriteLine($"2nd string is {nullString.Length} characters long.");


            // Console.WriteLine("Example with Replacing Parts of Strings");

            // Replacing Parts of Strings

            //string name = "Steve";
            //string greet1 = $"Hello {name}!"; // Hello Steve!
            //string greet2 = "Hello " + name + "!"; // Hello Steve!
            //string greet3 = String.Format("Hello {0}!", name); // Hello Steve!     -- ce a format aici???? 
            //string greetTemplate = "Hello **NAME**!";
            //string greet4 = greetTemplate.Replace("**NAME**", name); // Hello Steve!

            //Console.WriteLine(name);
            //Console.WriteLine(greet1);
            //Console.WriteLine(greet2);
            //Console.WriteLine(greet3);
            //Console.WriteLine(greetTemplate);
            //Console.WriteLine(greet4);

            // Console.WriteLine("EXERCISE with string !!!!");

            /*
             * 
             * Now it's your turn. Create some code that will take two string variables and build a greeting from them. 
             * One variable should be the greeting and another variable should be the name to be greeted.
             *  Make sure your greeting includes punctuation at the end, after the position where the name will be inserted!
             * For a little extra credit, support an optional third variable than can be set to either 'loud' or 'quiet'. 
             * When loud, change whatever the greeting is to all UPPERCASE. 
             * If quiet, change it to all lowercase. 
             * If the third variable is null or empty, the greeting should remain unchanged.
             * 
             * 
             * */

            // Console.WriteLine("Solution STRING");

            //string greetingMessage = "Hello Janina!";
            //var greetingAppereance = "";
            //while ((greetingAppereance = Console.ReadLine()) != null)
            //{
            //    StringAction.GreetAppereance(Int32.Parse(greetingAppereance), greetingMessage);
            //}


            // Console.WriteLine("Example with DateTime ");

            // Example of datetime format : 7/1/2016 11:10:09 AM
            /*
             * year: 2016
             * month: 7
             * day: 1
             */
            /*
             * calculate how many days are left in the year. To do so, you would need to determine the first day of the next year, and then compare that to today
             */
            //DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            //Console.WriteLine("Value for next year: " + nextYear);

            //TimeSpan duration = nextYear - DateTime.Today;
            //Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            //which is used to represent a span of time, or a duration


            //Console.WriteLine("EXERCISE with DateTime !!!!");

            /*
            *
            * Write a simple program that defines a variable representing a birth date and calculates
            * how many days old the person with that birth date is currently.
            * For extra credit, output the date of their next 10,000 day (about 27 years) anniversary. 
            * Note: once you figure out their age in days, 
            * you can calculate the days until the next anniversary using int daysToNextAnniversary = 10000 - (days % 10000);
            * 
            * 
            */

            //Console.WriteLine("Solution DATETIME");

            //string date = "9 / 1 / 1992 07:05:00 AM"; //"7 / 1 / 2010 11:10:09 AM";
            //DateTime dateToSend = Convert.ToDateTime(date);
            //DateTimeAction.CalculateAge(dateToSend);
            //8757 days Janina ("9 / 1 / 1992 07:05:00 AM";)
            //10212 days Andrei ("9 / 7 / 1988 07:05:00 AM";)
            //DateTimeAction.CalculateNextBirthday(dateToSend);


            //Console.WriteLine("EXERCISE with switch or/and if/or else if statements");

            /*
            * 
            * Your program can create a random number between 1 and 3 with the following code:
                   int correctNumber = new Random().Next(4);
              Write a program that generates a random number between 1 and 3 and asks the user to guess what the number is. 
              Tell the user if they guess low, high, or get the correct answer.
              Also, tell the user if their answer is outside of the range of numbers that are valid guesses 
              (less than 1 or more than 3).
              You can convert the user's typed answer from a string to an int using this code:
                   int guessedNumber = int.Parse(Console.ReadLine());
              Note that the above code will crash the program if the user doesn't type an integer value. 
              For this exercise, assume the user will only enter valid guesses.
            * 
            */
            //int randomNr = DecisionAction.GenerateRandomNumber();
            //int maxRangeNr = 4;
            //DecisionAction.GuessAnswer(maxRangeNr, randomNr);


            //Console.WriteLine("EXERCISE with LOGICAL EXPRESSIONS");
            /*
             * Write a program that greets the user using the appropriate greeting for the time of day. 
             * Use only if, not else or switch, statements to do so. Be sure to include the following greetings:
             "Good Morning"
             "Good Afternoon"
             "Good Evening"
             "Good Night"
             It's up to you which times should serve as the starting and ending ranges for each of the greetings. 
             If you need a refresher on how to get the current time, see Working with Dates and Times.
             When testing your program, you'll probably want to use a DateTime variable you define,
             rather than the current time. 
             Once you're confident the program works correctly, you can substitute DateTime.Now for your variable
             (or keep your variable and just assign DateTime.Now as its value, which is often a better approach).
             * 
             */
            //string date = "01/08/2008 16:00"; 
            // DateTime dateToSend = Convert.ToDateTime(date);
            // OperatorAction.GreetByPeriodDay(dateToSend);

            //Console.WriteLine("EXERCISE with LOOPS");
            /*
             * The following program uses an if statement to determine whether a given number is divisible by 2. 
             * Modify the program to change the two outer if statements into while loops 
             * so that the program lists all of the factors of the number the user supplies. 
             * You will need to ensure you update the values of both the number and factor variables within the loop(s) to avoid an infinite loop condition.
                *Note that the % operator used below is the modulus operator. 
                * It returns the remainder of an integer division operation. 
             */
            //LoopingAction.IfDivisible(2);
            //http://www.softschools.com/math/topics/divisibility_rules_2_4_8_5_10/


            //Console.WriteLine("EXERCISE with NESTED LOOPS");
            /*
             * 
             * Write a program that prints the result of counting up to 24 using four different increments. 
             * First, count by 1s, then by 2s, by 3s, and finally by 4s.
             * Use nested for loops with your outer loop counting from 1 to 4. 
             * You inner loop should count from 0 to 24,
             *  but increase the value of its loop control variable by the value of the loop control variable 
             *  from the outer loop. This means the incrementing in the afterthought expression will be based on a variable.
             */
            //NestedLoopingAction.DisplayNumbersUpTo24();


            //Console.WriteLine("EXERCISE with Arrays and Collections");

            /*
             * 
             * Write a simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc. 
             * Refer to Looping Based on a Logical Expression if necessary to see how to implement an infinite loop. 
             * Each time through the loop, ask the user to perform an operation, 
             * and then show the current contents of their list. 
             * The operations available should be Add, Remove, and Clear. The syntax should be as follows:
                + some item
                - some item
                --
             * Your program should read in the user's input and determine if it begins with a "+" or "-", or if it is simply "--". In the first two cases, your program should add or remove the string given ("some item" in the example). If the user enters just "--" then the program should clear the current list. Your program can start each iteration through its loop with the following instruction: Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
             * 
             */
            //ArrayListAction.GetGroceryList();


            //Console.WriteLine("EXERCISE with ForEachLoop")
            /*
             * Write a program that initializes a list integer numbers, and then prints the numbers out along with their sum. 
             * Sample output:
             * Numbers: 2 4 6
             * Sum: 12
             */
            //ForEachLoopAction.DisplaySumOfElem();


            //Console.WriteLine("EXERCISE with classes and objects - Lesson 12")
            //Address adress = CollectionsAction.CreateAdress("Voinicului nr 35", "Craiova", "Dolj", "200342", "Romania");
            //Address adress2 = CollectionsAction.CreateAdress("Aleea Teatrului, Bloc T1, Scara 3, App 11", "Craiova", 
            //                                                "Dolj", "123456", "Romania");

            //Person p = CollectionsAction.CreatePerson("Bratu", "Janina", adress);
            //Person p2 = CollectionsAction.CreatePerson("Coman", "Andrei", adress2);

            //List<Person> listOfPersons = new List<Person>();
            //listOfPersons.Add(p);
            //listOfPersons.Add(p2);


            //foreach (Person person in listOfPersons)
            //{
            //    Console.WriteLine(person.FirstName + " ");
            //    Console.WriteLine(person.LastName + "\n");
            //    Console.WriteLine(person.ShippingAddress.City + "," + " ");
            //    Console.WriteLine(person.ShippingAddress.StreetAddress + " " + "\n");
            //    Console.WriteLine(person.ShippingAddress.Country + " ");
            //    Console.WriteLine(person.ShippingAddress.PostalCode + "\n");
            //    Console.WriteLine("-----------" + "\n");
            //}


            //Console.WriteLine("EXERCISE Lesson 13");
            //Course course = new Course("Math");
            //Console.WriteLine("The name of the course is: " + course.courseName);
            //Console.WriteLine("The number of enroled student is: " + course.studentList.Count);

            //Console.WriteLine("The name of the students are: ");
            //foreach (var s in course.studentList)
            //{
            //    Console.WriteLine(s.RosterName);        
            //}

            //Console.WriteLine("EXERCISE Lesson 14")
            //string newOrder = "1234"; - this is for dinamic input, the verification should be here
            //if(newOrder != "")
            //Order order = new Order("1234");
            //OrderAction.AddOrdersToList(order);
            //Order order2 = new Order("1239");
            //OrderAction.AddOrdersToList(order2);

            //Customer customer = new Customer("Billy");
            //OrderAction.DisplayHistoryOfOrders(customer, new List<Order>() { order, order2});

            //Console.WriteLine("EXERCISE Lesson 16")
            PersonAction.GetPersonsByAge();
        }
    }
}
