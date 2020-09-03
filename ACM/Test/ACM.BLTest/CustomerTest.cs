 using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrage
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //-- Actual
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestFirstNameEmpty()
        {
            //-- Arrage
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            //-- Actual
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestLastNameEmpty()
        {
            //-- Arrage
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            //-- Actual
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var C1 = new Customer();
            C1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var C2 = new Customer();
            C2.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var C3 = new Customer();
            C3.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            //-- Actual
            int actual = Customer.InstanceCount;

            //-- Assert
            Assert.AreEqual(3, actual);
        }
    }
}
