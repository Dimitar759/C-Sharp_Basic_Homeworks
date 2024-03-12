using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public string Color { get; set; }

        public string Eat()
        {
            return $"The dog named {Name} who is a {Breed} breed with {Color} color is now eating";
        }

        public string Play()
        {
            return $"The dog named {Name} who is a {Breed} breed with {Color} color is now playing";
        }

        public string ChaseTail()
        {
            return $"The dog named {Name} who is a {Breed} breed with {Color} color is now chasing its tail";
        }
    }
}
