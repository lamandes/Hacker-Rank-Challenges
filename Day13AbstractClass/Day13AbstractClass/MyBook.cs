using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13AbstractClass
{
    class MyBook : Book
    {
        protected int price;

        public MyBook(String title, String author, int price) : base(title, author)                 //Same as super() in abstract extend in Java
        {
            this.price = price;
        }

        //Override abstract method in Book.cs
        public override void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", title, author, price);
        }
    }
}
