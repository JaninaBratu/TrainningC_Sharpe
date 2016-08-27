using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class LoopingAction
    {

        public static void IfDivisible(int divisibleBy)
        {
            int newNumberToCheck = 0;
            int count = 0;

            var numberToCheck = Console.ReadLine();
            int nrToCheck = Int32.Parse(numberToCheck);

            while (numberToCheck != null)
            {
                 while (divisibleBy <= nrToCheck)
                 {
                    count++;

                    newNumberToCheck = nrToCheck / divisibleBy;
                    nrToCheck = newNumberToCheck;
                    
                    if (nrToCheck % divisibleBy == 0)
                    {
                        if (count == 1)
                        {
                            Console.WriteLine("The number IS divisible with 2 !");
                        }
                        else
                        {
                            Console.WriteLine("The number :" + nrToCheck);
                            Console.WriteLine("The number IS divisible with 2 !");
                        }
                    }
                    else
                    {
                        if (count == 1)
                        {
                            Console.WriteLine("The number IS NOT divisible with 2 !");
                        }
                        else
                        {
                            Console.WriteLine("The number :" + nrToCheck);
                            Console.WriteLine("The number IS NOT divisible with 2 !");
                        }
                        
                    }
                }

            }
            
           
        }
    }
}
