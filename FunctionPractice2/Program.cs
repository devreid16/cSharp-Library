using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        string fname = "Sam";
        string lname = "Walton";

        public void addNames(string fname, string lname)
        {
            Console.WriteLine("Name: ", fname + " " + lname);
            Console.ReadLine();
        }
    }
}
