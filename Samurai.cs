using System;

namespace human_proj
{
    //state class inheriting from Human
    public class Samurai : Human
    {
        public static int count = 0;
        //constructor function to build Samurai
        public Samurai(string name) : base(name)
        {
            health = 200;
            count++;
        }
        public void death_blow(object name)
        {
            Human enemy = name as Human;
            if(enemy != null)
            {
                if(enemy.health <= 50)
                {
                    enemy.health = 0;
                    System.Console.WriteLine($"{enemy.name} has been KO'd!");
                }
                else
                {
                    System.Console.WriteLine("Attack Missed!");
                }
            }
        }
        public void meditate()
        {
            health = 200;
        }
        public void how_many()
        {
            if(count == 1)
            {
                System.Console.WriteLine($"There is only {count} Samurai");
            }
            else
            {
                System.Console.WriteLine($"There are {count} Samurai");
            }
        }
    }
}