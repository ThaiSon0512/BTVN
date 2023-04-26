using System;
using System.Collections.Generic;

class Program
{
    static List<Product> productList = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;

                case 2:
                    DisplayProducts();
                    break;

                case 3:
                    DeleteProduct();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter product ID: ");
        int productId = int.Parse(Console.ReadLine());

        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter product price: ");
        double productPrice = double.Parse(Console.ReadLine());

        Product newProduct = new Product(productId, productName, productPrice);
        productList.Add(newProduct);

        Console.WriteLine("Product added successfully.");
    }

    static void DisplayProducts()
    {
        Console.WriteLine("Product ID\tProduct Name\tProduct Price");

        foreach (Product product in productList)
        {
            Console.WriteLine($"{product.ProductId}\t\t{product.ProductName}\t\t{product.ProductPrice}");
        }
    }

    static void DeleteProduct()
    {
        Console.Write("Enter product ID to delete: ");
        int productId = int.Parse(Console.ReadLine());

        bool productFound = false;

        foreach (Product product in productList)
        {
            if (product.ProductId == productId)
            {
                productList.Remove(product);
                productFound = true;
                break;
            }
        }

        if (productFound)
        {
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }

    public Product(int productId, string productName, double productPrice)
    {
        ProductId = productId;
        ProductName = productName;
        ProductPrice = productPrice;
    }
}
