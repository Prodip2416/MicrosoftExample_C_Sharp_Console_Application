using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("What is your name?");
            Console.Write("My first name is: ");
            string myFirstName;
            myFirstName = Console.ReadLine();
            Console.Write("My Last name is : ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
            
        }
    }
}
