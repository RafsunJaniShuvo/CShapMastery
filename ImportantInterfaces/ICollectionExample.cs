using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class ICollectionExample
    {
        //ICollection contain basic iteration
        // add/remove
        // count
        // IsReadOnly
        // IEnumerable
        public void ICollectionMethod()
        {
            ICollection<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            number.Add(9);
            number.Add(10);
            number.Add(11);
            number.Add(12);
            number.Add(13);
            number.Remove(1);
            number.Remove(2);
            number.Remove(3);
            number.Remove(4);
            number.Remove(5);

            foreach(int num in number)
            {
                Console.WriteLine($" Value : {num}");
            }

            Console.WriteLine( $" Array Length : {number.Count()}");
        }
    }
}
