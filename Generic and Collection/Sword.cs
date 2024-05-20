using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public struct Sword:IWeapon
    {
        static public string Name { get; set; }
        public int Force { get; set; }
        public string Properties { get; set; }
        public int Quality {  get; set; }
        public Sword(string name, int force, string properties, int quality)
        {
            Name = name;
            Force = force;
            Properties = properties;
            Quality = quality;
        }

   
    }
}
