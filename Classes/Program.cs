﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is an object
            Car angiesCar = new Car();           
            angiesCar.Make = "Toyota";
            angiesCar.Year = 2007;
            angiesCar.PrintYear();
            //{0} goes to the object to the right on the same line
            Console.WriteLine("Angie owns a {0} {1}", angiesCar.Year, angiesCar.Make);
            

            Car seansCar = new Car();
            seansCar.Make = "LandRover";
            seansCar.Year = 2016;
            angiesCar.PrintYear();

            Console.WriteLine("Sean's car is a {0}", seansCar.Make);
            Console.ReadLine();


            Car jensCar = new Car();
        }
    }

    public class Car //this is the cookie cutter
    {
        //properties
        public int Year { get; set; }
        public string Make { get; set; }
        public bool IsAutomatic { get; set; }
        public int VIN { get; set; }

        //method
        public void PrintYear()
        {
            Console.WriteLine("The year is {0}", Year);           
        }

    }
}