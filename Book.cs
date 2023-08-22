using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    internal class Book
    {
        //Create Book class --> bookid, name,price, author name --> accept & display
        private int id, price;
        private string name,authorname;

        public Book()
        {
            id = 0;
            price = 0;
            name = " ";
            authorname = " ";

        }
         
        public Book(int id,int price,string name,string authorname)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.authorname = authorname;
        }
        //public void AcceptBook(int ID,int PRICE,string n,string AN)
        //{
        //    id = ID;
        //    price = PRICE;
        //    name = n;
        //    authorname = AN;

        //}
        public string PrintBook()
        {
            return $"Book : {id}\n, {price}\n,{name}\n,{authorname}\n";
        }

    }
}
