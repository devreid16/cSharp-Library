using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
     class Program
     {
          static void Main(string[] args)
          {

               //Console.WriteLine("Please type something and press the Enter key: ");
               //string userValue;

               //userValue = Console.ReadLine();
               //Console.WriteLine("You typed: " + userValue);


               //Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
               //string userValue;

               //userValue = Console.ReadLine();
               //if (userValue == "1")
               //{
               //     Console.WriteLine("You won a new Car!");
               //     Console.ReadLine();
               //}
               //else if (userValue == "2")
               //{
               //     Console.WriteLine("You won a new Bike!");
               //     Console.ReadLine();
               //}
               //else if (userValue == "3")
               //{
               //     Console.WriteLine("You won a Gold Fish!");
               //     Console.ReadLine();
               //}
               //else
               //{
               //     Console.WriteLine("Sorry, You didn't win!");
               //     Console.ReadLine();
               //}

               //simplified code (refactored)              

               Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");

               string userValue = Console.ReadLine();
               //string message = "";

               //if (userValue == "1")
               //     message = "You won a new Car!";
               //else if (userValue == "2")
               //     message = "You won a new Bike!";
               //else if (userValue == "3")
               //     message = "You won a Gold Fish!";
               //else
               //     message = "Sorry, You didn't win!";                   

               //Console.WriteLine(message);

               string message = (userValue == "1") ? "boat" : "strand of lint";
               Console.WriteLine("You won a {0}", message);

               Console.ReadLine();
          }
     }
}
