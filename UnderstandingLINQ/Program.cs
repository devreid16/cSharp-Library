using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> myCars = new List<Car>()
            {
                //collection initializer syntax
                new Car() {Make = "BMW", Model = "550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009 },
                new Car() {Make = "Toyota", Model = "4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010 },
                new Car() {Make = "BMW", Model = "745li", Color=CarColor.Black, StickerPrice=75000, Year=2008 },
                new Car() {Make = "Ford", Model = "Escape", Color=CarColor.Red, StickerPrice=25000, Year=2008 },
                new Car() {Make = "BMW", Model = "55i", Color=CarColor.Black, StickerPrice=57000, Year=2010 }
            };

            //LINQ(Language Integrated Query) statement to display only BMW's
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2010  //&& logical "and"
            //           //select car;
            //           select new { car.Make, car.Model, car.Year };


            //sort cars
            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;

            //using the Method syntax
            //use where with Lambda expression (give it p(car) returning all cars where the
            //year is 2010
            //var _bmws = myCars.Where(p => p.Year == 2010).Where(p => p.Make == "BMW");


            //var _orderedCars = myCars.OrderByDescending(p => p.Year);


            var sum = myCars.Sum(p => p.StickerPrice);

            //using "var" implicit type keyword, allowing Compiler to determine datatype; 
            //allows us to ignore types
            //*changed foreach to look in var bmws
            // foreach(var car in _orderedCars)            
            //     Console.WriteLine("{0} - {1} - {2}", car.Make, car.Model, car.Year);

            Console.WriteLine(sum);
                Console.ReadLine();
            
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }


    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }
}
