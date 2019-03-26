using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Printer
    {
        public void PrintProductrowHeader()
        {
            Console.WriteLine("Product\t\t\tGame\t\t\tConsole\t\t\tPrice\t\t\tStorage");
            Console.WriteLine(Globals.dottedlinegraph);
        }
        public void PrintProductrow(int number, Product product)
        {
            number = number + 1;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string print = $"{number}\t\t\t{product.Game}\t\t{product.Console}\t\t{product.Price}€\t\t\t{product.Storage}";
            Console.WriteLine(print);
            Console.ResetColor();
        }
        public void PrintProductrows(List<Product> productlist)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < productlist.Count(); i++) 
            {
                Product prodcutonlist = productlist[i];
                this.PrintProductrow(i, prodcutonlist);
            }
            Console.ResetColor();
            Console.WriteLine(Globals.dottedlinegraph);
        }
    }
}
