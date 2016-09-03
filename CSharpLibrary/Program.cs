using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    class Program
    {       //"For" Loop practice
        static void Main(string[] args)
        {
               //int number = 7;

               //for (var i = 0; i < number; i++)

               //Console.WriteLine(i);
               //Console.ReadLine();

               //int count = 9;

               //for (int c = 0; c < count; c++)

               //Console.WriteLine(c);
               //Console.ReadLine();

               //int students = 8;

               //for (int s = 0; s<students; s++)
               //    Console.WriteLine("Student: {0}", s);
               //    Console.ReadLine();

               //List<string> names = new List<string>
               //{
               //    "Christa",
               //    "Bob",
               //    "Mekelchedeck",
               //    "Susan",
               //};

               //foreach (string name in names)
               //{

               //     Console.WriteLine(name);
               //}
               //Console.ReadLine();

               string[] friends = { "Alec", "Peter", "Chris", "Alex" };
            
                foreach(string friend in friends)
                {
                Console.WriteLine(friend);
                }
            Console.ReadLine();
           
        }

    }

}

