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


            naruto.steal(sasuke);
            naruto.get_away();
            System.Console.WriteLine(sasuke.health);
            System.Console.WriteLine(naruto.health);
            

        }
    }
}
