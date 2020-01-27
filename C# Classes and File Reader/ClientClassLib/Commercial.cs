using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject
{
    public class Commercial:Client
    {
        const decimal COM_RATE = 0.045m; // commercial rate
        const decimal COM_FLT = 60; // commercial flat rate
        //constructors
        public Commercial(string n, int a, string t) : base(n, a, t)
        {

        }
        public Commercial(string n, int a, string t, decimal c) : base(n, a, t, c)
        {

        }
        public override decimal CalculateBill(decimal k)
        {
            //variables
            decimal kwh = k; //kilowatts per hour
            decimal totalBill = 0; //final bill amount
            decimal flatRate = COM_FLT;
            decimal rate = COM_RATE;
            decimal initialEnergy = 1000; //ceiling before additional charges are added to commercial

            //calculate commercial rate             
            if (kwh >= initialEnergy)
            {
                totalBill = ((kwh - initialEnergy) * rate) + flatRate;
            }
            else
            {
                totalBill = flatRate;
            }
            return totalBill;
        }
    }
}
