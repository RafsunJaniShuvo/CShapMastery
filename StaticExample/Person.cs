using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public  class Person
    {
        public  string Name { get; set; }    
        public  static int count { get; set; }

        public static string country { get; set; }
        static Person() //Normallyu We use static constructor because of initilization for static variable ;
        {
            count = 0;
            country = "Bangladesh";
        }

        public  void IncreaseCount()
        {
            count++;
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
