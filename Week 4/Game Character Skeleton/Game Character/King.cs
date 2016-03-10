using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class King : Character
    {
        public King(String name):base(name)
        {
            Weapon = new Sword();
        }
        public override string Declaim()
        {
            return "I am the most mighty of Kings!";
        }
    }
}
