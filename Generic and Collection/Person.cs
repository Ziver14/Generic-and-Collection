using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public class Person<T> where T : IWeapon
    {
        public string Name { get; set; }
        public string Raise { get; set; }

        public T Weapon { get; set; }

        public Person(string name,string raise,T weapon) 
        {   
            Name = name; Raise = raise; Weapon = weapon;
        }
        public void Print()
        {
            Console.WriteLine($"Персонаж:{Name}, Расса {Raise}, Оружие {Weapon}");
        }
        
    }
}
