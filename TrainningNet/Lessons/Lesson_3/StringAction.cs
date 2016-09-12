using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet
{
    public class StringAction
    {

        public static void GreetAppereance(int greetingAppereance, string greetingMessage)
        {
            if (greetingAppereance == 1)
            {
                Console.WriteLine(greetingMessage.ToUpper());
            }
            else if (greetingAppereance == 2)
            {
                Console.WriteLine(greetingMessage.ToLower());
            }
            else
            {
                Console.WriteLine(greetingMessage);
            }
        }


    }
}
