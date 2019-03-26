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
    public class SendMenu : MainMenu
    {
        public SendMenu()
        {
            this.Command = "4";
        }
        public override void Run()
        {
            Graphics graphics = new Graphics();
            Reader reader = new Reader();

            graphics.SendGraphics();

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
                Console.WriteLine("Enter 4-digit order number you want to send: ");

                int temp = Int32.Parse(reader.AskOrdernumber());
                string ordernum = temp.ToString();

                int check = 0;
                var lines = File.ReadLines(Globals.orderCsv);
                List<string> newlines = new List<string>();

                foreach (string line in lines) //lukee rivi kerrallaan kunnes löytää tilausnumeroa vastaavan rivin, joilloin muuttaa sen statuksen
                {
                    string[] data = line.Split(';');
                    string status = data[15];

                    if (data[0] == ordernum)
                    {
                        status = status.Replace(data[15], "Sent");
                        Console.WriteLine("Order {0} has now been sent.", ordernum);
                        check++;
                    }
                    data[15] = status;
                    string newline = string.Join(";", data);
                    newlines.Add(newline);
                }
                if (check == 0)
                {
                    Console.WriteLine("Order number does not match any orders.");
                    Console.WriteLine("\nPress anything to exit.");
                    Console.ReadLine();
                }
                else
                {
                    File.WriteAllLines(Globals.orderCsv, newlines.ToArray());
                    Console.WriteLine("\nPress anything to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}