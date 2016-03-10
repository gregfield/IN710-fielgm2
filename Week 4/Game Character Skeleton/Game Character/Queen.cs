using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Queen : Character
    {
        public Queen(String name):base(name)
        {
            Weapon = new Bow();
        }
        public override string Declaim()
        {
            return "I am the powerful Queen!";
        }
    }
}
