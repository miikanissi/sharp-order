using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sharp_order
{
    public class Reader
    {
        public string AskOrdernumber()
        {
            string num = "";
            bool check = true;
            while (check)
            {
                num = Console.ReadLine();
                Regex regex = new Regex(@"^([0-9]{4})$");
                Match match = regex.Match(num);
                if (match.Success)
                {
                    check = false;

                }
                else
                {
                    Console.WriteLine("Enter 4-digit order number.");
                }
            }
            return num;

        }
        public int AskNumber()
        {
            int num;

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter number.");
            }
            return num;
        }
        public string AskText()
        {
            string text = "";
            bool check = true;
            while (check)
            {
                text = Console.ReadLine();
                Regex regex = new Regex(@"^([a-öA-Ö]{2,20})$");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    check = false;

                }
                else
                {
                    Console.WriteLine("Enter input in correct form.");
                }
            }
            return text;
        }
        public string AskTextWithLine()
        {
            string text = "";
            bool check = true;
            while (check)
            {
                text= Console.ReadLine();
                Regex regex = new Regex(@"^([A-ö]-?)*[A-ö]{2,20}$");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    check = false;

                }
                else
                {
                    Console.WriteLine("Enter input in correct form.");
                }
            }
            return text;
        }
        public string AskTextWithLineAndSpace()
        {
            string text = "";
            bool check = true;
            while (check)
            {
                text = Console.ReadLine();
                Regex regex = new Regex(@"^[- +()]*[A-ö][- +()A-ö]*$");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    check = false;

                }
                else
                {
                    Console.WriteLine("Enter input in correct form.");
                }
            }
            return text;
        }
        public void AskContactinfo(Order order)
        {
            Console.Write("First Name: ");
            order.Firstname = this.AskTextWithLine();
            Console.Write("Last Name: ");
            order.Lastname= this.AskTextWithLine();
            Console.Write("Phone: ");
            order.Phone = AskPhone();
            Console.Write("Email: ");
            order.Email = AskEmail();
            Console.Write("Home Address: ");
            order.Homeaddress = AskAddress();
            Console.Write("ZIP code: ");
            order.Zipcode = AskZipcode();
            Console.Write("City: ");
            order.City = this.AskTextWithLineAndSpace();
            Console.Write("Country: ");
            order.Country = AskTextWithLineAndSpace();
            Console.Write("Company: ");
            order.Company = this.AskTextWithLineAndSpace();
            Console.Write("Business ID: ");
            order.Businessid = AskBusinessid();


        }
        private string AskEmail()
        {
            string email = "";
            bool check = true;
            while (check)
            {
                email = Console.ReadLine();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    check = false;

                }
                else
                {
                    Console.WriteLine("Enter email in correct format.");
                }
            }
            return email;
        }
        private string AskBusinessid()
        {
            string businessid = "";
            bool check = true;
            while (check)
            {
                businessid = Console.ReadLine();
                Regex regex = new Regex(@"^([0-9]{7})([-]{1})([0-9]{1})$");
                Match match = regex.Match(businessid);
                if (match.Success)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Enter Business ID in correct format.");
                }
            }
            return businessid;
        }
        private string AskPhone()
        {
            string phone = "";
            bool check = true;
            while (check)
            {
                phone = Console.ReadLine();
                Regex regex = new Regex(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");
                Match match = regex.Match(phone);
                if (match.Success)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Enter phone number in correct format.");
                }
            }
            return phone;
        }
        private string AskZipcode()
        {
            string zipcode = "";
            bool check = true;
            while (check)
            {
                zipcode = Console.ReadLine();
                Regex regex = new Regex(@"^([0-9]{5})$");
                Match match = regex.Match(zipcode);
                if (match.Success)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Enter ZIP code in correct format.");
                }
            }
            return zipcode;
        }
        private string AskAddress()
        {
            string address = "";
            bool check = true;
            while (check)
            {
                address = Console.ReadLine();
                Regex regex = new Regex(@"^(?:\w+\.?,?\s?){1,60}$");
                Match match = regex.Match(address);
                if (match.Success)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Enter Home Address in correct format.");
                }
            }
            return address;
        }
    }
}
