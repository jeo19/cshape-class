﻿using System;
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
        private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;
        public Customer(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Age = age;
            this._IsQualified = age >= 18;
        }
       
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public bool IsQualified
        {
            get { return _IsQualified;}
        }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
