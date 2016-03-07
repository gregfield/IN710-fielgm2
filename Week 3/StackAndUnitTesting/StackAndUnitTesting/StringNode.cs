using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndUnitTesting
{
    class StringNode
    {
        public StringNode Next { get; set; }
        public String Info;

        public StringNode(String info)
        {
            Info = info;
            Next = null;
        }
    }
}
