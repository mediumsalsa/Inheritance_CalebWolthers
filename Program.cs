using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_CalebWolthers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inheritance");
            Console.WriteLine("");

            PlayerClass player = new PlayerClass();
            EnemyClass slime = new EnemyClass();
            Items sword = new Items();



           //player.HealthSystem.health = 100;
            player.position.x = 0;
            player.position.y = 0;

            slime.position.x = 10;
            slime.position.y = 10;

            sword.position.x = 5;
            sword.position.y = 5;

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
