using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningNet.Lessons.Lesson_12
{
    public class CollectionsAction
    {

        public static Person CreatePerson(string firstName, string lastName, Address shippingAddress)
        {
            Person p = new Person();
            p.FirstName = firstName;
            p.LastName = lastName;
            p.ShippingAddress = shippingAddress;

            return p;
        }

        public static Address CreateAdress(string streetAddress, string city, string state, string postalCode, string country)
        {
            Address adr = new Address();
            adr.StreetAddress = streetAddress;
            adr.City = city;
            adr.State = state;
            adr.PostalCode = postalCode;
            adr.Country = country;

            return adr;
        }

    }
}
