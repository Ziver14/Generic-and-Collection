using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public interface IWeapon
    {   
       static public string Name { get; set; }
       public int Force {  get; set; }
       public string Properties {  get; set; }

    }
}
