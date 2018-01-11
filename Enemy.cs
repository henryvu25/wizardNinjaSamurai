using System;

namespace human_proj
{
    public class Enemy
    {
        //properties
        public int level { get;set; }
        public int health { get;set; }

        //constructor function
        public Enemy(int number)
        {
            level = number;
            health = 5*number;
        }

        public void tackle(object name)
        {
            Human target = name as Human;
            if(target != null)
            {
                target.health -= 10;
            }
        }
    }
}