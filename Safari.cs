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
            _animals.Add(new Cheetah("Gertrude", "wwewewe!", 2, 190, 89));
            _animals.Add(new Cheetah("Pierrot", "yeeeeeeee!", 4, 167, 120));
            _animals.Add(new Cheetah("Coco", "ghghghgg!", 9, 123, 111));
            _animals.Add(new Impala("Ingo", "auehuaheuaheuhae!", 15, 128, true, true));
            _animals.Add(new Impala("Ingo II", "auehuaheuaheuhae!", 15, 128, true, true));
            _animals.Add(new Impala("Ingo III", "auehuaheuaheuhae!", 15, 128, true, true));
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
