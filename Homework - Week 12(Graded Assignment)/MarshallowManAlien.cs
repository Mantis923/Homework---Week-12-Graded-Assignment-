using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Week_12_Graded_Assignment_
{
    class MarshallowManAlien : Alien
    {
        public MarshallowManAlien(int health, string name) : base(health, name)
        {
        }

        public override int GetDamage()
        {
            return 1;
        }
    }
}
