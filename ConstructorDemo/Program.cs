using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessClass Zumba = new FitnessClass("Zumba", 500);
            FitnessClass CrossFit = new FitnessClass("CrossFit", 4);
            FitnessClass Kickboxing = new FitnessClass("Kickboxing", 30);
            Console.WriteLine("My second favorite class is {0}", Zumba.Title);
            Console.ReadLine();
        }
    }
    /// <summary>
    /// pretend class is in a separate file
    /// </summary>
    public class FitnessClass
    {
        //Constructor, parameter names are lower case.  One is a property and one is parameter        
        public FitnessClass(string title, int numberOfStudents)
        {
            //Properties(capitals) come first
            this.Title = title;
            this.NumberOfStudents = numberOfStudents;
        }

        //properties
        public string Title { get; set; }
        public int NumberOfStudents { get; set; }        
    }
}

/*Costruction Notes:
///No return type. Don't bring anything back, don't use void
///Name matches name of class.
///Help set defalut values.
///Don't always need the in the class, but create safety
*/