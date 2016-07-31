using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorialKudvenkat
{

    public class Customer
    {
        //class fields
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public Customer(string FirstName, string Lastname )
        {
            //initialize variables, can also use "this" keyword
            _firstName = FirstName;
            _lastName = Lastname;
        }

        public void PrintFullName()
        {
            Console.WriteLine("FullName = { 0}", _firstName + " " + _lastName);
        }

        //Destructor used to cleanup unneeded resources, can't take parameters and has the tilde (~).  
        //called by CLR
        ~Customer()
        {
        }

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            //create  new instance/object C1 of Customer class; passing in parameters to Constructor
            Customer C1 = new Customer("Sally", "Ride");
            
        }
    }
}
