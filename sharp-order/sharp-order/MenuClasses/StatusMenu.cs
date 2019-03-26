using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    class StatusMenu : MainMenu
    {
        public StatusMenu()
        {
            this.Command = "3";
        }
        public override void Run()
        {
            Graphics graphics = new Graphics();
            Csv csv = new Csv();
            Reader reader = new Reader();

            graphics.StatusGraphics();

            Console.WriteLine("Enter your 4-digit ordernumber: ");
            string chosenOrder = reader.AskOrdernumber();
            csv.ReadCsvOrder(chosenOrder);
            csv.PrintCsvOrder();
            Console.WriteLine("\nPress anything to exit.");
            Console.ReadKey();
        }
    }
}
