using System;

namespace human_proj
{
    public class Human
    {
        public string name { get;set; }
        public int strength { get;set; }
        public int intelligence { get;set; }
        public int dexterity { get;set; }
        public int health { get;set; }

        public Human(string username)
        {
            name = username;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string n, int str, int intel, int dex, int hlt)
        {
            name = n;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hlt;
        }
        public void Attack(object name)
        {
            Human enemy = name as Human;
            if(enemy == null)
            {
                System.Console.WriteLine("Attack has no effect");
            }
            else
            {
                enemy.health -= 5*strength;
            }
        }
    }
}