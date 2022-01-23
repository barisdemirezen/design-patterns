using facade;

Product product = new Product
{
    ItemId = 1,
    Price = 10.0
};

// Assume that your are creating a multi-step flow for e-commerce sale with a product
// You can do something like below

Console.WriteLine("\n\nRunning without facade pattern\n");

Stock.ReserveItem(product.ItemId);
bool isPaymentSuccessfull = Payment.GetPayment(product.Price);
if (isPaymentSuccessfull)
    Stock.ReduceItemStock(product.ItemId);
else
    Stock.CancelReservedItem(product.ItemId);

// Of course you need to call required functions to complete a flow but what happens if you need to use this flow in somewhere else?
// The answer is you need to repeat your code and logic. Then what if you need to change one part of flow?
// Now you also need to change multiple parts of your code.

// By creating an isolated class that completes flow itself, we can abstract flow logic

Console.WriteLine("\n\nRunning with facade pattern\n");

Sale.CreateSaleFlow(product); // Now we can use this method to create a sale flow anytime. Easy to implement, easy to maintain.