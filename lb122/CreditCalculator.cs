using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb122
{
    public class CreditCalculator
    {
        private ICreditStrategy strategy;

        public void SetStrategy(ICreditStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double Calculate(double amount, int months)
        {
            if (strategy == null)
                throw new Exception("Strategy not selected");

            return strategy.CalculateOverpayment(amount, months);
        }
    }
}
