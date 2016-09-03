using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
     class Program
     {
          static void Main(string[] args)
          {
               //Declare size of the array - 5 elements in array
               //int[] numbers = new int[5];

               //numbers[0] = 4;
               //numbers[1] = 3;
               //numbers[2] = 2;
               //numbers[3] = 1;
               //numbers[4] = 0;

               ////use length to get the size of the array.
               //Console.WriteLine(numbers.Length);
               //Console.Read();

               ////ToString has integers baked in
               //Console.WriteLine(numbers[1].ToString());
               //Console.ReadLine();

               /*you don't set array size, you give the numbers 
               int[] numbers = new int[] {5, 4, 3, 2, 1, 0 };

               console.writeline(numbers[1].tostring());
               console.readline();
               */

               /*
               string[] names = new string[] { "Paul", "George", "Ringo", "John" };

               foreach (string name in names)
               {
                    Console.WriteLine(name);
               }
               Console.ReadLine();
               */

               //char array example using long string

               string zig = "You can get what you want out of life, " +
                    "if you help other people get what they want.";

               char[] charArray = zig.ToCharArray();
               Array.Reverse(charArray);

               foreach (char zigChar in charArray)
               {
                    //using Write you get all on one line, instead of each on a separate line.
                    Console.Write(zigChar);
               }
               Console.ReadLine();

          }
     }
}
