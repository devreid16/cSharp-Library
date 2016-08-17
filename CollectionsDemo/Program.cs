using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string list of favorite fruits
            //var fruits = new List<string>();
            //    fruits.Add("Cherries");
            //    fruits.Add("Grapes");
            //    fruits.Add("Bananas");
            //    fruits.Add("Peaches");
            //    fruits.Add("Apples");
            
            // //set x counter to zero, compare counter to number of fruits listed, as long as there are
            // //more fruits add 1 to counter
            //for (var x = 0; x < fruits.Count; x++)
            //{
            //    Console.WriteLine(fruits[x]); //set variable food equal to the current fruit using the index
               
            //}

            //for (var x = 0; x < fruits.Count; x++)
            //{
            //    Console.WriteLine(fruits); //print list of foods using interpolation
            //    Console.ReadLine(); //pause screen to read
            //}

            string[] friend = { "Norma", "Sarah", "BettySue", "Donna" };

            foreach(string name in friend)
            {
                Console.WriteLine(name);                
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            
        }
    }
}
