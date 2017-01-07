using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varsityInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Varsity Information:");
            Console.WriteLine("<<<<<<<<<<<<------------->>>>>>>>>>>>>>>>");

            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name:");
            string myLastName = Console.ReadLine();

            Console.Write("Type your varsity ID: ");
            string myId = Console.ReadLine();

            Console.Write("Type your varsity name: ");
            string myVarsityName = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Hello, " + myFirstName);
            Console.WriteLine("Your Full Name: " + myFirstName +" "+ myLastName);
            Console.WriteLine("Id : " + myId);
            Console.WriteLine("Varsity Name: " + myVarsityName);
            Console.ReadLine();
        }
    }
}
