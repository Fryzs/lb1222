using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb122
{
    public class OschadBankStrategy : ICreditStrategy
    {
        public double CalculateOverpayment(double amount, int months)
        {
            double rate = 0.028; // 2.8%
            return amount * rate * months;
        }

        public string GetBankName()
        {
            return "OschadBank";
        }
    }
}
