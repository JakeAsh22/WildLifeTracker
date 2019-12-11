using System;
using System.Collections.Generic;

namespace Park
{
    public class Program 
    {
        public static void Main()
        {
            Animal eagle = new Animal("Bald eagle", "Enclosure E");
            Animal bear = new Animal("Black bear", "Enclosure C");

            List<Animal> Animals = new List<Animal>() { eagle, bear };

            Console.WriteLine("Please enter an animal to search for :");
            string search = Console.ReadLine();

            List<Animal> AnimalsMatchingSearch = new List<Animal>(0);

            foreach (Animal species in Animals)
            {
                if(species.GetAnimal()==search)
                {
                    AnimalsMatchingSearch.Add(species);
                }
            }

            foreach (Animal species in AnimalsMatchingSearch)
            {
                Console.WriteLine(species.GetHabitat());
            }
        }
    }
}