using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_17
{
    public class MyMissingTokenException : ArgumentException
    {
        public MyMissingTokenException(string token) : base($"Token is null or empty : {token}.")
        {}
    }
}
