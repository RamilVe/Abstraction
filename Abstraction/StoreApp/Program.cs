using System;
using StoreApp.Implementations;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BravoMarket bravo1 = new BravoMarket();

            bravo1.AddProduct(new Product { Name = "Coca Cola 1l", Price = 2, ExpireDate = new DateTime(2023, 10, 20) });
            bravo1.AddProduct(new Product { Name = "Pepsi Cola 1l", Price = 2.5, ExpireDate = new DateTime(2024, 10, 20) });
            bravo1.AddProduct(new Product { Name = "Lider Cola 1l", Price = 3, ExpireDate = new DateTime(2024, 12, 20) });

            bravo1.Sell("Lider Cola 1l");
            bravo1.Sell("Lider Cola 1l");
            bravo1.Sell("Pepsi Cola 1l");

            for(int i = 0; i < bravo1.Sales.Length; i++)
            {
                if(bravo1.Sales[i].Date >= DateTime.Now.AddHours(-1)) //DateTime.Now-bravo1.Sales[i].Date).TotalMinutes<=60
                {
                    Console.WriteLine(bravo1.Sales[i].GetInfo());
                }                
            }


            Console.WriteLine(bravo1.TotalAmount);

        }
    }
}
