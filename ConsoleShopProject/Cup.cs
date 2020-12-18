using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopProject
{
    class Cup
    {
        public string Designer { get; set; }

        public decimal Price { get; }


        public Cup(string name, decimal initialPrice)
        {
            this.Designer = name;
            this.Price = initialPrice;
        }
    }
}
