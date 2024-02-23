using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player alice = new Player("Alice",90,50,50);
            Player bob = new Player("Bob", 80, 40, 30);

            Stats fireball = new Stats("Fireball", 10, "a firey magical attack", 5, 15, 0);
            alice.LearnSkill(fireball);
            bob .LearnSkill(fireball);

           
            Console.WriteLine(bob.Attack(alice));
            Console.WriteLine(alice.Attack(bob));
        }
    }
}