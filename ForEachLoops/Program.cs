using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] family = { "Tony", "Justin", "Sydney", "Molly", "Tandy" }; 
                                                                       // Loop over strings
            foreach (string name in family)
            {
                Console.WriteLine(name); //prints each name 
            }
            Console.ReadLine();
        }
    }
}
