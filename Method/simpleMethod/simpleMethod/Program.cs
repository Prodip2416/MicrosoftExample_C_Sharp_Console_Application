using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Reversestring();
            Console.ReadLine();
        }
        static void Reversestring()
        {
            string message = "Helllo World!";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach(char item in messageArray)
            {
                Console.Write(item);
            }
        }
    }
}
