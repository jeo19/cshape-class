using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    internal class Customer
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;
        public string Description;
        public Customer(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

    }
}
