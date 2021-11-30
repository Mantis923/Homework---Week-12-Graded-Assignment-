using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Week_12_Graded_Assignment_
{
    class Alien
    {
        // don't need private int health; //0 = dead, 100 = full
        // don't need private string name;

        public int Health { get; set; } //or { get => health; set => health = value; } All Hidden
        public string Name { get; set; } //or { get => name; set => name = value; }

        public Alien()
        {

        }

        public Alien(int health, string name)
        {
            this.Health = health;
            this.Name = name;
        }
        public override string ToString()
        {
            return "Name " + Name + " Health " + Health;
        }
        public virtual int GetDamage()
        {
            return 0;
        }

    }

}
