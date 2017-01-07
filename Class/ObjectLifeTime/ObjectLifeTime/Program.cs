using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            /*
          myCar.Make = "Oldmobile";
          myCar.Model = "Cutles Supreme";
          myCar.Year = 1886;
          myCar.Color = "Silver";
             */

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            Car myOldCar;
            myOldCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOldCar.Make,
                myOldCar.Model,
                myOldCar.Year,
                myOldCar.Color);

            myOldCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
              myOldCar.Make,
              myOldCar.Model,
              myOldCar.Year,
              myOldCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        
        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make,string model,int year,string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        

    }
}
