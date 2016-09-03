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
               //string myValue = superSecretFormula("World!");
               string myValue = superSecretFormula("Sunshine!");
               Console.WriteLine(myValue);
               Console.ReadLine();


          }


          private static string superSecretFormula()
          {
               //some code
               return "Hello World";
          }

          private static string superSecretFormula(string name)
          {
               return string.Format("Hello {0}", name);
          }
     }
}
