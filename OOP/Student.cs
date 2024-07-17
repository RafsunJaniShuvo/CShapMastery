
namespace Opp.FirstDemo
{
    public class Student

    {
        //field
        public string name;
        private int roll;
        protected int className;
        //internal string address;
        //protected internal string city;


        //property
        private string AccNo;
        public string AccNum
        {
            get {
                if(AccNo == null) 
                      return string.Empty;
                else return AccNo;  
            }
            set { 
                if(value != null)
                {
                    AccNo = value;
                }
                else
                {
                    AccNo = string.Empty;
                }
             
            }
        }

        // Auto property
        public string Adrress { get; set; }

        public Student(string name, int roll) // parameterized constructor
        {   
            this.name = name;
            this.roll = roll;
        }

        public Student() { } //Empty constructor
        //and these two contructors are demontrating method/constructor overloading

        public static Student CreateNewStudent()
        {
            return new Student();
        }

        public void SetRoll(int roll)
        {
            this.roll = roll;
        }

        ~Student() { } // Destructor 
    }
}