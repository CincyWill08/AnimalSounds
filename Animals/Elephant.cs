using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Elephant  : ISounds
    {

    public string GetName()
        {
            return "Elephant";
        }

        public string GetSound()
        {
            return "trumpet";
        }

        string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
