using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decesions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's big giveaway.");
            Console.Write("Choose a door:1,2 or 3: ");
            string userInput = Console.ReadLine();

            string message = "";
            if(userInput=="1")
            {
                message = "You won a car!";
            }
            else if(userInput=="2")
            {
                message = "You won a boat!";
            }
            else if(userInput=="3")
            {
               message = "You won a cat!";
            }
            else
            {
             message = "Sorry, We did't understand!";
             message += "You Lose.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
