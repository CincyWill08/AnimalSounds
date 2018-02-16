using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Monkey : ISounds
    {

        public string GetName()
        {
            return "Monkey";
        }

        public string GetSound()
        {
            return "ooo ooo ahhh ahhh";
        }

        string ISounds.ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
