public class Product
{
    public string Name;
    public double Price;
    public Product(string name, double price)
    {
        Name = name;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
    }