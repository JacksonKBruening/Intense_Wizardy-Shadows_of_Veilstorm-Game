//Programmer: Jackson K Bruening
//Program: Intense_Wizardy (Name inspired by Chris "Sips" Lovasz's play through of Game Dev Tycoon- https://www.youtube.com/sips)

using System;

namespace Intense_Wizardy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unknown: Traveler... ");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            if (name == "")
            {
                //Checks if a name is input
                Console.WriteLine("ERROR: INVALID NAME");
                return;
            }

            Console.WriteLine($"Unknown: Welcome {name} to Veilstorm....");
            Console.WriteLine("Skipper: Let me introduce myself. I am Skipper, An ally of the royal family. Go quickly, they await your arrival at the castle, but becareful the shadows lurk Veilstorm at night.\n");

            Wizard Player = new Wizard(name, 1);
            Player.DisplayStats();
            Console.WriteLine("On your way to the castle you hear a muffled chattering of what sounds like teeth behind you. You turn around and find yourself looking directly at a animated skeleton. Prepare for battle!\n");

            Skeleton skeleOne = new Skeleton("Skeleton", 2);
            skeleOne.DisplayStats();
            skeleOne.Battle(ref Player);

            Player.LevelUp();
            Player.DisplayStats();


        }
    }
}
        
