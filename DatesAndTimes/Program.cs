using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
     class Program
     {
          static void Main(string[] args)
          {
               DateTime myValue = DateTime.Now;
               //date and time
               //Console.WriteLine(myValue.ToString());

               //just the date
               //Console.WriteLine(myValue.ToShortDateString());

               //just the time
               // Console.WriteLine(myValue.ToShortTimeString());

               //includes the day 
               //Console.WriteLine(myValue.ToLongDateString());

               //just the time, includes the seconds
               //Console.WriteLine(myValue.ToLongTimeString());

               //**Chaining method calls
               //using date math using AddDays Helper Method form Date methods
               //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

               //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());

               //Console.WriteLine(myValue.AddDays(-2).ToShortDateString());

               //Console.WriteLine(myValue.Month.ToString());

               //using overloaded constructor
               //DateTime myBirthday = new DateTime(1963, 12, 7);
              // Console.WriteLine(myBirthday.ToShortDateString());


               //using Subtract method to determine elapsed time
               DateTime myBirthday = DateTime.Parse("12/7/1963");
               TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
               Console.WriteLine(myAge.TotalDays);
              

               Console.ReadLine();
          }
     }
}
