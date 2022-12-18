using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Game
{
    public class Lion : Animal
    {

        //Properties
        public enum LionHairChoices
        {
            Yellow,
            Golden,
            White,
            Beige,
            Tan
        }
        private readonly LionHairChoices _hair;

        /// <value>Property <c>Hair</c> represents the color of the lion's hair.</value>
        public LionHairChoices Hair
        {
            get
            {
                return _hair;
            }
        }

        public Lion(
            string name, string sound, int age, int weight, LionHairChoices hair) : base(name, sound, age, weight)
        {
            _hair = hair;
        }

        /// <summary>
        /// Method <c>Display</c> will write in the console the characteristics of the lion.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n" +
                $"\tHair color: {Hair}\n"
            );
        }

        /// <summary>
        /// Method <c>Parade</c> will make the lion act in front of the user.
        /// </summary>
        public override void Parade()
        {
            Console.WriteLine("The lion is laying on the ground, attentive to the truck passing by.");
            Console.WriteLine(Sound);
            Console.WriteLine("What a majestic creature!\n");
        }
    }

}
