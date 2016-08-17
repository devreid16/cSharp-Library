using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoes =
                new List<string>
            {
                "Tennis",
                "Flat",
                "Hi-heeled",
                "Wedges",
                "Boots"
            };

            for (var s = 0; s <= 4; s++ )
            {
                var name = shoes[s];
                Console.Write($"Shoe Type: { shoes[s]} - ");
               
            }
            Console.ReadLine();
        }
    }
}
