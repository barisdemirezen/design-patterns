using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public interface ISubscriber
    {
        public void SendMail(int previousPrice, int newPrice);
    }
}
