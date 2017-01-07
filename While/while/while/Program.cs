using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
           bool displayBool = true;
            while (displayBool)
            {
                 displayBool = MainMenu();           
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a option:");
            Console.WriteLine("1) Print Numbers.");
            Console.WriteLine("2) Guessing Games.");
            Console.WriteLine("3) Exit.");

            string result = Console.ReadLine();

            if(result == "1")
            {
                printNumber();
                return true;
               
            }
            else if(result =="2")
            {
                GuessingGame();
                return true;
                
            }
            else if(result=="3")
            {
               return false;
            }
            else
            {
                MainMenu();
                return true;
            }
        }
        private static void printNumber()
        {
            Console.Clear();
            Console.WriteLine("printNumber!");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter <= result )
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("GuessingGame!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guesses a number between 1 to 10.");
                string result = Console.ReadLine();
                guesses++;
                if(result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
            while (incorrect);
            {
                Console.WriteLine("Correct!. it took you {0} guesses.",guesses);
            }
            Console.ReadLine();
        }
    }
}
