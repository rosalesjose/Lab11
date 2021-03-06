﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            set { program = value; }
            get { return program; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Fee
        {
            set { fee = value; }
            get { return fee; }
        }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public override string ToString()
        {
            return base.ToString() + "\nProgram: " + program + "\nYear: " + Year + "\nFee: " + Fee;
        }
    }
}
