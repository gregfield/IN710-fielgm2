using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        public String Name { get; set; }
        public IWeapon Weapon { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public abstract string Declaim();

        public string toString()
        {
            return "My name is " + Name;
        }

        
    }
}
