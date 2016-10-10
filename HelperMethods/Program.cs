using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
     class Program
     {
          static void Main(string[] args)
          {
               ////string myValue = superSecretFormula("World!");
               //string myValue = superSecretFormula("Sunshine!");
               //Console.WriteLine(myValue);
               //Console.ReadLine();

            //string myValue2 = superSecretFormula2("World");
            string myValue2 = superSecretFormula2("Developer");
            Console.WriteLine(myValue2);
            Console.ReadLine();

          }

          //private static string superSecretFormula()
          //{
          //     //some code
          //     return "Hello World";
          //}

          //private static string superSecretFormula(string name)
          //{
          //     return string.Format("Hello {0}", name);
          //}

        private static string superSecretFormula2()
        {
            //some cool stuff here
            return "Hey There!";
        }

        private static string superSecretFormula2(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
     }
}
