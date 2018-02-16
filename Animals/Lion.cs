using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Lion : ISounds
    {
        public string GetName()
        {
            return "Lion";
        }

        public string GetSound()
        {
            return "roar";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
