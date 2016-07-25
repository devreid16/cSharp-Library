using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals Kangeroo = new Animals("Kangaroo");
            Animals Kangeroo2 = new Animals("Kangaroo", "Big One");
            Animals Platypus = new Animals("Playtypus", "Sea Creature");

            Console.WriteLine("My favorite animal is {0}" Kangeroo);   
        }
    }
    
    //When Overloading I can have multiple constructors

    public class Animals
    {
        public string animals { get; set; }

        //constructor number 1
        public Animals(string name)
        {
            this.Name = name;
        }

        //constructor number2
        public Animals(string name, string type)
        {
            this.Name = name;
            this.Type = type;

        }

        //constructor number3
        public Animals(string name, string type, int numberOfLegs)
        {
            this.Name = name;
            this.Type = type;
            this.NumberOfLegs = numberOfLegs;
        }
        //properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfLegs { get; set; }
    }
}
