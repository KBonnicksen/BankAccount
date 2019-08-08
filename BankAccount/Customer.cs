using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Customer
    {
        public string FullName { get; private set; }

        public Customer(string fName, string lName)
        {
            FullName = $"{ fName } { lName }";
        }
    }
}
