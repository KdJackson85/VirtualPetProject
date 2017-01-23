using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pet object declaration
            Pet wolf = new Pet();

            //ascii art wolf 
            Console.WriteLine(")        (\\_");
            Console.WriteLine("((      _/{  \"-;");
            Console.WriteLine(" )).-'   {{  ;'-");
            Console.WriteLine("( )  ;.  _ \\\\");

            Console.WriteLine();


            //Introduction
            Console.WriteLine("Hello, my names Rainer, and I'm a wolf pup!\nYou can perform functions and help me grow!");

            Console.WriteLine("Press enter to view my stats!");
            Console.ReadLine();


            //First stats display, explanation.
            wolf.displayStats();
            Console.WriteLine();
            Console.WriteLine("These are my stats! if I exceed 100 or fall below 0 in some catagories, bad things happen.\nMake sure to take care of that waaaaaaalf!");


            bool isAlive = true;

            while (isAlive == true)
            {

                wolf.takeCareMethod();

                isAlive = wolf.FoodQuit();

                wolf.takeCareMethod();
            }

            Console.ReadKey();
        }
    }
}
