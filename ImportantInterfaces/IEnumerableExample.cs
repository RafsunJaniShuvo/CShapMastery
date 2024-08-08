using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class IEnumerableExample
    {
        //Enurable doesn contain add, remove , count, isReadOnly
        // Enurable only contain basic iteration
        public void Example()
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
