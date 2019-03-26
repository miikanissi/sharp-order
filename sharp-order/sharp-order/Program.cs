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
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); //sets the culture globally
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Unicode; //unicode just in case

            List<MainMenu> menu = new List<MainMenu>(); //Creates a list out of the menu options
            menu.Add(new OrderMenu());
            menu.Add(new StorageMenu());
            menu.Add(new StatusMenu());
            menu.Add(new SendMenu());

            bool running = true;
            do
            {
                Graphics graphics = new Graphics();
                graphics.MenuGraphics();
                string menuChoice = Console.ReadLine();
                Console.Clear();

                MainMenu action = menu.FirstOrDefault(t => t.Command.Equals(menuChoice));

                if (action != null)
                {
                    action.Run();
                }
                else
                {
                    running = false;
                }
            }
            while (running); //keeps running until user inputs an input which doesn't correspond to any choice
        }
    }
}