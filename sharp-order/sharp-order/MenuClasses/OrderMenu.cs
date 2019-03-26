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
    public class OrderMenu : MainMenu
    {
        public OrderMenu()
        {
            this.Command = "1"; //number 1 corresponds to this menu
        }
        public override void Run()
        {

            Graphics graphics = new Graphics();
            Ordernumber ordernumber = new Ordernumber();
            Printer printer = new Printer();
            Csv csv = new Csv();
            Reader reader = new Reader();

            graphics.OrderGraphics();

            List<Product> productlist = new List<Product>();
            csv.ReadProductsFromFile(productlist);

            printer.PrintProductrowHeader();
            printer.PrintProductrows(productlist);

            Console.Write("\nGive your desired product number or exit by pressing \"0\": ");
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

                Product chosenProduct = productlist[chosenProductNumber - 1];

                if (chosenProduct.Storage < 50)
                {
                    Console.WriteLine("Product is out of stock, choose another product. ");
                    Console.ReadKey();
                }
                else
                {
                    printer.PrintProductrow(chosenProductNumber - 1, chosenProduct);

                    Console.Write("\nEnter how many products you'd like to order: (min. 50): ");
                    int amount = reader.AskNumber();

                    while (true)
                    {
                        if (amount < 50)
                        {
                            Console.WriteLine("Minimum order is 50 products. Enter the correct amount. ");
                            amount = reader.AskNumber();
                        }
                        else if (amount > chosenProduct.Storage)
                        {
                            Console.WriteLine("Not enough products in stock. Enter the correct amount. ");
                            amount = reader.AskNumber();
                        }
                        else
                        {
                            break;
                        }
                    }

                    Order order = new Order();

                    reader.AskContactinfo(order);

                    order.Ordernumber = ordernumber.CreateOrdernumber();
                    order.Console = chosenProduct.Console;
                    order.Game = chosenProduct.Game;
                    order.Amount = amount;
                    order.Date = DateTime.Now;
                    order.Status = "Received";
                    double totalPrice = (amount * chosenProduct.Price);
                    order.Price = totalPrice;

                    graphics.ThanksGraphics();
                    csv.WriteNewOrder(order);

                    int tempStorage = (chosenProduct.Storage - amount);
                    csv.WriteNewStorage(chosenProduct, tempStorage);

                    string chosenOrder = order.Ordernumber;
                    csv.ReadCsvOrder(chosenOrder);
                    csv.PrintCsvOrder();

                    Console.WriteLine("\nPress anything to exit. ");
                    Console.ReadLine();
                }
            }
        }
    }
}
