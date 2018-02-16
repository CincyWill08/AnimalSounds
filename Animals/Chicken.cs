using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Chicken : ISounds
    {
        public string GetName()
        {
            return "Chicken";
        }

        public string GetSound()
        {
            return "cluck";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
