using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
     class Program
     {
          static void Main(string[] args)
          {
          }

          string fname = "Angie";
          string lname = "Reid";

          public void DoStuff(string fname, string lname)
          {
               Console.WriteLine("Name: {0} {1}", fname, lname);
               Console.ReadLine();
          }
          
     }
}   
