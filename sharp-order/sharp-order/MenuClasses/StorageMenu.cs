using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace sharp_order
{
    public class StorageMenu : MainMenu
    {
        public StorageMenu()
        {
            this.Command = "2";
        }
        public override void Run()
        {
            Graphics graphics = new Graphics();
            Printer printer = new Printer();
            Csv csv = new Csv();
            Reader reader = new Reader();
            
            graphics.StorageGraphics();

            List<Product> productlist = new List<Product>();
            csv.ReadProductsFromFile(productlist);

            printer.PrintProductrowHeader();
            printer.PrintProductrows(productlist);


            Console.Write("\nGive the product number of which storage you want to change, or exit by pressing \"0\": ");

            int chosenProductNumber = reader.AskNumber();

            while (chosenProductNumber > productlist.Count() || chosenProductNumber < 0)
            {
                Console.WriteLine("Give a correct product number. ");
                chosenProductNumber = reader.AskNumber();
            }
            if (chosenProductNumber == 0)
            {

            }
            else
            {
                Console.WriteLine("Enter password(admin): ");
                string attempt = Console.ReadLine();

                while (attempt != Globals.password)
                {
                    Console.WriteLine("You entered an incorrect password, enter password again, or exit by pressing \"0\": ");
                    attempt = Console.ReadLine();
                    if (attempt == "0") break;
                }
                if (attempt == Globals.password)
                {

                    Product chosenProduct = productlist[chosenProductNumber - 1];

                    printer.PrintProductrow(chosenProductNumber - 1, chosenProduct);

                    Console.WriteLine("\nEnter new stock amount: ");
                    int tempStorage = reader.AskNumber();
                    csv.WriteNewStorage(chosenProduct, tempStorage);
                }
            }
        }
    }
}
