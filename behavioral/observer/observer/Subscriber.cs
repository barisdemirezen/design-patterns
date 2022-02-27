using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class Subscriber : ISubscriber
    {

        private readonly string _name;
        public Subscriber(string name)
        {
            _name = name;
        }
        public void SendMail(int previousPrice, int newPrice)
        {
            Console.WriteLine($"Sending mail to user : {_name} \n \t Dear {_name}, your favorite item had a discount! $ {previousPrice} -> $ {newPrice} \n");
        }
    }
}
