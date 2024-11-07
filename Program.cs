using System;
using System.Threading;

namespace PoteatG_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates FantasyPet objects with various attributes
            FantasyPet pet1 = new FantasyPet("Bobby", "Gnome", 355, 1500, "Lightning Strike");
            FantasyPet pet2 = new FantasyPet("Bjorn", "Dragon", 671, 3800, "Fire Breath");
            FantasyPet pet3 = new FantasyPet("Teddy", "Gargoyle", 121, 530, "Acid Rain");
            FantasyPet pet4 = new FantasyPet("Dave", "Snowman", 3, 100, "Icicle Burst");
            FantasyPet pet5 = new FantasyPet("Milo", "Ogre", 77, 345, "Poison Cloud");

            //creates a new petshop class to manage the FantasyPet objects
            PetShop petShop = new PetShop();

            //add the created pets to petShop
            Console.WriteLine("\n");
            petShop.addPet(pet1);
            petShop.addPet(pet2);
            petShop.addPet(pet3);
            petShop.addPet(pet4);
            petShop.addPet(pet5);


            //set exit variable to false
            bool exit = false;

            //while loop that runs main menu
            while (!exit)
            {
                Console.WriteLine("\n------Welcome to the Fantasy Pet Shop!------");
                Console.WriteLine("1. Describe all pets");
                Console.WriteLine("2. See discounted prices");
                Console.WriteLine("3. Watch pets use their magic powers");
                Console.WriteLine("4. List all pets in the shop");
                Console.WriteLine("5. Exit shop");
                Console.WriteLine("Please enter 1-5 to select an action.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    //describes each pet in the store
                    Console.WriteLine("\n");
                    pet1.describePet();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet2.describePet();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet3.describePet();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet4.describePet();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet5.describePet();
                }

                else if (choice == "2")
                {
                    //displays the discounted prices on certian pets
                    Console.WriteLine($"\n{pet2.Name} has a 10% discount! New Price: {pet2.discountPrice(10)}");
                    Console.WriteLine($"{pet5.Name} has a 25% discount! New Price: {pet5.discountPrice(25)}");
                }

                else if (choice =="3")
                {
                    //shows the magic abilities of each pet
                    Console.WriteLine("\n");
                    pet1.performMagic();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet2.performMagic();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet3.performMagic();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet4.performMagic();
                    Thread.Sleep(750);
                    Console.WriteLine("\n");
                    pet5.performMagic();
                }

                else if (choice == "4")
                {
                    //list each pet
                    Console.WriteLine("\n");
                    petShop.listPets();
                }

                else if (choice == "5")
                {
                    //exit while loop and program as a whole
                    Console.WriteLine("\nThank you for visiting the shop, come again!");
                    Thread.Sleep(2000);
                    exit = true;
                }

                else
                {
                    //input validation
                    Console.WriteLine("\nInvalid input, enter 1-5.");
                }
            }

        }
    }
}
