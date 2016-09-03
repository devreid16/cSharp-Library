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

               //string[] friend = { "Norma", "Sarah", "BettySue", "Donna" };

               //foreach(string name in friend)
               //{
               //    Console.WriteLine(name);                
               //}
               //Console.WriteLine("Press Enter to Exit");
               //Console.ReadLine();

               //Fixed Value Array : 
               //double[] doublesArray = {}5,2, 7, 3.5. 6.5, 8, 1, 9, 1, 3;

               //VariableAverageArray
               //Console.WriteLine("Enter the number of values to average");

               //string numElementsInput = Console.ReadLine();

               //int numElements = Convert.ToInt32(numElementsInput);
               //Console.WriteLine(); //skip line

               ////declare array of that size

               //double[] doublesArray = new double[numElements];
                              
               //for (int i = 0; i < numElements; i++)
               //{
               //     Console.WriteLine("Enter a double #" + (i + 1) + ":");
               //     string val = Console.ReadLine();

               //     //add to array
               //     double value = Convert.ToDouble(val);
               //     doublesArray[i] = value;                    
               //}

               ////accumulate values 

               //double sum = 0;

               //for (int i = 0; i < numElements; i++)
               //{
               //     sum = sum + doublesArray[i];
               //}

               ////calculate average
               //double average = (sum / numElements);

               //Console.WriteLine(); //skip line
               //Console.WriteLine(average + " is the average of (" + doublesArray[0]);

               //for (int i = 1; i < numElements; i++)
               //{
               //     Console.WriteLine("+" + doublesArray[i]);
               //}

               //Console.WriteLine(") / " + numElements);

               //Console.WriteLine("Press Enter to exit");
               //Console.Read();


               //List collection
               List<int> smallPrimeNumbers = new List<int> { 2, 3, 5, 7, 11, 13 };

               int numberElements = smallPrimeNumbers.Count;
               Console.WriteLine(numberElements);
               Console.ReadLine();
          }
    }
}
