using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            animal.Name = "Generic Animal";
            animal.SayName();            
            
            Bear winnie = new Bear();
            winnie.Name = "Winne The Pooh";
            winnie.AmountOfHoneyEaten = 1000;
            winnie.SayName();

            Rabbit Buggs = new Rabbit();
            Buggs.Name = "Buggs Bunny";
            Buggs.NumberOfBabies = 52;
            Buggs.SayName();

            Console.WriteLine(Buggs.Name, Buggs.NumberOfBabies);
            Console.ReadLine();
        }
    }
    
    //For Abstract classes you can't make object from it.  You can use and inherit from it,
    //but you can't make a copy of it. 

    public class Animal
    {
        //properties
        public string Name { get; set; }

        //methods public void doesn't return anything
        //the word virtual allows you to override in other classes
        public virtual void SayName()
        {
            Console.WriteLine("I am an animal.");
        }
    }

    //subclass inherits uses all the properties of base Animal class
    public class Bear : Animal
    {
        //property of Bear class only
        public int AmountOfHoneyEaten { get; set; }

        //method
        public override void SayName()
        {
            Console.WriteLine("I am a bear");
        }
    }

    //one property in the "Rabbit" class inheriting from base class "Animal"
    public class Rabbit : Animal
    {

        public int NumberOfBabies { get; set; }

        public override void SayName()
        {
            Console.WriteLine("I am a bunny");
        }
    }
}
