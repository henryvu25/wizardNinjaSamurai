using System;

namespace human_proj
{
    public class Zombie : Enemy
    {
        //constructor function
        public Zombie(int level) : base(level)
        {
            health = 5;
        }
        //class method(s)
        public void resurrect()
        {
            Random rand = new Random();
            if(health <= 0)
            {
                if(rand.Next(0,10) > 2)
                {
                    health = 5;
                }
            }
        }
    }
}