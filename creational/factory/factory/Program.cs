using factory.Base;
using factory.Enums;
using factory.Factories;


SmsFactory smsFactory = new SmsFactory();

BaseSms promotional = smsFactory.CreateSms(SmsTypes.Promotion);

BaseSms informational = smsFactory.CreateSms(SmsTypes.Information);

promotional.SendSms("Shop now and get discounts up to %50!");

Console.WriteLine("\n----------------\n");

informational.SendSms("Your orders are on the way");

Console.ReadLine();