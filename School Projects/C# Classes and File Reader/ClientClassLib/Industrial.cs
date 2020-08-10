using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBillProject
{
    public class Industrial: Client
    {
        const decimal IND_RATE_PEAK = 0.065m; //industrial peak rate
        const decimal IND_RATE_OFF = 0.028m; // industrial off rate
        const decimal IND_FLT_PEAK = 76; // industrial peak flat rate
        const decimal IND_FLT_OFF = 40; // industrial off flat rate
        //constructors
        public Industrial(string n, int a, string t) : base(n, a, t)
        {

        }
        public Industrial(string n, int a, string t, decimal c) : base(n, a, t, c)
        {

        }
        public decimal CalculateBill(decimal k, decimal ok)
        {
            //variables
            decimal kwh = k; //peak kilowatts per hour
            decimal offkwh = ok;// off hours kilowatts per hour
            decimal totalBill = 0; //final bill amount
            decimal flatRate = IND_FLT_PEAK;
            decimal rate = IND_RATE_PEAK;
            decimal initialEnergy = 1000; //ceiling before additional charges are added to industrial

            //calculate industrial rate             
            if (kwh >= initialEnergy)
            {
                totalBill = ((kwh - initialEnergy) * rate) + flatRate;
            }
            else
            {
                totalBill = flatRate;
            }

            flatRate = IND_FLT_OFF;
            rate = IND_RATE_OFF;
            if (offkwh >= initialEnergy)
            {
                totalBill += ((offkwh - initialEnergy) * rate) + flatRate;
            }
            else
            {
                totalBill += flatRate;
            }
            return totalBill;
        }
        //base override with only peak hours
        public override decimal CalculateBill(decimal k)
        {
            decimal kwh = k;
            decimal totalBill = 0; //final bill amount
            decimal flatRate = IND_FLT_PEAK;
            decimal rate = IND_RATE_PEAK;
            decimal initialEnergy = 1000;

            //calculate peak industrial rate             
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
