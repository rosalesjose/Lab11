using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "123 Sesame St.");
            Console.WriteLine(p1.ToString());

            Student student1 = new Student("Cass", "123 Sunset Blvd.", "Geography", 4, 52000);
            Console.WriteLine(student1.ToString());

            Staff staff1 = new Staff("Caesar", "123 Broadway Rd.", "Parsons", 89000.00);
            Console.WriteLine(staff1.ToString());
        }
    }
}
