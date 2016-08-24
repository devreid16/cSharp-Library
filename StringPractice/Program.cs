using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {           
        //Accept string name and display new string
        static void Main(string[] args)
        {
            //string firstName = "Sue";
            //string lastName = "Smith";

            //Console.WriteLine("Name:" + firstName + " " + lastName);
            //Console.ReadLine();

            //Console.WriteLine("Please enter a new name: ");
            //firstName = Console.ReadLine();

            //Console.WriteLine("New name:" + firstName + " " + lastName);

            //Console.ReadLine();

            string herName = "Ally";
            string herLastName = "McGraw";

            Console.WriteLine("Name: " + herName + " " + herLastName);
            Console.ReadLine();

            Console.WriteLine("Enter a new name: ");

            herName = Console.ReadLine();

            Console.WriteLine("New Name: " + herName + " " + herLastName);
            Console.ReadLine();
            

        }      

        
    }
}
