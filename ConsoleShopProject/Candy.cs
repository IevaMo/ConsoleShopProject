using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleShopProject
{
    class Candy
    {
        public string Saldainiufirma { get; set; }

        public decimal Price { get; }


        public Candy (string name, decimal initialPrice)
        {
            this.Saldainiufirma = name;
            this.Price = initialPrice;
        }
    }
}
