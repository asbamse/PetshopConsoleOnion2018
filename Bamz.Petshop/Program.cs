using System;
using System.Globalization;

namespace Bamz.Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MyCultureInfo = new CultureInfo("de-DE");
            string MyString = "12/06/2008 23:13:42";
            DateTime MyDateTime = DateTime.Parse(MyString, MyCultureInfo);
            Console.WriteLine(MyDateTime);
            Console.ReadLine();
        }
    }
}
