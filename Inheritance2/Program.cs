using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //make person class as parent with 4/6 properties, create 3 subclasses off of Person class
   
    class Program
    {
        public class Nurse
        {
            public int Patient { get; set; }
            public string Person { get; set; }
            public bool OnDuty { get; set; }
            public int Role { get; set; }
        }

        public class Person : Nurse
        {

        }

        public class Role : Nurse
        {

        }

        public class Patient : Nurse
        {

        }
        static void Main(string[] args)
        {
        }
    }

    
}
