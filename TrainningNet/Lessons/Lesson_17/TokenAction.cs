using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_17
{
    public class TokenAction
    {

        private const int tokenLenght = 5;
        //List<string> listOfTokens = new List<string>();

        public List<string> GetAccessPermissions(string token)
        {
            // check token validity here and throw exceptions as needed.
            if (token == null || token.Equals(""))
             {
                    throw new MyMissingTokenException(token);
             }
             else if(token.Length != tokenLenght)
             {
                throw new MyInvalidTokenException(token);
              }

            return new List<string> { "ReadLessons", "ReviewLessons" };
        }
    }
}
