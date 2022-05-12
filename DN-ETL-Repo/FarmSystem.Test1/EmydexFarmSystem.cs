using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        //Added a queue to keep animals in farm - FIFO style
        Queue<Animal> farm = new Queue<Animal>();
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            //Use GetType().name to display current class type
            Console.WriteLine(animal.GetType().Name + " has entered the Emydex farm");
            
            //Add animal to farm/queue 
            farm.Enqueue(animal);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk

            //First check if there are any animals in the farm, then call the Talk() method on each
            if(farm.Count > 0)
            {
                foreach(Animal animal in farm)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the barn!");
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            //Check to ensure there are animals in the farm
            if (farm.Count > 0)
            {
                foreach (Animal animal in farm)
                { 
                    //Check if any interface belonging to the animal's derived class makes use of IMilkableAnimal
                    if (animal.GetType().GetInterfaces().Any(x => x.Name == "IMilkableAnimal"))
                    {
                        //Use animal as IMilkableAnimal
                        IMilkableAnimal milkable = animal as IMilkableAnimal;
                        milkable.ProduceMilk();
                    }
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (farm.Count != 0)
            {
                //Dequeue item while using it's type name for the message to display. 
                Console.WriteLine(farm.Dequeue().GetType().Name + " has left the farm");                          
            }
        }
        public void FarmEmpty()
        {
            //Included conditional logic so method can't be called on a non-empty farm
            if(farm.Count == 0)
            {
                Console.WriteLine("Emydex Farm is now empty");
            }
        } 
    }
}