using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Car : Vehicle
    {
        public override void Start() // when parent class has abstract method, if we extend that class we need to write override keyword
        {
            Console.WriteLine($"Car Starting ");
        }
        public override void Stop() // when parent class has abstract method, if we extend that class we need to write override keyword
        {
            Console.WriteLine($"Car Stopping"); 
        }

    }
}
