using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class SecuritySystem<TUser> where TUser : IUser
    {
        private TUser _user;

        public TKey open<TKey>(TKey key) //Tkey will only be available inside method
        {
             TKey anotherkey = default(TKey);
             return anotherkey;
        }
    }
}
