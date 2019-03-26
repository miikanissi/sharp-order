using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Graphics
    {
        public void MenuGraphics()
        {
            // text center help: https://stackoverflow.com/questions/21917203/how-do-i-center-text-in-a-console-application
            // console color help: https://www.dotnetperls.com/console-color

            Console.Clear();
            Console.WriteLine(Globals.linegraph); Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("             _______    ______      _______          _______      ______   _        __        _   ___    _       ");
            Console.WriteLine("            |  ___  |  | _____|    |  ___  \\        |  ___  \\    / ____ \\  \\\\      /  \\      //  |   \\  | |       ");
            Console.WriteLine("            | |___| |  | |____     | |   | |        | |   | |   | /    \\ |  \\\\    / /\\ \\    //   | |\\ \\ | |         ");
            Console.WriteLine("            |  _   _|  |  ____|    | |   | |        | |   | |   | |____| |   \\\\  / /  \\ \\  //    | | \\ \\| |          ");
            Console.WriteLine("            | | \\ \\    | |____     | |___| |        | |___| |   |  ____  |    \\\\/ /    \\ \\//     | |  \\   |        ");
            Console.WriteLine("            |_|  \\_\\   |______|    |_______/        |_______/   |_|    |_|     \\_/      \\_/      |_|   \\__|        ");
            Console.ResetColor();
            Console.WriteLine("\n" + Globals.linegraph);
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            string teksti6 = "SHARP ORDER SERVICE"; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti6.Length / 2)) + "}", teksti6));
            Console.ResetColor();
            Console.WriteLine("\n");
            string header  = "Welcome to Red Dawns Sharp Order service\n"; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (header.Length / 2)) + "}", header));
            string teksti1 = "1. Order             "; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti1.Length / 2)) + "}", teksti1));
            string teksti2 = "2. Storage           "; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti2.Length / 2)) + "}", teksti2));
            string teksti3 = "3. Order status      "; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti3.Length / 2)) + "}", teksti3));
            string teksti4 = "4. Send order(admin) "; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti4.Length / 2)) + "}", teksti4));
            string teksti5 = "0. Exit              "; Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (teksti5.Length / 2)) + "}", teksti5));

        }
        public void OrderGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string s = "ORDER";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
        public void ContactinfoGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Enter your contact information below:\n");
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
        public void ThanksGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nThank you for your order.\n");
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
        public void StorageGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string d = "STORAGE AMOUNT";
            Console.SetCursorPosition((Console.WindowWidth - d.Length) / 2, Console.CursorTop);
            Console.WriteLine(d);
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
        public void SendGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string g = "SEND ORDER";
            Console.SetCursorPosition((Console.WindowWidth - g.Length) / 2, Console.CursorTop);
            Console.WriteLine(g);
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
        public void StatusGraphics()
        {
            Console.Clear();
            Console.WriteLine(Globals.linegraph);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string f = "ORDER STATUS";
            Console.SetCursorPosition((Console.WindowWidth - f.Length) / 2, Console.CursorTop);
            Console.WriteLine(f);
            Console.ResetColor();
            Console.WriteLine(Globals.linegraph);
        }
    }
}
