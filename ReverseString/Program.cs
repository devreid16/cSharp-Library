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
            //variable to hold string
            string Str, ReversedStr = "";

            //Ask for and accept user input for string 
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();

            //Index of string length
            for (int i = Str.Length - 1; i >= 0; i--)
            {
                //index of reversed string to print out
                ReversedStr = ReversedStr + Str[i];
            }

            //print reversed string to console
            Console.WriteLine("Reversed string:  {0}", ReversedStr);
            Console.ReadLine();

        }       
        
    }    
}
