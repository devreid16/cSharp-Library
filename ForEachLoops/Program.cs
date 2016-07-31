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
            //Console.ReadLine();


            //foreach to print characters in a name
            string fullName = "Angie Reid";  //variable for name
            foreach (char ch in fullName)  //loop through name getting each character
            {
                Console.WriteLine("fullName : {0}", ch); //write each character on a line               
            }
            Console.ReadLine();
        }
    }
}
