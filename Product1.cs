using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    //Create Product class with code, name & Price. Assign value using property
    // Use both property & object initializer syntax, & display the product details

    public class Product1
    {
        private int code, price;
        private string name;

        public int Code
        {
            set { code = value; }
            get { return code; }


        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Print()
        {
            return $"Product {code} {price} {name}";

        }


    }
}
