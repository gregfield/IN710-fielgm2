using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public interface IMakeMonster
    {
        Head makeHead();
        Body makeBody();
        Tail makeTail();
    }
}
