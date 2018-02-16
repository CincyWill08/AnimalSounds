using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Pig : ISounds
    {
        public string GetName()
        {
            return "Pig";
        }

        public string GetSound()
        {
            return "oink oink";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
