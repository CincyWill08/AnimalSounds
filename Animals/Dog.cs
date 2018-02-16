using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Dog : ISounds
    {
        public string GetName()
        {
            return "Dog";
        }

        public string GetSound()
        {
            return "woof";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
