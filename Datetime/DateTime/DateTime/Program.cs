using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
             DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.ToShortDateString());

            //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            // DateTime myBirthday = new DateTime(1994, 5, 16);
            // Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("16/5/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
