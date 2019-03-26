using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Order
    {
        public string Ordernumber { get; set; }
        public string Game { get; set; }
        public string Console { get; set; }
        public int Amount { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Homeaddress { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public string Businessid { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
    }
}
