using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb122
{
    public class MonoBankStrategy : ICreditStrategy
    {
        public double CalculateOverpayment(double amount, int months)
        {
            double rate = 0.025; // 2.5%
            return amount * rate * months + 200; // комісія
        }

        public string GetBankName()
        {
            return "MonoBank";
        }
    }
}
