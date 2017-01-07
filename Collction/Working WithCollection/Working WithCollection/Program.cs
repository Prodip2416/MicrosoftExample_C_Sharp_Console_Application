using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Working_WithCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "4TWed";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "BMW";
            car2.Model = "BMW-2017";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Title = "Microsoft web service XML";
            b1.Author = "Robert Tabor";
            b1.ISBN = "00-0000000-0002222";

            //ArrayList are dynamically sized
            // cool features for this

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach(Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */
            // How to use List Item,,,

            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach(Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            // Dictionary(Tkey,TString),,,

            Dictionary< string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);

            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }

    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }

}
