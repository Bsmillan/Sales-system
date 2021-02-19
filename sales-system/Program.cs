using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sellers
            Seller s1 = new Seller();
            s1.Name = "Juan";
            s1.Age = 35;

            Seller s2 = new Seller();
            s2.Name = "Andrea";
            s2.Age = 28;

            Seller s3 = new Seller();
            s3.Name = "Felipe";
            s3.Age = 45;

            //Products
            Product p1 = new Product();
            p1.Name = "Samsung P10";
            p1.Price = 500f;

            Product p2 = new Product();
            p2.Name = "Xiaomi A5";
            p2.Price = 300f;

            Product p3 = new Product();
            p3.Name = "Battery 4000Ma";
            p3.Price = 150f;

            //Sales
            Sale Sale1 = new Sale();
            Sale1.Product = p1;
            Sale1.Seller = s1;
            Sale1.Comments = "Phone Samsung P10, 1 year warranty, cash payment.";

            Sale Sale2 = new Sale();
            Sale2.Product = p2;
            Sale2.Seller = s2;
            Sale1.Comments = "Phone Xiaomi A5, 1 year warranty, credit payment, deferred 4 dues.";

            Sale Sale3 = new Sale();
            Sale3.Product = p3;
            Sale3.Seller = s2;
            Sale3.Comments = "Battery 4000Ma for Nokia S850, 3 months warranty, cash payment.";

            //Calculate sales total amount
            float TotalSales = 0;
            TotalSales = Sale1.Product.Price + Sale2.Product.Price + Sale3.Product.Price;

            System.Console.WriteLine("Total sales are: $" + TotalSales);

        }
    }
}
