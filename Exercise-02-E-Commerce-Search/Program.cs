using System;

namespace ECommerceSearch
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        static Product LinearSearch(Product[] products, int id)
        {
            foreach (Product product in products)
            {
                if (product.ProductId == id)
                    return product;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories")
            };

            Console.Write("Enter Product ID to search: ");

            int id = Convert.ToInt32(Console.ReadLine());

            Product result = LinearSearch(products, id);

            if (result != null)
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("----------------------");
                Console.WriteLine("ID : " + result.ProductId);
                Console.WriteLine("Name : " + result.ProductName);
                Console.WriteLine("Category : " + result.Category);
            }
            else
            {
                Console.WriteLine("\nProduct Not Found");
            }
        }
    }
}
