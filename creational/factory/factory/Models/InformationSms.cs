using factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.Models
{
    public class InformationSms : BaseSms
    {
        public override bool SendSms(string smsContent)
        {
            Console.WriteLine("Creating informational sms data");
            Console.WriteLine("Target : 555-555-55-55");            
            Console.WriteLine($"Message : {smsContent}");
            Console.WriteLine("Sending Sms");
            return true;
        }
    }
}
