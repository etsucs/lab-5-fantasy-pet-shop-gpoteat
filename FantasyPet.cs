using System;
using System.Threading;

namespace PoteatG_Lab5
{
    class FantasyPet
    {
        //getters and setters for FantasyPet
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }

        //constructor for FantasyPet 
        public FantasyPet(string name, string species, int age, decimal price, string magicPower)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
            MagicPower = magicPower;
        }

        //Describes each attribute of the pet
        public void describePet()
        {
            Console.WriteLine($"{Name} is a {Age} year old {Species} that can use a(n) {MagicPower}! \n{Name} is currently priced at {Price} gems, but you might find a price cut on our discount page! ");
        }

        //calculates the dicounted price
        public decimal discountPrice(decimal percent)
        {
            return Price * (1 - percent / 100);
        }

        //displays the magical power that a given pet has
        public void performMagic()
        {
            Console.WriteLine($"{Name} uses its {MagicPower} to attack the test dummy!");
            Thread.Sleep(750);
        }
    }
}
