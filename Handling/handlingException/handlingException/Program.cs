using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handlingException
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                string content = File.ReadAllText(@"C:\Lession\example.txt");
                Console.WriteLine(content);
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine(ex.Message);
            }
                 Console.ReadLine();
        }
    }
}
