using System;
using System.Collections.Generic;
using System.Threading;

namespace PoteatG_Lab5
{
    class PetShop
    {
        //list to hold all of the FantasyPet objects
        private List<FantasyPet> pets = new List<FantasyPet>();

        //adds a new pet to the shop and returns a conformation message
        public void addPet(FantasyPet pet)
        {
            pets.Add(pet);
            Console.WriteLine($"{pet.Name} the {pet.Age} year old {pet.Species} has been added to your shop!");
        }

        //lists all pets in the shop and gives each descriptor
        public void listPets()
        {
            Console.WriteLine("The following pets are listed in your shop:");
            foreach (var pet in pets)
            {
                Console.WriteLine("\n+--------------------+");
                Console.WriteLine($" Name: {pet.Name}");
                Console.WriteLine($" Age: {pet.Age}");
                Console.WriteLine($" Species: {pet.Species}");
                Console.WriteLine($" Magic Power: {pet.MagicPower}");
                Console.WriteLine($" Price: {pet.Price}");
                Console.WriteLine("+--------------------+");
                Thread.Sleep(1000);

            }
        }

    }
}
