using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public double Height {  get; set; }
        public double Weight { get; set; }

        protected string address { get; set; }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
