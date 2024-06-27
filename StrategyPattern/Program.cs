using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PaymentContext paymentContext = new PaymentContext();


            paymentContext.SetPaymentStrategy(new CreditCardPayment());
            paymentContext.Pay(100);


            paymentContext.SetPaymentStrategy(new PayPalPayment());
            paymentContext.Pay(200);

            Console.ReadLine();
        }
    }
}
