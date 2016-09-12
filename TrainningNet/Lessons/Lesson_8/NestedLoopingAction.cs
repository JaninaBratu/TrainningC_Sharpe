using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class NestedLoopingAction
    {
        //Output : 
        //0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
        //0,2,4,6,8,10,12,14,16,18,20,22,24
        //0,3,6,9,12,15,18,21,24
        //0,4,8,12,16,20,24

        public static void DisplayNumbersUpTo24()
        {
            for (int i = 1; i <= 4; i++) 
            {
              Console.Write("\n");
              for (int j = 0; j <= 24; j++)
              {
                 var show = i * j;
                 if (show > 24)
                 {
                    break;
                 }
                    Console.Write(show + ", ");
                }
            }
            Console.Read();
        }
    }
}
