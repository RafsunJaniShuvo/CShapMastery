using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V2
{
    public class Person : IPerson //This is known as implements [interface]
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void ShowFirstName()
        {
            Console.WriteLine($"{this.FirstName} of Person Class");
        }

        public void ShowLastName()
        {
            Console.WriteLine($"{this.LastName} of Person Class");
        }
    }

    public class Student : Person // This is known as extends [inheritance]
    {
        public void StudentFullName()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} is the name of Students");
        }
    }

}
