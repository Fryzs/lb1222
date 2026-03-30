using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb122
{
    public interface ICreditStrategy
    {
        double CalculateOverpayment(double amount, int months);
        string GetBankName();
    }
}
