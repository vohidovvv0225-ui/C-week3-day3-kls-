
public class Shop
{
    List<Product> p = new List<Product>();

    public void AddProduct(Product product)
    {
        p.Add(product);
    }

    public void RemoveProduct(string a)
    {
        p.RemoveAll(x => x.Name == a);
    }

    public void PrintProductList()
    {
        foreach (var i in p)
        {
            i.PrintInfo();
        }
    }
}
