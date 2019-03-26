using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public static class Globals
    {
        public static string linegraph = "________________________________________________________________________________________________________________________";
        public static string dottedlinegraph = ("-----------------------------------------------------------------------------------------------------------------------");
        public static string orderCsv = Directory.GetCurrentDirectory() + @"\tilaus.csv"; 
        public static string productCsv = Directory.GetCurrentDirectory() + @"\tuote.csv"; 
        public static string password = "ketchup123";
    }
}
