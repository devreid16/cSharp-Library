using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        enum Fitness
        {
            Kickboxing,
            Refit,
            Running,
            Walking,
            Treadmill,
            Elliptical,
            Weights
        }

        static void Main(string[] args)
        {         
            Fitness FavWorkout = Fitness.Kickboxing;

            Console.WriteLine($"My favorite fitness activity is: { FavWorkout} .");
            Console.ReadLine();
        }
    }
}

 