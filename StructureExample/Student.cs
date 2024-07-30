using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StructureExample
{ // by default empty constructure holds by struct
    public struct Student : IPerson   // internally struct is value type and class is  referency type . For structure We can't interherit any class
    {
        private int id;

        public string Name { get; set; }    
        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public Student() // empty contructor for struct
        {
            id = 0;
        }
        public Student(int id) // another paremeterized constructor for struct
        {
            this.id = id;
        }

        public void Talk(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
