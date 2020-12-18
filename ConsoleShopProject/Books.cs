using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopProject
{
    public class Books
    {
        public string Title { get; set; }

        public decimal Price { get; }


        public Books(string name, decimal initialPrice)
        {
            this.Title = name;
            this.Price = initialPrice;

        }
    }
}
