using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();

            ////set properties-not creating "new" instance, just using the myCar instance we created

            //Car myOtherCar = myCar;

            //Car myThirdCar = new Car("Toyota", "Camry", 2007, "Grey");

            //Car.MyMethod();

            Student myStudent = new Student();
        }        
    }

    //public class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public int Year { get; set; }
    //    public string Color { get; set; }
    //    public double OriginalPrice { get; set; }

        //Constructor
    //    public Car()
    //    {
    //        //you could use data from database, config file, etc.
    //        //we hardcode here

    //        this.Make = "Nissan";
    //    } 

        //Constructor
    //    public Car(string make, string model, int year, string color)
    //    {
    //        Make = make;
    //        Model = model;
    //        Year = year;
    //        Color = color;
    //    }

    //    public static void MyMethod()
    //    {

    //    }

        public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }

        //public Student()
        //{
        //    //this.FName = "James";
        //    //this.LName = "Brown";

        //    //Console.WriteLine("His name is: {0} {1}", FName, LName);
        //    //Console.ReadLine();
        //}

            //Constructor
        public Student()
        {
            this.FName = "James";
            this.LName = "Brown";
            this.Grade = 12;
            this.School = "High School";

            Console.WriteLine("{0} {1} is in {2} grade at {3}", FName, LName, Grade, School);
            Console.ReadLine();

        }



        
    }

   
    

}
