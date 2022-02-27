using observer;

// Creating product and setting price
Product product = new();
product.Price = 50;

// Assume that these users added the product to their favorite list
product.AddPriceWatchSubscriber(new Subscriber("Barış Demirezen"));
product.AddPriceWatchSubscriber(new Subscriber("John John"));
product.AddPriceWatchSubscriber(new Subscriber("Susan Mary"));

// Setting discount for product
product.Price = 30;

Console.ReadKey();