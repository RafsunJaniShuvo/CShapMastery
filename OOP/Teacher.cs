using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Teacher : Person
    {
       // public string Address { get; set; }

        public double salary { get; set; }

        public void Setheight(double height)
        {
            Height = height;
        }

        public void setAddress(string address) 
        {
            address = address;
        }


    }
}
