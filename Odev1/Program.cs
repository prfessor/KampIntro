using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Gaming Notebook";
            product1.ProductCost = 15000;
            product1.DiscountRate = 15;

            Product product2 = new Product();
            product2.ProductName = "Laser Printer";
            product2.ProductCost = 1300;
            product2.DiscountRate = 30;

            Product product3 = new Product();
            product3.ProductName = "Matematik Test Kitabı";
            product3.ProductCost = 50;
            product3.DiscountRate = 20;

            Product product4 = new Product();
            product4.ProductName = "Basketbol Topu";
            product4.ProductCost = 300;
            product4.DiscountRate = 45;

            Product[] ProductList = new Product[] { product1, product2, product3, product4 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Name : " + ProductList[i].ProductName+ "Price : " + ProductList[i].ProductCost + "İndirim Oranı : " + ProductList[i].DiscountRate);
            }
            foreach (var urunler in ProductList) 
            {
                Console.WriteLine("Name : " + urunler.ProductName + "Price : " + urunler.ProductCost + "İndirim Oranı : " + urunler.DiscountRate);
            int w = 0;
            while (w<4)
            {
                    Console.WriteLine("Name : " + ProductList[w].ProductName + "Price : " + ProductList[w].ProductCost + "İndirim Oranı : " + ProductList[w].DiscountRate);
                    w++;

            }
            {

            }
            {
              
            }

        }}

    
    class Product
        {
            public string ProductName { get; set; }
            public int ProductCost { get; set; }
            public int DiscountRate { get; set; }

        }

    
    
    }

}
