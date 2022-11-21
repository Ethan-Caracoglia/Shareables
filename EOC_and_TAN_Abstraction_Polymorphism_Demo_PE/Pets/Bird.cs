using Abstraction_Polymorphism_Demo.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Demo
{
    internal class Bird : Pet
    {
        //Identical child contructor
        //type = bird
        public Bird(string name, DateTime birthday)
            : base(name, birthday, "bird")
        {
        }
        
        //"{Name} says SQUAWK!"
        public override void Speak()
        {
            Console.WriteLine(this.Name + " says SQUAWK!");
        }
    }
}
