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
            Console.Title = "Lab 11";

            List<Person> Plist = new List<Person>();
            Plist.Add(new Person("John", "123 Sesame St."));
            Plist.Add(new Student("Cass", "123 Sunset Blvd.", "Geography", 4, 52000));
            Plist.Add(new Staff("Caesar", "123 Broadway Rd.", "Parsons", 89000.00));

            foreach (Person o in Plist)
            {
                Console.WriteLine(o.ToString());
            }    
        }
    }
}