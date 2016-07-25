using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    //make person class as parent with 4/6 properties, create 3 subclasses off of Person class
    //
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Nurse
    {
        public int Patients { get; set; }
        public string License { get; set; }
        public bool OnDuty { get; set; }
        public int MyProperty { get; set; }
    }
}
