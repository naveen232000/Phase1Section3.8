using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._8
{
    internal class Program
    {
        public static void DateHandel()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Handeling Dates");
            Console.WriteLine("Date with Time : " + now.ToString());
            Console.WriteLine("Long Date : " + now.ToLongDateString());
            Console.WriteLine("Short Date : " + now.ToShortDateString());
            Console.WriteLine("Long Time : " + now.ToLongTimeString());
            Console.WriteLine("Short Time : " + now.ToShortTimeString());
            Console.WriteLine("Kind : " + now.Kind);
            Console.WriteLine("Date : " + now.Date);
            Console.WriteLine("Month : " + now.Month);
            Console.WriteLine("Year : " + now.Year);
            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minutes : " + now.Minute);
            Console.WriteLine("Time Of Day : " + now.TimeOfDay);
            Console.WriteLine("hh : mm tt : " + now.ToString("hh:mm:ss tt"));
            Console.WriteLine("hh : mm tt : " + now.ToString("MMM yyy dd"));
            Console.WriteLine("\nFormatted custom date strings:");
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.ToString("y"));


            Console.WriteLine("\nAdding 5 days to today:" + now.AddDays(5).ToShortDateString());



            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31);
            Console.WriteLine("\nOperatores in Date : " + dt1 + " & " + dt2);
            Console.WriteLine("Sub : " + (dt2 - dt1)); //377.05:10:20
            Console.WriteLine("Equals : " + (dt1 == dt2)); //False
            Console.WriteLine("NotEquals : " + (dt1 != dt2)); //True
            Console.WriteLine("GreaterThen : " + (dt1 > dt2)); //False
            Console.WriteLine("lessThen : " + (dt1 < dt2)); //True
            Console.WriteLine("GTEquals : " + (dt1 >= dt2)); //False
            Console.WriteLine("LTEquals : " + (dt1 <= dt2));//True
        }
        static void Main(string[] args)
        {
            DateHandel();
            Console.ReadLine();
        }
    }
}
