using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.Base
{
    public abstract class BaseSms
    {
        public abstract bool SendSms(string smsContent);
    }
}
