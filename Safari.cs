using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Game
{
    public class Safari
    {
        //Properties
        private readonly List<Animal> _animals = new List<Animal>();
        private readonly Random _random = new Random();

        /// <summary>
        /// Constructor <c>Safari</c> will add the different safari animals to the list.
        /// </summary>
        public Safari()
        {
            _animals.Add(new Lion("Pollux", "roaaaaaaaarrrrrrrrrrrr!", 16, 270, Lion.LionHairChoices.White));
            _animals.Add(new Lion("Charlot", "grrrrrrrrrr!", 14, 316, Lion.LionHairChoices.Golden));
            _animals.Add(new Gorilla("Bobo", "OOOOOOH! OOOOOOOH!", 22, 320, "bang bang"));
            _animals.Add(new Gorilla("Gronk", "hmmmmmm.... oh, oh", 50, 400, "bang bang bang"));
            _animals.Add(new Gorilla("Bruce", "ooh ooh ooh... OOOOOOOOH!", 37, 370, "bing bong bang"));

        }

        /// <summary>
        /// Method <c>ChooseRandomAnimal</c> selects a random animal from the list and make it parade.
        /// </summary>
        public void ChooseRandomAnimal()
        {
            _animals[_random.Next(0, _animals.Count)].Parade();
        }

        /// <summary>
        /// Method <c>ListVisibleAnimals</c> displays, one by one, the different animals on the list.
        /// </summary>
        public void ListVisibleAnimals()
        {
            foreach(Animal animal in _animals)
            {
                animal.Display();
            }
        }
    }
}
