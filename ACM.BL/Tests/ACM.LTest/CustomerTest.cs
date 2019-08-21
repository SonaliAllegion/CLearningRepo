using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.LTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNametestValid()
        {
            //------Arrange
            Customer customer = new Customer
            {
                FirstName = "sonali",
                LastName = "soni"
            };
            //--Act
            string expected = "soni,sonali";
            string actual = customer.FullName;

            //---Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer()
            {
                LastName = "soni",
                EmailAddress = "sonalisoni108@gmail.com"

            };

            bool expected = true;

            bool actual = customer.Validate();
            Assert.AreEqual(expected, actual);
            Console.WriteLine("TestCase Pass");

        }

        [TestMethod]
        public void ValidateLastName()
        {
            Customer customer = new Customer()
            {
              
                EmailAddress = "sonalisoni108@gmail.com"

            };

            bool expected = false;
            bool actual = customer.Validate();
            Assert.AreEqual(expected, actual);

        }
    }
}
