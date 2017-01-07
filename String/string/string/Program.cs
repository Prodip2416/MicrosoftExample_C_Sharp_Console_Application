using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so called\" life";
            // string myString = "What if i need a \nnew line?";
            //string myString = "Go to Your c:\\ drive";
            //string myString = @"Go to youe c:\ drive.";
            //string myString = string.Format("{0} = {1}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);
            // string myString = string.Format("{0:N}", 123450000);
            //string myString = string.Format("Parcentage : {0:P}", .45);
            //string myString = string.Format("phone number :{0:(####)### ####}", 12345678901);

            // string myString = "That summer we TOOK three access the board.";

            //myString = myString.Substring(6,20);
            // myString = myString.ToUpper();
            // myString = myString.ToLower();
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove(6,15);


            /* tring myString = "";
            for(int i=0; i<100;i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            for(int i=0;i<100;i++)
            {
                myString.Append("--");
                myString.Append(i);
            }


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
