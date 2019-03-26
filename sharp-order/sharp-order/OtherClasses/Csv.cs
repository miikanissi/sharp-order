using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Csv

    {
        public void ReadProductsFromFile(List<Product> productlist)
        {
            string[] csvProduct = System.IO.File.ReadAllLines(Globals.productCsv);
            foreach (string line in csvProduct) 
            {
                Product product = ReadProductFromCsvLine(line);
                productlist.Add(product);
            }
        }

        public Product ReadProductFromCsvLine(string line)
        {
            string[] splitLine= line.Split(',');
            Product product = new Product();
            product.Game = splitLine[0];
            product.Console = splitLine[1];
            product.Price = Double.Parse(splitLine[2]);
            product.Storage = Int32.Parse(splitLine[3]);
            return product;
        }

        public void WriteNewStorage(Product chosenProduct, int tempStorage)
        {
            string newStorage = tempStorage.ToString();
            string[] csvProduct = System.IO.File.ReadAllLines(Globals.productCsv);
            List<string> dataLines = new List<string>();

            foreach (string line in csvProduct) //tekee tuotelistan
            {
                string[] data = line.Split(',');

                string storage = data[3];
                if (data[0] == chosenProduct.Game & data[1] == chosenProduct.Console)
                {
                    storage = storage.Replace(data[3], newStorage);
                }
                data[3] = storage;
                string newline = string.Join(",", data);
                dataLines.Add(newline);
            }
            File.WriteAllLines(Globals.productCsv, dataLines.ToArray());
        }
        public void WriteNewOrder(Order order)
        {
            List<Order> newOrder = new List<Order>
                            {
                            order
                            };
            //Csvhelper
            using (var sw = new StreamWriter(Globals.orderCsv, true))
            {
                var writer = new CsvWriter(sw);
                foreach (Order tieto in newOrder)
                {
                    writer.WriteField(tieto.Ordernumber);
                    writer.WriteField(tieto.Console);
                    writer.WriteField(tieto.Game);
                    writer.WriteField(tieto.Amount);
                    writer.WriteField(tieto.Firstname);
                    writer.WriteField(tieto.Lastname);
                    writer.WriteField(tieto.Phone);
                    writer.WriteField(tieto.Email);
                    writer.WriteField(tieto.Homeaddress);
                    writer.WriteField(tieto.Zipcode);
                    writer.WriteField(tieto.City);
                    writer.WriteField(tieto.Country);
                    writer.WriteField(tieto.Company);
                    writer.WriteField(tieto.Businessid);
                    writer.WriteField(tieto.Date);
                    writer.WriteField(tieto.Status);
                    writer.WriteField(tieto.Price);

                    writer.NextRecord();
                }
            }
        }

        public void ReadCsvOrder(string chosenOrder)
        {
            string[] csvOrder = System.IO.File.ReadAllLines(Globals.orderCsv);

            foreach (string line in csvOrder) 
            {
                string[] data = line.Split(','); 

                if (data[0] == chosenOrder)
                {
                    dataRivit.Add("Order number: " + data[0]);
                    dataRivit.Add("Console: " + data[1]);
                    dataRivit.Add("Game: " + data[2]);
                    dataRivit.Add("Amount: " + data[3] + "units");
                    dataRivit.Add("First Name: " + data[4]);
                    dataRivit.Add("Last Name: " + data[5]);
                    dataRivit.Add("Phone: " + data[6]);
                    dataRivit.Add("Email: " + data[7]);
                    dataRivit.Add("Home Address : " + data[8]);
                    dataRivit.Add("Zip Code: " + data[9]);
                    dataRivit.Add("City: " + data[10]);
                    dataRivit.Add("Country: " + data[11]);
                    dataRivit.Add("Company: " + data[12]);
                    dataRivit.Add("Business ID: " + data[13]);
                    dataRivit.Add("Order Sent: " + data[14]);
                    dataRivit.Add("Order Status: " + data[15]);
                    dataRivit.Add("Total Price: $" + data[16]);
                }
            }
        }
        public void PrintCsvOrder()
        {
            if (dataRivit.Count == 0)
            {
                Console.WriteLine("Can not find an order.");
            }
            else
            {
                Console.WriteLine("Your Order: \n");
                foreach (string line in dataRivit)
                {

                    Console.WriteLine(line);

                }
            }
        }

        List<string> dataRivit = new List<string>(); 
    }
}
