using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public static class Stock
    {
        public static void ReserveItem(int itemId)
        {
            Console.WriteLine($"Reserving item with id {itemId}");
        }

        public static void CancelReservedItem(int itemId)
        {
            Console.WriteLine($"Canceling reservation of item with id {itemId}");
        }

        public static void ReduceItemStock(int itemId)
        {
            Console.WriteLine($"Reducing stock count of item with id {itemId}");
        }
    }
}
