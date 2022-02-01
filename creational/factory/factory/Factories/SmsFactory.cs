using factory.Base;
using factory.Enums;
using factory.Models;

namespace factory.Factories
{
    public class SmsFactory
    {
        public BaseSms CreateSms(SmsTypes type)
        {
            BaseSms baseSms = null;

            switch (type)
            {
                case SmsTypes.Promotion:
                    baseSms = new PromotionSms();
                    break;
                case SmsTypes.Information:
                    baseSms = new InformationSms();
                    break;
            }

            return baseSms;
        }
    }
}
