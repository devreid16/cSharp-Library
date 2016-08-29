using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
     class Program
     {
          static void Main(string[] args)
          {
               //calculate value of principle plus interest

               decimal interestPaid;
              
               //interestPaid = principal * (interest / 100);

               //decimal total = principal + interestPaid;

               Console.WriteLine("Enter Principle: ");

               string principalInput = Console.ReadLine();

               decimal principal = Convert.ToDecimal(principalInput);

               //principal can't be negative
               if (principal < 0)
               {
                    Console.WriteLine("Principal cannot be negative");
                    principal = 0;
               }
               //Enter the interest rate
               Console.WriteLine("Enter the interest Rate: ");

               string interestIntput = Console.ReadLine();

               decimal interest = Convert.ToDecimal(interestIntput);

               //make sure interest is not negative
               if (interest < 0)
               {
                    Console.WriteLine("Interest cannot be negative");
                    interest = 0;
               }

               interestPaid = principal * (interest / 100);

               decimal total = principal + interestPaid;

               //output result
               Console.WriteLine(); //skip line
               Console.WriteLine("Principal = " + principal);
               Console.WriteLine("Interest = " + interest + "%");
               Console.WriteLine(); //skip line
               Console.WriteLine("Interest paid = " + interestPaid);
               Console.WriteLine("Total = " + total);

               //view result
               Console.Read();
          }
     }
}
