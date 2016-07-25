using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer data type demo
            int age = 50;            
            decimal gpa = 3.89m;
            short tot = 566;
            double price = 13.56;
            long num = 7;
            byte b = 1;
            char a = 'i';
            bool guess = false;
            float points = 3.578f;

              Console.WriteLine($"Tony's age is {age} this year.  Sydney has {b} more year of school, and her gpa of {gpa} is fine.");
             
              Console.WriteLine($"Justin paid {price} for his lunch. His dog is {num} years old.");
             
              Console.WriteLine($"We drove {tot} miles in one day.  They were {guess} is their estimate.");
            
              Console.WriteLine($"Sam's morgage rate is at {points} percent.");
              Console.ReadLine();
        }
    }
}
