using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal , IMilkableAnimal
    {
        public Cow()
        {
            Name = "Cow";
            Sound = "Cow says Moo!";
            NoOfLegs = 4;
        }
        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

    }
}