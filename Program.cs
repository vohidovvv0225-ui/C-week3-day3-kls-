

        Product p1 = new Product("Laptop", 800);
        Product p2 = new Product("Phone", 500);
        Product p3 = new Product("Mouse", 20);
        Shop shop = new Shop();

        shop.AddProduct(p1);
        shop.AddProduct(p2);
        shop.AddProduct(p3);

        Console.WriteLine();

        shop.PrintProductList();

        Console.WriteLine();

 shop.RemoveProduct("Phone");
        Console.WriteLine();

        shop.PrintProductList();
        