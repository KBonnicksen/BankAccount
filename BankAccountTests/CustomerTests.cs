using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Create_ValidCustomer_SetsName()
        {
            Customer c = new Customer("J", "Doe");

            String fullName = c.FullName;

            Assert.AreEqual("J Doe", fullName);
        }
    }
}
