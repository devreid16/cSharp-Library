using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            ////variable to hold string
            //string Str, ReversedStr = "";

            ////Ask for and accept user input for string 
            //Console.Write("Enter A String : ");
            //Str = Console.ReadLine();

            ////Index of string length
            //for (int i = Str.Length - 1; i >= 0; i--)
            //{
            //    //index of reversed string to print out
            //    ReversedStr = ReversedStr + Str[i];
            //}

            ////print reversed string to console
            //Console.WriteLine("Reversed string:  {0}", ReversedStr);
            //Console.ReadLine();


            //string name = "Eleven Fifty"; 
            //string RevStr = "";

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    RevStr = RevStr + name[i];
            //}
            //Console.WriteLine("Name Reversed: {0}", RevStr);
            //Console.ReadLine();


            string Str = "";
            string revStr = "";

            Console.WriteLine("Enter a string:");
            Str = Console.ReadLine();

            for(int i = Str.Length - 1; i >= 0; i--)
            {
                revStr = revStr + Str[i];
            }

            Console.WriteLine("Reversed string: {0}", revStr);
            Console.ReadLine();
        }       
        
    }    
}
