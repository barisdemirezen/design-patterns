using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Payment
    {
        private double _cost;
        private PaymentStrategyBase _paymentStrategy;

        public void SetPaymentStrategy(PaymentStrategyBase paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void SetCost(double cost)
        {
            _cost = cost;
        }

        public void CompletePayment()
        {
            _paymentStrategy.MakePayment(_cost);
            _cost = 0;
        }
    }
}
