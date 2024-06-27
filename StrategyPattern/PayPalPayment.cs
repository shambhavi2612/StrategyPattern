using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine("Paid " + amount + " using PayPal.");
        }
    }
}
