using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Constructors_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals Poodle = new Animals("Poodle", 3);
            Animals Maltese = new Animals("Maltese", 2);
            Animals Retriever = new Animals("Retriever", 5);

            //this will print out the "count" then the "dog type"
            Console.WriteLine("Sue has {0} {1} at her farm", Maltese.Count, Maltese.Dog);
            Console.ReadLine();
        }

        public class Animals
        {
            //constructor and parameters
            public Animals(string dog, int count)
            {
                this.Dog = dog;
                this.Count = count; 
            }

            //properties
            public string Dog { get; set; }
            public int Count { get; set; }
        }
    }
}
