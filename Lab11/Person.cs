﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public override string ToString()
        {            
            return "\nPerson: " + Name +"\nAddress: " + Address;
        }
    }
}
