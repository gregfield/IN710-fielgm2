using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class VampireHead : Head
    {
        public VampireHead()
        {
            partImage = "images/vampire_0.jpg";
        }
    }
    public class VampireBody : Body
    {
        public VampireBody()
        {
            partImage = "images/vampire_1.jpg";
        }
    }
    public class VampireTail : Tail
    {
        public VampireTail()
        {
            partImage = "images/vampire_2.jpg";
        }
    }
}
