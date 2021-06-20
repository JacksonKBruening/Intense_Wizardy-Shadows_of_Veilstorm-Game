using System;
using System.Collections.Generic;
using System.Text;

namespace Intense_Wizardy
{
    class Wizard
    {
        public string Name { get; private set; }

        public int MaxHealth { get; private set; }

        public int Health { get; set; }

        public int Wisdom { get; private set; }

        public int Armor { get; private set; }

        public int Level { get; private set; }

        //Sets up your character
        public Wizard(string name, int level)
        {
            Name = name;
            Level = level;
            Wisdom = 14;
            MaxHealth = 10;
            Health = MaxHealth;
            Armor = 6;           
        }

        //Modifies your characters stats based on level
        public void StatMod()
        {
            Wisdom = 12 + (2 * Level);
            MaxHealth = 9 + (2 * Level);
            Armor = 5 + (1 * Level);

        }

        //Auto Levels and heals your caharacter
        public void LevelUp()
        {
            Console.WriteLine("You level up!");
            Level++;
            StatMod();
            Rejuvinate();
        }

        //Outputs Stats to Screen
        public void DisplayStats()
        {
            Console.WriteLine($"Current Stats: {Name}");
            Console.WriteLine($"You are a level {Level} Wizard!");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Armor: {Armor}\n");
        }

        //Healing to Full
        public void Rejuvinate()
        {
            Health = MaxHealth;
        }

        //A Vampyric Ability allowing the player to heal after battles
        public void VampyricEssence()
        {
            //Make sure you cant heal above your Maximum Health
            if ((Health + (2 * Level)) > MaxHealth)
            {
                Console.WriteLine($"You feel the blood of your defeated in enemy pour in to your soul. Healing you for {(MaxHealth - Health)} health");
                Health = MaxHealth;
            }
            else
            {
                Console.WriteLine($"You feel the blood of your defeated in enemy pour in to your soul. Healing you for {(2 * Level)} health");
                Health += (2 * Level);
            }
        }


    }
}
