using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject
{
    public abstract class Client
    {
        //private variables
        private string name;
        private int accountNo;
        private string clientType;
        private decimal chargeAmount;

        //getting and setting values
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int AccountNumber
        {
            get { return accountNo; }
            set
            {
                accountNo = value;
            }
        }
        public string ClientType
        {
            get { return clientType; }
            set
            {
                clientType = value;
            }
        }
        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                chargeAmount = value;
            }
        }
        // Calculate charges method
        public abstract decimal CalculateBill(decimal k);
        //constructor for initial creation
        public Client(string n, int a, string t)
        {
            Name = n;
            AccountNumber = a;
            ClientType = t;
        }
        //constructor for reading from file
        public Client(string n, int a, string t, decimal c)
        {
            Name = n;
            AccountNumber = a;
            ClientType = t;
            ChargeAmount = c;
        }
        public Client() { } //default constructor
        //string override
        public override string ToString()
        {
            string clientStatus;
            if (clientType == "r")
            {
                clientStatus = "Residential";
            }
            else if (clientType == "c")
            {
                clientStatus = "Commercial";
            }
            else
                clientStatus = "Industrial";
            return name + ", Acct: " + accountNo + ", " + clientStatus + ", Total Bill: " + chargeAmount.ToString("c");
        }
        public string ToCSV()//for writing CSV file - no formatting
        {
            return name + "," + accountNo + "," + clientType + "," + chargeAmount;
        }
    } // class level
} //namespace level
