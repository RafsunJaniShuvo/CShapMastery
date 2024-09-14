using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V2
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void ShowFirstName();
        void ShowLastName();
    }
}
