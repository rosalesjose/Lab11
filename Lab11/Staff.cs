using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            set { school = value; }
            get { return school; }
        }

        public double Pay
        {
            set { pay = value; }
            get { return pay; }
        }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
    }
}
