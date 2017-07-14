using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Harmanpreet Singh
 * Date: July 13, 2017
 * Description: This is the driver class for my project
 * Version: 0.5 - Implemented the Supervillain class
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.Powers.Add(new Power("Teleportation", 50));
            superHero.Powers.Add(new Power("Phasing", 40));
            superHero.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
            SuperVillain supervillain = new SuperVillain("SuperVillain Groot", 20);
            supervillain.Powers.Add(new Power("Metal Body Conversion", 46));
            supervillain.Powers.Add(new Power("Mind Reading", 20));
            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Malice : "+supervillain.Malice);

        }
    }
}