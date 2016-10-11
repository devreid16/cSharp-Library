using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        //enumerations are basically a datatype that allow only a small list of possibilities
        //makes code more reliable. 

        static void Main(string[] args)
        {
            //constrained to only offer viable colors; "ConsoleColor" is an enumeration
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Console.WriteLine("Hello World");

            Console.WriteLine("Type in a super hero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            // if enum.tryparse userValue, "true" says ignore case, if successful parse, 
            //output to myValue variable

            //angle brackets indicate generic type; put datatype in angle brackets
            //three paramerters: string, ignore case, output parameter-sent from method to caller
            //tryparse returns true or false, parsed enum sent out to output parameter
            
            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");
            }



            Console.ReadLine();

        }
    }


    //create our own enumeration
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern

    }
}
