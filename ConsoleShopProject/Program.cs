using System;

namespace ConsoleShopProject
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new Books ("Skipping Christmas", 10);
            Console.WriteLine($"Title {list.Title} for {list.Price} ");

            var list1 = new Books("Black Leopard, Red Wolf", 20);
            Console.WriteLine($"Title {list1.Title} for {list1.Price} ");

            var list2 = new Books("The Dutch House", 30);
            Console.WriteLine($"Title {list2.Title} for {list2.Price} ");

        }
    }
}
