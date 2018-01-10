using System;
using System.Collections.Generic;

namespace human_proj
{
    public class Wizard : Human
    {

        public Wizard(string name) : base(name)
        {
            intelligence = 25;
            health = 50;
        }
        public void heal()
        {
            health += 10*intelligence;
        }
        public void fireball(object name)
        {
            Human enemy = name as Human;
            Random rand = new Random();
            if(enemy != null)
            {
                enemy.health -= rand.Next(20,51);
            }
            
        }
    }
}