using Safari_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Safari
{
    public class Baboon : Animal
    {

        //Properties

        private readonly int _speed;
        public enum BaboonHairChoices
        {
            Yellow,
            Golden,
            White,
            Beige,
            Tan
        }
        private readonly BaboonHairChoices _hair;

        /// <value>Property <c>Hair</c> represents the color of the Baboon's hair.</value>
        public BaboonHairChoices Hair
        {
            get
            {
                return _hair;
            }
        }
        public int Speed
        {
            get 
            { 
                return _speed; 
            }
        }

        public Baboon(
            string name, string sound, int age, int weight, int speed) : base(name, sound, age, weight)
        {
            _speed = speed;
        }

        /// <summary>
        /// Method <c>Display</c> will write in the console the characteristics of the Baboon.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n" +
                $"\tHair color: {Hair}\n" +
                $"\tRunning speed: {Speed} km/h \n"
            );
        }

        /// <summary>
        /// Method <c>Parade</c> will make the Baboon act in front of the user.
        /// </summary>
        public override void Parade()
        {
            Console.WriteLine($"The Baboon hanging from the tree. Do you think it can climb the tree at {Speed} km/h?");
            Console.WriteLine(Sound);
            Console.WriteLine("What a majestic creature!\n");
        }
    }
}
