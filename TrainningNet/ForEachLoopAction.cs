using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class ForEachLoopAction
    {

        public static void DisplaySumOfElem()
        {
            List<int> listOfElem = new List<int>() { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10};
            int sumOfElem = 0;
            foreach (var item in listOfElem)
            {
                sumOfElem += item;
            }
            Console.WriteLine("The total sum of elem in the list is: " +sumOfElem);
        }
    }
}
