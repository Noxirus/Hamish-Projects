using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerBillProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClientClassLib;

namespace CustomerBillProject.Tests
{
    [TestClass()]
    public class ResidentialTests
    {
        [TestMethod()]
        public void TestConstructorPositiveInitial()
        {
            // Arrange
            Client person; //declare reference variable
            string name = "Fred";
            int acctNo = 1;
            string type = "r";
            decimal expectedAcctNo = 1;
            decimal actualAcctNo;

            //Act
            person = new Residential(name, acctNo, type); // create account with initial balance
            actualAcctNo = person.AccountNumber;

            //Assert
            Assert.AreEqual(expectedAcctNo, actualAcctNo);
        }
        [TestMethod()]
        public void TestCalculateCharge()
        {
            // Arrange
            Client person; //declare reference variable
            string name = "Fred";
            int acctNo = 1;
            string type = "r";
            decimal kwh = 5;
            decimal expectedCharge = 6.26m;
            decimal actualCharge;

            //Act
            person = new Residential(name, acctNo, type); // create account with initial balance
            actualCharge = person.CalculateBill(kwh);

            //Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}