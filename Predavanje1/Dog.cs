using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }


        public Dog(string name, int age, Race race)
        {
            Name = name;
            Age = age;
            Race = race;
        }
        


        public string Bark()
        {
            return "Bark, Bark";
        }
        

        public override string ToString()
        {
            
            return $"{Name} and i'm {Age} years and i'm : {Race}";
            
        }
    }
}
