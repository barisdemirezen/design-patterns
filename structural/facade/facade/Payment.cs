using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public static class Payment
    {
        public static bool GetPayment(double cost)
        {
            Console.WriteLine($"Getting $ {cost:F2} payment from user credit card");
            Console.WriteLine($"Payment successfull");
            bool isPaymentSuccessfull = true;
            return isPaymentSuccessfull;
        }
    }
}
