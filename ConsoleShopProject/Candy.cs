using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopProject
{
    class Candy
    {
        public string Maker { get; set; }

        public decimal Price { get; }


        public Candy (string name, decimal initialPrice)
        {
            this.Maker = name;
            this.Price = initialPrice;
        }
    }
}
