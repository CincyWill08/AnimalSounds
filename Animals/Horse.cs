using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Horse : ISounds
    {
        public string GetName()
        {
            return "Horse";
        }

        public string GetSound()
        {
            return "neigh";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
