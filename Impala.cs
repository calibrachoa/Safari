using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Game
{
    internal class Impala : Animal
    {
        private readonly bool _hasHorns;
        private readonly bool _runsInZigZag;
        public bool HasHorns { get { return _hasHorns; } } 
        public bool RunsInZigZag { get { return _runsInZigZag; } }
        public Impala(string name, string sound, int age, int weight, bool hasHorns, bool runsInZigZag) : base(name, sound, age, weight)
        {
            _hasHorns = hasHorns;
            _runsInZigZag = runsInZigZag;
        }

        public override void Display()
        {
            Console.WriteLine($"This {GetType().Name} is named {Name}.\n" +
                $"\tAge: {Age} yo\n" +
                $"\tWeight: {Weight} lbs\n" +
                $"\t{HasHorns}, it has horns\n" +
                $"\t{RunsInZigZag}, it runs in zigzag\n");
        }

        public override void Parade()
        {
            Console.WriteLine("The impala is running fast in a zigzag way while the truck passes by.");
            Console.WriteLine(Sound);
            Console.WriteLine("What a fast and skillful creature!\n");
        }


    }
}
