using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        //"k" is a variable of the class itself and referred to as a field
        //private means it's not accessible outside the class; static means it's accessible to all
        //instances of the class, methods, fields, properties must also be static
       // private static string k = "";

        static void Main(string[] args)
        {

            ////"j" is defined outside the codeblock, so we can access it inside and outside the codeblock
            //string j = "";

            //for(int i = 0; i < 10; i++)
            //{
            //    j = i.ToString();
            //    k = i.ToString();
            //    Console.WriteLine(i);


            //    if (i == 9)
            //    {
            //        //"l" only exist inside this codeblock
            //        string l = i.ToString();
            //    }

            //  //  Console.WriteLine("l: " + l);
            //}

            ////"i" is defined inside the for statement, so we can't access it
            ////Console.WriteLine(i);

            //Console.WriteLine("Outside of the for: " + j);
            //// Console.WriteLine("k: " + k);

            ////call helperMethod
            //helperMethod();


            Car car = new Car();

            car.DoSomething();





            Console.ReadLine();           
        }

        //static void helperMethod()
        //{
        //    Console.WriteLine("k from the helperMethod: " + k);
        //}
    }

    class Car
    {
        //When something is public use CamelCase, uppercase first; applies to variables also
        public void DoSomething()
        {
            //presentation layer code usually would not do this
            Console.WriteLine(helperMethod());

        }

        //private typically use lowercase letter first; applies to variables also
        private string helperMethod()
        {
            return "Hello Wold!";
        }
    }
}
