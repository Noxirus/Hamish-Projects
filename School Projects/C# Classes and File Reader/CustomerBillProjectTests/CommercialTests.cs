using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerBillProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject.Tests
{
    [TestClass()]
    public class CommercialTests
    {
        [TestMethod()]
        public void TestCalculateCharge()
        {
            // Arrange
            Client person; //declare reference variable
            string name = "Fred";
            int acctNo = 1;
            string type = "r";
            decimal kwh = 5;
            decimal expectedCharge = 60;
            decimal actualCharge;

            //Act
            person = new Commercial(name, acctNo, type); // create account with initial balance
            actualCharge = person.CalculateBill(kwh);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
        [TestMethod()]
        public void TestCalculateChargeOverBase()
        {
            // Arrange
            Client person; //declare reference variable
            string name = "Fred";
            int acctNo = 1;
            string type = "r";
            decimal kwh = 1500;
            decimal expectedCharge = 82.50m;
            decimal actualCharge;

            //Act
            person = new Commercial(name, acctNo, type); // create account with initial balance
            actualCharge = person.CalculateBill(kwh);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}