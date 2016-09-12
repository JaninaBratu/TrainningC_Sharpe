using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class DecisionAction
    {
        public static int GenerateRandomNumber(int maxRangeNr = 4)
        {
            Random r = new Random();
            return r.Next(maxRangeNr);
        }

        public static void GuessAnswer(int maxRangeNr, int randomNr)
        {
            int minRangeNr = 0;
            var userInput = "";
            while ( (userInput = Console.ReadLine()) != null)
            {
                bool success = IsNumber(userInput);
                if (success)
                {
                    int input = Int32.Parse(userInput);

                    if (input == randomNr)
                    {
                        Console.WriteLine("Congrats!!! You have quessed!");
                    }
                    else if (input > maxRangeNr)
                    {
                        Console.WriteLine("The input number is bigger than the maximum number range! Your input must be between : " + minRangeNr + " and " + maxRangeNr);
                    }
                    else if (input < minRangeNr)
                    {
                        Console.WriteLine("The input number is smallest than the minimum number range! Your input must be between: " + minRangeNr + " and " + maxRangeNr);
                    }
                    else if (input < randomNr)
                    {
                        Console.WriteLine("The input number is smaller than the one generated!");
                    }
                    else if (input > randomNr)
                    {
                        Console.WriteLine("The input number is greater than the one generated!");
                    }
                }
                else
                {
                    Console.WriteLine("The user input is not valid. It must be a number");
                }
            }
        }

        public static bool IsNumber(string inputNumber)
        {
            int i;
            bool success = int.TryParse(inputNumber, out i);
            return success;
        }
    }
}
