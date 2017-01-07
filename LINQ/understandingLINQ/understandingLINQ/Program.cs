using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>
            {
                new Car() {VIN="A1",Make="BMW", Model= "760li" ,StrikyPrice = 1200000,Year=1990 },
                new Car() {VIN="B1",Make="TOYOTA", Model= "888li" ,StrikyPrice = 578768900,Year=1991 },
                new Car() {VIN="C1",Make="BMW", Model= "556" ,StrikyPrice =4875869,Year=1992 },
                new Car() {VIN="A1",Make="BMW", Model= "333li" ,StrikyPrice = 6666000,Year=1993 },
                new Car() {VIN="A1",Make="4TWed", Model= "222li" ,StrikyPrice = 44440000,Year=1994}
            };

            //LINQ Queryy,,,,

            /*
            var bmws = from car in myList
                       where car.Make == "BMW"
                       select car;


            //LINQ Method................

            foreach(var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */


            //Console.WriteLine(myList.Exists(p => p.Model == "222li"));
            //Console.WriteLine(myList.Sum(p => p.StrikyPrice));


            Console.ReadLine();

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StrikyPrice { get; set; }
    }
}
