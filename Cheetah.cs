using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Game
{
    public class Cheetah : Animal
    {

        //Properties
        private readonly int _speed;

        /// <value>Property <c>Speed</c> represents the speed when cheetah runs.</value>
        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        public Cheetah(
            string name, string sound, int age, int weight, int speed) : base(name, sound, age, weight)
        {
            _speed = speed;
        }

        /// <summary>
        /// Method <c>Display</c> will write in the console the characteristics of the cheetah.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n" +
                $"\tRunning speed: {Speed} km/h\n"
            );
        }

        /// <summary>
        /// Method <c>Parade</c> will make the cheetah act in front of the user.
        /// </summary>
        public override void Parade()
        {
            Console.WriteLine($"Whoa! This cheetah is running so fast! Maybe at a speed of {Speed} km/h?");
            Console.WriteLine(Sound);
            Console.WriteLine("Oh! It's so fast!\n");
        }
    }

}
