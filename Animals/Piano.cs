using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Piano : ISounds
    {
        public string GetInstrumentName()
        {
            return "Piano";
        }

        public string GetInstrumentSound()
        {
            return "jangling";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
