using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class OnlinePaymentStrategy : PaymentStrategyBase
    {
        public override void MakePayment(double cost)
        {
            Console.WriteLine($"Making ${cost} payment online");
        }
    }
}
