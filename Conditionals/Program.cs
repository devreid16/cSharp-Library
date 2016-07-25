using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mood condition initially set to 10
            var mood = 10;

            if (mood == 10)
            {
                Console.WriteLine("I feel Awesome!");
            }
            else if (mood > 10)
            {
                Console.WriteLine("That's too good to be true!");
            }
            else
            {
                Console.WriteLine("I hope you feel better soon!");                
            }
            Console.ReadLine();
        }
    }
}
