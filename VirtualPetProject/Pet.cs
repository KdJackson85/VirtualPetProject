using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject
{
    class Pet
    {
        //*** Fields ***
        private string name;
        private int food;
        private int sleep;
        private int energy;
        private int potty;
        private int exercise;
        private string grey;
        private string arctic;
        private string timberwolf;


        //*** Properties ***

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Food
        {
            get { return Food; }
            set { this.Food = value; }
        }

        public int Sleep
        {
            get { return Sleep; }
            set { this.Sleep = value; }
        }

        public int Energy
        {
            get { return Energy; }
            set { this.Energy = value; }
        }

        public int Exercise
        {
            get { return Exercise; }
            set { this.Exercise = value; }
        }

        //***Constructors***


        public Pet() //Grey Wolf
        {
            this.food = 50;
            this.sleep = 50;
            this.potty = 50;
            this.exercise = 75;
        }

        //*** Methods ***

        public void displayStats()
        {
            Console.WriteLine("Rainers appetite level: " + food);
            Console.WriteLine("Rainers rest level :" + sleep);
            Console.WriteLine("Rainers bathroom level: " + potty);
            Console.WriteLine("Rainers energy level: " + exercise);

        }


        public int takeCareMethod()
        {
            Console.WriteLine("Enter \"1\" to feed me.\nEnter \"2\" to let me out.\nEnter \"3\" to let me take a nap.\nEnter \"4\" to play with him!");

            int userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)//Feeds him
            {
                food += 10; potty += 5; exercise -= 5;
                displayStats();
                Console.WriteLine();
                return food;

            }
            else if (userInput == 2) //Let Him out to potty
            {
                potty -= 10; food -= 5; exercise -= 5;

                displayStats();
                Console.WriteLine();
                return potty;
            }
            else if (userInput == 3) //Takes nap
            {
                sleep += 20; food -= 10; potty += 10;

                displayStats();
                Console.WriteLine();
                return sleep;
            }
            else if (userInput == 4) //Play with him
            {
                sleep -= 10; exercise -= 10; food -= 5;

                displayStats();
                Console.WriteLine();
                return exercise;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection.");
                Console.WriteLine();
                return sleep;

            }

        }

        //Game Over Method
        public bool FoodQuit()
        {
            bool isAlive = true;

            if (food >= 100)
            {
                Console.WriteLine("Oh no! You've fed the poor boy too much and his little stomach exploded! :[ ");
                Console.ReadLine();
                Environment.Exit(0);

                isAlive = false;
            }
            if (food <= 0)
            {
                Console.WriteLine("Oh No! Poor Rainer starved to death! Poor lil' guy. Maybe a wolf pup's\na tad too much responsibility for you.\nTry a plant next time maybe.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (potty >= 100)
            {
                Console.WriteLine("Uh Oh! Looks like someone had a little accident in the house! You have to remember to let the poor guy out! ");
                potty = 50;
            }
            if (exercise <= 0)
            {
                Console.WriteLine("You didn't play with Rainer enough so he went dog crazy and started biting everyone!\nYou're forced to put him down.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (sleep <= 10)
            {
                Console.WriteLine("Rainers tired! You better give him a nap! Or something bad might happen!");
                if (sleep <= 0)
                {
                    Console.WriteLine("Oh no! You didn't let Rainer sleep enough! Sleep deprived wolves turn into \nWerewolves and eat their masters.\nEveryone knows that! R.I.P, you.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (sleep >= 200)
                {
                    Console.WriteLine("How much Benadryl you giving this guy?\nDrugging animals is illegal you know. ");
                }

            }

            return isAlive;
        }


    }
}

