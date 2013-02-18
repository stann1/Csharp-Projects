using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LetterCompany
{
    class LetterCompany
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company name");
            string comName = Console.ReadLine();
            Console.WriteLine("Enter company address");
            string comAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone (format AAABBBCCC, no spaces)");
            string comPhone = Console.ReadLine();
            Console.WriteLine("Enter company fax");
            string comFax = Console.ReadLine();
            Console.WriteLine("Enter company web-site");
            string comSite = Console.ReadLine();

            Console.WriteLine("Enter your first name");
            string manFirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string manLastName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            byte manAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your phone (format AAABBBCCC, no spaces)");
            string manPhone = Console.ReadLine();

            Console.WriteLine("Dear Mr/Ms {0} {1}", manFirstName, manLastName);
            Console.WriteLine("We are pleased to inform you that your company,{0}," + "\n" +
                "with address {1}, phone {2}, fax {3}, website {4}" + "\n" +
                "was chosen as the best employer for 2012, among 100 other companies." + "\n" +
                "You were the only manager of age {5}, from all competitors.", comName, comAddress, comPhone, comFax, comSite, manAge);
            Console.WriteLine("We will contact you soon on {0}, for further details", manPhone);                
        }
    }
}
