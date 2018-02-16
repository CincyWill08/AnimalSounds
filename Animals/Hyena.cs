using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Hyena : ISounds
    {
        public string GetName()
        {
            return "Hyena";
        }

        public string GetSound()
        {
            return "laugh";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
