using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public abstract class Vehicle
    {
        protected double TopSpeed { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }

        public int PassengerCount { get; set; }

        public Vehicle()
        {
            TopSpeed = 100;
        }

        public abstract void Start();

        public abstract void Stop();
    }
}
