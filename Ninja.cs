using System;
using System.Collections.Generic;

namespace human_proj
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
        }
        public void steal(object name)
        {
            Human enemy = name as Human;    
            if(enemy != null)
            {
                enemy.health -= 10;
                health += 10;
            }
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}