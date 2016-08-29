using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
     class Program
     {
          static void Main(string[] args)
          {
               //calculate value of principle plus interest

               int maxInterest = 50;

               Console.WriteLine("Enter Principle: ");

               string principalInput = Console.ReadLine();

               decimal principal = Convert.ToDecimal(principalInput);

               //principal can't be negative
               if (principal < 0)
               {
                    Console.WriteLine("Principal cannot be negative");
               }
               else
                    //Enter the interest rate
                    Console.WriteLine("Enter the interest Rate: ");

               string interestIntput = Console.ReadLine();

               decimal interest = Convert.ToDecimal(interestIntput);

               //make sure interest is not negative
               if (interest < 0 || interest > maxInterest)
               {
                    Console.WriteLine("Interest cannot be negative or above" + maxInterest);
                    interest = 0;
               }
               else
                    //Enter the number of years
                    Console.WriteLine("Enter the number of years: ");
               string durationInput = Console.ReadLine();

               //convert string input to integer
               int duration = Convert.ToInt32(durationInput);

               //verify input
               Console.WriteLine(); //skip line
               Console.WriteLine("Principal = " + principal);
               Console.WriteLine("Interest = " + interest + "%");
               Console.WriteLine("Duration = " + duration + "years");

               //Loop through years
               int year = 1;
               
               while (year <= duration)
               {
                    decimal interestPaid;
                    interestPaid = principal * (interest / 100);
                    decimal total = principal + interestPaid;
                    principal = principal + interestPaid;
                    principal = decimal.Round(principal, 2);

                    Console.WriteLine(); //skip line
                    Console.WriteLine("Year" + ": " + principal);

                    //skip to next year, last step before returning to top
                    year = year + 1;
               }

               Console.WriteLine("\nPress Enter to exit");
               Console.Read();
          }
     }
}
