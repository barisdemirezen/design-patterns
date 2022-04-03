using strategy;

Payment payment = new Payment();

payment.SetCost(100);
payment.SetPaymentStrategy(new OnlinePaymentStrategy());

payment.CompletePayment();

payment.SetCost(50);
payment.SetPaymentStrategy(new WiretransferPaymentStrategy());

payment.CompletePayment();