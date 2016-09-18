using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_17
{
    public class MyInvalidTokenException : ArgumentException
    {
        public MyInvalidTokenException(string token) : base($"The token does not match the criteria of maximum lenght: {token }. ")
        { }
    }
}
