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
            System.Console.WriteLine(harry.health);


            merlin.fireball(jonny);
            System.Console.WriteLine(jonny.health);

        }
    }
}
