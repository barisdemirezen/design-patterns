
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

public interface ISubscriber
{
    public void SendMail(int previousPrice, int newPrice);
}

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