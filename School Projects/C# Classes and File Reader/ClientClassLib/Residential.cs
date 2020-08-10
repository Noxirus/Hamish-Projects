using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject
{
    public class Residential: Client
    {
        const decimal RES_RATE = 0.052m; //residential rate
        const decimal RES_FLT = 6; // residential flat rate

        //constructors
        public Residential(string n, int a, string t): base(n,a,t)
        {

        }
        public Residential(string n, int a, string t, decimal c) : base(n, a, t, c)
        {

        }
        public override decimal CalculateBill(decimal k)
        {
            //variables
            decimal kwh = k; //kilowatts per hour
            decimal totalBill = 0; //final bill amount
            decimal flatRate = RES_FLT;
            decimal rate = RES_RATE;
            decimal initialEnergy = 0; //ceiling before additional charges are added to commercial and industrial

            //calculate residential rate             
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
