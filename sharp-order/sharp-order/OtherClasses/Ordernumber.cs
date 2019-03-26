using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Ordernumber
    {
        public string CreateOrdernumber()
        {
            Random rnd = new Random();
            int tempOrdernumber = rnd.Next(1000, 9999);
            string ordernumber = tempOrdernumber.ToString(); //Luo random numeron ja muuttaa sen stringiksi 


            var lines = File.ReadLines(Globals.orderCsv);
            List<string> newlines = new List<string>();
            bool check = true;
            do
            {
                check = false;
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    while (data[0] == ordernumber)
                    {
                        tempOrdernumber = rnd.Next(1000, 9999);
                        ordernumber = tempOrdernumber.ToString();
                        check = true;
                    }
                }
            }
            while (check == true);

            return ordernumber;
        }
    }
}