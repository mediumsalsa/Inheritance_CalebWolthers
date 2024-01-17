using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_CalebWolthers
{
    internal class HealthSystem
    {
        public int health;

        public void Heal(int hp)
        {
            health += hp;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }


    }
}
