using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb122
{
    public class PrivatBankStrategy : ICreditStrategy
    {
        public double CalculateOverpayment(double amount, int months)
        {
            double rate = 0.03; // 3% в місяць
            return amount * rate * months;
        }

        public string GetBankName()
        {
            return "PrivatBank";
        }
    }
}
