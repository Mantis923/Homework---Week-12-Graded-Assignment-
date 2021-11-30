using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Part 2		
/// File Name: Homework - Week 12(Graded Assignment)
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola


namespace Homework___Week_12_Graded_Assignment_
{

    class Program
    {
      ///In the attached file you will find some video game code by J.Hacker.There is an Alien class to 
      ///represent a monster and an AlienPack class that represents a band of aliens and how much damage they can inflict.
      ///The code is not very object oriented and does not support information hiding in the Alien class.  Split the code 
      ///into multiple files.Rewrite the code so that inheritance is used to represent the different types of aliens instead 
      ///of the “type” parameter.This should result in deletion of the “type” parameter.Also rewrite the Alien class to hide 
      ///the instance variables and create a GetDamage method for each derived class that returns the amount of damage the 
      ///alien inflicts.Finally, rewrite the CalculateDamage method to use GetDamage and write a Main method that tests the 
      ///code.
        static void Main(string[] args)
        {
            MarshallowManAlien marshallow1 = new MarshallowManAlien(100, "marshallow");
            OgreAlien ogrreAlian2 = new OgreAlien(500, "Ogrre Alian");
            SnakeAlien snakeAlien3 = new SnakeAlien(90, "Snake Alien");

            AlienPack smallAliean = new AlienPack(3);

            smallAliean.AddAlien(marshallow1, 0);
            smallAliean.AddAlien(ogrreAlian2, 1);
            smallAliean.AddAlien(snakeAlien3, 2);

            smallAliean.DisplayAliens();
            Console.WriteLine("\nDamage done by Aliens: " + smallAliean.CalculateDamage());


            Console.ReadLine();

        }
    }
}