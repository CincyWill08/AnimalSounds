using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cow : ISounds
    {
        public string GetName()
        {
            return "Cow";
        }

        public string GetSound()
        {
            return "mooooo";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
