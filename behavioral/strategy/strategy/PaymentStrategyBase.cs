using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public abstract class PaymentStrategyBase
    {
        public abstract void MakePayment(double cost);
    }
}
