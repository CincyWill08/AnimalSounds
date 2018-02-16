using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cat : ISounds
    {
        public string GetName()
        {
            return "Cat";
        }

        public string GetSound()
        {
            return "meow";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
