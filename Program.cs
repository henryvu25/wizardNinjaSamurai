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


            jack.how_many();
            jack.death_blow(shredder);
            merlin.fireball(shredder);
            merlin.fireball(shredder);
            jonny.Attack(shredder);
            henry.Attack(shredder);
            merlin.Attack(jonny);
            jack.death_blow(shredder);
            System.Console.WriteLine(shredder.health);
            System.Console.WriteLine(jonny.health);

        }
    }
}
