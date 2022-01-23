using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public static class Sale
    {
        public static void CreateSaleFlow(Product product)
        {
            Stock.ReserveItem(product.ItemId);
            bool isPaymentSuccessfull = Payment.GetPayment(product.Price);
            if (isPaymentSuccessfull)
                Stock.ReduceItemStock(product.ItemId);
            else
                Stock.CancelReservedItem(product.ItemId);
        }
    }
}
