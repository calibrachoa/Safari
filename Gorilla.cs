using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Safari_Game
{
    internal class Gorilla : Animal
    {
        private readonly string _beatChest;

        public string beatChest
        {
            get
            {
                return _beatChest;
            }
        }

        public Gorilla(
            string name, string sound, int age, int weight, string beatChest) : base(name, sound, age, weight)
        {
            _beatChest = beatChest;

        }

        /// <summary>
        /// Method <c>Display</c> will write in the console the characteristics of the lion.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n" +
                $"\tChest beating rythme: {beatChest}\n"
            );
        }

        /// <summary>
        /// Method <c>Parade</c> will make the lion act in front of the user.
        /// </summary>
        public override void Parade()
        {
            Console.WriteLine($"Cool! This gorilla is beating it's chest! It went like this {beatChest}");
            Console.WriteLine(Sound);
            Console.WriteLine("What a majestic creature!\n");
        }
    }
}
