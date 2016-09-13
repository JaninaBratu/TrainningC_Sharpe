﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_13
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        protected string FirstName { get; private set; }
        protected string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        public bool IsAnAdult()
        {
            var eighteenYearsAgo = DateTime.Today.AddYears(-18);
            return this.DateOfBirth < eighteenYearsAgo;
        }
    }
}
