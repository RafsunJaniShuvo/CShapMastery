using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedModifier
{
    public class Example
    {
        public int sum(params int[] values) { // instead all argument , we can use params
            int sum = 0;
            foreach (int val in values)
            {
                sum += val;
            }
            return sum;
        }

        public void xxx(ref int value) // reference type
        {
            value = 50;
        }

        public void yyy(in int value)
        { //cant assign in value
            Console.WriteLine(value);

        }
        public void zzz(out int value)
        { // ofcourse we have to assign value in parameter
            value = 50;
            Console.WriteLine(value);
        }

    }
}
