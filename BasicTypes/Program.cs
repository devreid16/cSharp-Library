using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        //String data type demo
        static void Main(string[] args)
        {
        //   string animal = "Dog";
        //   string name = "Nicole";
        //   string activity = "walk";

        //  //  var sentence = $" {name} + {animal} + {activity}";

        //    Console.WriteLine($" {name} takes her {animal} for a {activity}.");
        //      Console.ReadLine();
        //Integer data type demo
            int age = 50;
            double price = 13.56;
            decimal gpa = 3.89m;
            short tot = 566;
            long num = 7;
            byte b = 1;
            char a = 'i';
            bool guess = false;
            float points = 3.578f;

           // Console.WriteLine($"Tony's age is {age} this year.  Sydney has {b} more year of school, and her gpa of {gpa} is fine.");
           // Console.ReadLine();
                        
            Console.WriteLine($"Justin paid {price} for his lunch. His dog is {num} years old.");
            Console.ReadLine();
                        
            Console.WriteLine($"We drove {tot} miles in one day.  They were {guess} is their estimate.");
            Console.ReadLine();
                       
            Console.WriteLine($"Sam's morgage rate is at {points} percent.");
            Console.ReadLine();
        }
    }
   
}

