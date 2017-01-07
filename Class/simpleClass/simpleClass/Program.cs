using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobiles";
            myCar.Model = "Cutles Suprem";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            // decimal value = DetermineMarkletValue(myCar);
            // Console.WriteLine("{0:C}",value);

            Console.WriteLine("{0:C}",myCar.DetermineMarketValue());
            Console.ReadLine();
        }
        private static decimal DetermineMarkletValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        } 
    }
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal Carvalue;
            if (Year > 1990)
                Carvalue = 10000;
            else
                Carvalue = 1000;

            return Carvalue;
        }

    }
}
