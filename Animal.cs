using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Game
{
    public class Animal
    {
        //Properties
        protected string _name;
        protected string _sound;
        protected int _age;
        protected int _weight;

        /// <value>Property <c>Name</c> represents the name the animal was given by the safari organizers.</value>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <value>Property <c>Sound</c> represents the sounds the animal makes when meeting the user.</value>
        public string Sound
        {
            get
            {
                return _name + " is making a huuuuuge " + _sound;
            }
        }

        // <value>Property <c>Age</c> represents the age of the animal in years.</value>
        public int Age
        {
            get
            {
                return _age;
            }
        }

        // <value>Property <c>Weight</c> represents the weight of the animal in pounds.</value>
        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        /// <summary>
        /// Constructor <c>Animal</c> will add the different safari animals to the list.
        /// </summary>
        public Animal(string name, string sound, int age, int weight) 
        {
            _name = name;
            _sound = sound;
            _age = age;
            _weight = weight;
        }

        /// <summary>
        /// Method <c>Display</c> will write in the console the characteristics of the animal.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n"
            );
        }

        /// <summary>
        /// Method <c>Parade</c> will make the animal act in front of the user.
        /// </summary>
        public virtual void Parade()
        {
            Console.WriteLine(Sound);
        }
    }
}
