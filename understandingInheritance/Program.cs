using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of my car class
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();

        }

        //Helper Method
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }

        abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public abstract string FormatMe();
        }

        //Car is the "Base class"
        class Car : Vehicle
        {
            //public string Make { get; set; }
            //public string Model { get; set; }
            //public int Year { get; set; }
            //public string Color { get; set; }


            //the "virtural" keyword allows you to override the method if you choose"
            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} - {3}",
                    this.Make,
                    this.Model,
                    this.Color,
                    this.Year);
            }

        }

        //Inheritance "truck is a 'type' of Car.  It is the 'Derived Class'"
        sealed class Truck : Vehicle
        {
            public int TowingCapacity { get; set; }

            //override of Car FormatMe Method
            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} Towing units",
                    this.Make,
                    this.Model,
                    this.TowingCapacity);
            }
        }

        //Sealed you can't inherit from,  It prevents other instances of classes from being
        //created
    }
}
