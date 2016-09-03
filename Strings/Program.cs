using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
     class Program
     {
          static void Main(string[] args)
          {
               //use extra "\" to correct C# escape character error and produce the desired format
               //string myString = "Go to your c:\\ drive";
               //string myString = "My \"so called \" life";
               //string myString = "What if I need a \n new line";

               //{0} is the string replacement syntax
               //string myString = string.Format("{0}", "Bonzai");
               //string myString = string.Format("Make: {0} Model: {1}", "BMW", "760li");

               //the ":C" formats the number as US Dollars and Cents
               //string myString = string.Format("{0:C}", 123.45);

               //the ":N" formats the number with commas and decimal
               //string myString = string.Format("{0:N}", 123456789);

               //the ":P" formats the number as a percentage
               //string myString = string.Format("{0:P}", .123);

               //to format a string of numbers, phone, ssn, etc.  *processes right to left
               //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

               /*
               //concatenate string appends to string of numbers
               string myString = "";

               
               for (int i = 0; i < 100; i++)
               {
                    //myString = myString + "--" + i.ToString();

                    //the "+=" takes what's in mystring and appends whats on the righthand side
                    myString += "--" + i.ToString();
               }
               
               */

               /*
               //using StringBuilder method class to improve performance (preferred for a lot of string concatenation
               StringBuilder myString = new StringBuilder();

               for (int i = 0; i < 100; i++)
               {
                    myString.Append("--");
                    myString.Append(i);
               }
               */


               string myString = "  You do what you KNOW how to do, but when you know better you DO better.  ";

               //the 5 is the index position and the 14 is the number of characters to return
               //myString = myString.Substring(5, 14);

               //good to use to compare text input or to make sure takes matches
               //myString = myString.ToUpper();

               //replace spaces with dashes.  Replace allows you to change text
               //myString = myString.Replace(" ", "--");


               //print the length, trim and display length after
               myString = string.Format("Length before: {0} -- After: {1}", 
                    myString.Length, myString.Trim().Length);

               Console.WriteLine(myString);
               Console.ReadLine();
          }
     }
}
