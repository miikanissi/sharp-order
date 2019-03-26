using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public abstract class MainMenu //Abstract class which Run() method can be overriden. 
    {
        public string Command { get; set; }

        public abstract void Run();
    }
}
