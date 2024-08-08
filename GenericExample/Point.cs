using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample // Generic Class
{
    public class Point<T,U> 
        //where T : struct
       // where U : struct // where means here constraint
    {
        public T X { get; set; }
        public U Y { get; set; }
    }

    public class SuperPoint<A,B,C> : Point<A,B>
      //  where A : struct
      //  where B : struct
    {
        public C amount { get; set; }
    }

    public class Person :IUser
    {
        public string Name { get; set; }
        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    } 

}
