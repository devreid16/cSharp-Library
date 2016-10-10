using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        //Fibonacci Sequence
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Fibonacci:");
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();



        }
    }
}
