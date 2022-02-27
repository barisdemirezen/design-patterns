using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class Product
    {
        private int _price;
        private List<ISubscriber> _subscribers = new();

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < _price)
                    SendUpdates(_price, value);

                _price = value;
            }
        }

        public void AddPriceWatchSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void SendUpdates(int previousPrice, int newPrice)
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.SendMail(previousPrice, newPrice);
            }
        }
    }
}
