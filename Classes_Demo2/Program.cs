using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Demo2
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Friends is an object in this instance of the Friends class
            Friends myFriend = new Friends();
            myFriend.Name = "Sarah";
            myFriend.YearsKnown = 13;
            myFriend.LikesCoffee = true;
            myFriend.AgeRange = 40;
            myFriend.City = "Zionsville";

            Console.WriteLine("My friend is {0} I've known her {1} years and she lives in {2}.", myFriend.Name, myFriend.YearsKnown, myFriend.City);
            Console.ReadLine();

        }

        public class Friends
        {
            public string Name { get; set; }
            public int YearsKnown { get; set; }
            public bool LikesCoffee { get; set; }
            public int AgeRange { get; set; }
            public string City { get; set; }
        }
    }
}
