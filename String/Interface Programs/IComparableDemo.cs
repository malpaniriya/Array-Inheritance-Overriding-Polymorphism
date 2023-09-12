using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static String.Interface_Programs.IComparableDemo;

namespace String.Interface_Programs
{
    internal class IComparableDemo
    {
        public class Product : IComparable
        {

            private string name;
            private int price;

            public Product(string name, int price)
            {

                this.name = name;
                this.price = price;
            }

            public int CompareTo(object obj)
            {
                Product p = (Product)obj;
                if (this.price < p.price)
                {
                    return 1;
                }
                else if (this.price > p.price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            public override string ToString()
            {
                return $" {name} {price}";
            }

        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Product speaker1 = new Product("Boult Speaker",3000);
                Product speaker2 = new Product("Airpods Pro", 25000);
                int price=speaker1.CompareTo(speaker2);
                if(price == 1)
                {
                    Console.WriteLine("Boult speaker is not costly than airpods pro");
                    
                }
                else if(price == -1)
                {
                    Console.WriteLine("Boult speaker is costly than airpods pro");
                }
                else
                {
                    Console.WriteLine("both has equal price");
                }



            }

        }
    }
}


    







