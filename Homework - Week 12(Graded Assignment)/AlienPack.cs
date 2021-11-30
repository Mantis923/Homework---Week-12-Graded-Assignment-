using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Week_12_Graded_Assignment_
{
    class AlienPack
    {
        private Alien[] aliens;                    //data stucture that holds the elements like an array

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;

            foreach (Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }
        public void DisplayAliens()
        {
            foreach (Alien a in aliens)
            {
                Console.WriteLine(a + "\n");
            }
        }

    }

}
