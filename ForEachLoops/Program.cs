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
            //string[] family = { "Tony", "Justin", "Sydney", "Molly", "Tandy" }; 
            //                                                           // Loop over strings
            //foreach (string name in family)
            //{
            //    Console.WriteLine(name); //prints each name 
            //}
            ////Console.ReadLine();


            ////foreach to print characters in a name
            //string fullName = "Angie Reid";  //variable for name
            //foreach (char ch in fullName)  //loop through name getting each character
            //{
            //    Console.WriteLine("fullName : {0}", ch); //write each character on a line               
            //}
            //Console.ReadLine();

            //integer arrays

               //int[] ages = new int[3];
               
               //     ages[0] = 7;
               //     ages[1] = 10;
               //     ages[2] = 13;
               //foreach(var age in ages)
               //{
               //     Console.WriteLine(age);
               //}
               //Console.ReadLine();
               
               //int[] ages = {7, 10, 13};
               //foreach (int age in ages)
               //{
               //     Console.WriteLine(age);
               //}
               //Console.ReadLine();

               //Reversed String Practice

               string name = "Justin Reid";
               string revStr = "";

               for (int i = name.Length-1; i >= 0; i--)
               {
                    revStr = revStr + name[i];
               }
               Console.WriteLine("Reversed Name: {0}", revStr);
               Console.ReadLine();


        }
    }
}
