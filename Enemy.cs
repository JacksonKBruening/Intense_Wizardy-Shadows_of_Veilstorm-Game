using System;
using System.Collections.Generic;
using System.Text;

namespace Intense_Wizardy
{
    class Enemy
    {
        public string enemyType { get; private set; }

        public int Health { get; set; }

        public int Strength { get; set; }

        public int Wisdom { get; set; }

        public int Armor { get; set; }

        public int Level { get; set; }


        public Enemy(string enemy, int level)
        {
            enemyType = enemy;
            Level = level;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Beware its a level {Level} {enemyType}!");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Armor: {Armor}\n");
        }

        public void Battle(ref Wizard wizard1)
        {
            int playerDamage = 0;
            int enemyDamage = 0;
            Random random = new Random();
            int damageMod = 0;
            do
            {
                
                if (wizard1.Wisdom > Armor)
                {
                    damageMod = random.Next(1, 3);
                    //Successful Player Hit: Full Damage
                    playerDamage = (damageMod + (wizard1.Wisdom / 4));
                    Console.WriteLine($"You cast a massive Fireball and deal {playerDamage} damage to the {enemyType}!");
                    Health -= playerDamage;
                }
                else
                {
                    damageMod = random.Next(0, 1);
                    //Missed Player hit: Half Damage
                    playerDamage = (damageMod + (wizard1.Wisdom / 4));
                    Console.WriteLine($"You cast a small Fireball and deal {playerDamage} damage to the {enemyType}!");
                    Health -= playerDamage;
                }


                //Checks to make sure that the enemy is not already dead
                if (Health > 0)
                {
                    Console.WriteLine($"The {enemyType} has {Health} health remaining.\n");
                    if (Strength > wizard1.Armor)
                    {
                        damageMod = random.Next(1, 2);
                        //Successful Enemy Hit: Full Damage
                        enemyDamage = (damageMod + (Strength/4));
                        Console.WriteLine($"The {enemyType} swings their sword viciously striking you for {enemyDamage} damage.");
                        wizard1.Health -= enemyDamage;
                    }
                    else
                    {
                        damageMod = random.Next(0, 1);
                        //Missed Enemy Hit: Half Damage
                        enemyDamage = (damageMod + (Strength / 4));
                        Console.WriteLine($"The {enemyType} swings their sword barley striking you for {enemyDamage} damage.");
                        wizard1.Health -= enemyDamage;
                    }
                }
                else
                {
                    Console.WriteLine($"The {enemyType} is defeated!\n");
                    wizard1.VampyricEssence();
                }

                Console.WriteLine($"You have {wizard1.Health} health remaining.\n");

            } while (Health > 0 && wizard1.Health > 0);

        }
    }
}
