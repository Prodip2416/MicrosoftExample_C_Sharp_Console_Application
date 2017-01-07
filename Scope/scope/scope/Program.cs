using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i=0;i<10;i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(j);
            }
            Console.WriteLine("Outside of the for: " +j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();
            Console.ReadLine();
        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod: " + k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }
        private string HelperMethod()
        {
            return "Hello World!";
        }
    }
}
