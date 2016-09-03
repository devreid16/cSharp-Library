using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
     class Program
     {
          static void Main(string[] args)
          {

               int x, y, a, b;

               //assignment operators
               x = 3;
               y = 2;
               a = 1;
               b = 0;

               //math operators

               //addition operator
               x = 3 + 4;

               //subtraction operator
               x = 4 - 3;


               //multiplication operator
               x = 10 * 5;

               // ";" used to end a statement, declaration, expression

               //conditional AND
               if ((x > y) && (a > b))
               {

               }

               //conditional OR
               if ((x > y) || (a > b))
               {

               }
               //conditional operator

               string message = (x == 1) ? "Car" : "Boat";

               //member access and method invocation
               Console.WriteLine("Hi");
          }
     }
}
