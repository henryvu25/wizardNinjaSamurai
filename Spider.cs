using System;

namespace human_proj
{
    public class Spider : Enemy
    {
        //constructor function
        public Spider(int level) : base(level){}
        
        //class method(s)
        public void poison(object name)
        {
            Human target = name as Human;
            if(target != null)
            {
                target.strength -= 5;
                target.intelligence -= 5;
                target.dexterity -= 5;
                target.health -= 5;
            }
        }
    }
}