using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private LinkedList<Animal> Animals { get; set; }
        public EmydexFarmSystem()
        {
            this.Animals = new LinkedList<Animal>();
        }
        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Animals.AddLast(animal);
            Console.WriteLine(animal.Name + " has entered the Emydex farm");
        }

        //TEST 2
        public void MakeNoise()
        {

            if (Animals.Count > 0)
            {
                foreach (var animal in Animals)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There is no animal in the farm");
            }
            //Test 2 : Modify this method to make the animals talk
        }

        //TEST 3
        public void MilkAnimals()
        {
            int count = 0;

            if (Animals.Count > 0)
            {
                foreach (var animal in Animals)
                {
                    if (animal is IMilkableAnimal)
                    {
                        Console.WriteLine(animal.Name + " was milked!");
                        count++;
                    }
                }
            }

            Console.WriteLine(count == 0 ? "There is no animal in the Farm or Cannot identify the farm animals which can be milked" : "");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            if (Animals.Count > 0)
            {
                foreach (var animal in Animals.ToList())
                {
                    try
                    {
                        Animals.Remove(animal);
                        Console.WriteLine(animal.Name + " has left the farm");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("There are still animals in the farm, farm is not free " + ex.Message);
                    }
                }
            }

            if (Animals.Count == 0)
            {
                Console.WriteLine("Emydex Farm is empty now");
            }
        }
    }
}
