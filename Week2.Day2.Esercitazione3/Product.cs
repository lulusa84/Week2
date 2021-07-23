using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Day2.Esercitazione3
{
    class Product
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime Created { get => DateTime.Now; }

 

        public Product()
        {
        }

        public Product(int code, double price)
        {
            Code = code;
            Price = price;
        }

        /*public Product(int code, string description, double price)
        {
            Code = code;
            Description = description;
            Price = price;
        }*/
        public Product(int code, double price, string description) : this(code, price)
        {
            
            Description = description;

        }


        public double  DiscountedPrice(double discount)
        {
           double  discountPercentage = discount / Price;
            if (discountPercentage > 0.2)
            {
                discount = Price - (Price * 0.2);

                
            }
           
            Console.WriteLine(discount);
            return discount;
        }

        public int ProductAge()
        {
           
            DateTime DayToday = DateTime.Today;
           int  Age = DayToday.Subtract(Created).Days;

            Console.WriteLine(Age);
            return Age;
           
        }
        /*code:
         *-description
         * -price
         * .created
         */
        public void SaveProduct()
        {

            Console.WriteLine("Sono nel metodo SaveToFile file");
            try
            {
                
                //scrittura su file
                string path = @"C:\Users\sarah.tarantino\Desktop\Week2";
                using (StreamWriter writer = File.CreateText(path + @"\Products.txt"))
                {
                   writer.WriteLine("Code: {0} \n - description {1}  \n - price {2}  \n - created {3}", Code, Description, Price, Created);
                    // writer.WriteLine($"{e.ChangeType.ToString()}");
                  Console.WriteLine("Code: {0} \n - description {1}  \n - price {2}  \n - created {3}", Code, Description, Price, Created);
                }
               
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
