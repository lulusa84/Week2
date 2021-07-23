using System;

namespace Week1.Day2.Esercitazione3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product(103,50,"Laser Printer");
            ;

            pr.DiscountedPrice(30);

            pr.ProductAge();

            pr.SaveProduct();
        }
    }
}
