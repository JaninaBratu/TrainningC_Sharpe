using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            * /*
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

            * /*
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
        }
    }
}
