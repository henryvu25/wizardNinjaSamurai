using System;

namespace human_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Human henry = new Human("Henry");
            Human jonny = new Human("Jonny", 10, 10, 15, 200);
            Wizard merlin = new Wizard("Merlin");
            Wizard harry = new Wizard("Harry");
            Ninja naruto = new Ninja("Naruto");
            Ninja sasuke = new Ninja("Sasuke");
            Samurai jack = new Samurai("Jack");
            Samurai shredder = new Samurai("Shredder");
            Spider spider1 = new Spider(5);
            Zombie zombie1 = new Zombie(5);

            
            henry.Attack(zombie1);
            System.Console.WriteLine(zombie1.health);
            zombie1.resurrect();
            System.Console.WriteLine(zombie1.health);
            
            


        }
    }
}
