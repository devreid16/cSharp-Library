using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {      
        
        static void Main(string[] args)
        {

            //Dictionary<int, string> friendRank = new Dictionary<int, string>()
            //{
            //    {12, "Sarah" },
            //    {15, "Norma" },
            //    {8, "BettySue" }
            //};

            //foreach (KeyValuePair<int, string> pair in friendRank)
            //{
            //    Console.WriteLine("{0} {1}", pair.Key, pair.Value);               
            //}
            //Console.ReadLine();

            //Dictionary<string, string> Movies = new Dictionary<string, string>()
            //{
            //    {"2012", "2012" },
            //    {"2000", "A League Of Their Own" },
            //    {"2011", "Bourne Supremacy" },
            //    {"2015", "Creed" }
            //};

            //foreach(KeyValuePair<string, string> pair in Movies)
            //{
            //    Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            //}
            //Console.ReadLine();

            //Dictionary<string, int> friends = new Dictionary<string, int>()
            //{
            //    {"Norma", 15 },
            //    {"Sarah", 12 },
            //    {"BettySue", 8 }
            //};

            //foreach(KeyValuePair<string, int> pair in friends)
            //{
            //    Console.WriteLine("I've known {0} for {1} years", pair.Key, pair.Value);
            //}

            //Console.ReadLine();

            Dictionary<string, int> movies = new Dictionary<string, int>()
            {
                {"Bourne Identity", 2009 },
                {"Bourne Supremacy", 2012 },
                {"Bourne, Ultimatium", 2014 }
            };

            foreach (KeyValuePair<string, int> Pair in movies)
            {
                Console.WriteLine("My favorite movie was {0}" + " in" + " {1}", Pair.Key, Pair.Value);
            }
            Console.ReadLine();


        }
    }
}
