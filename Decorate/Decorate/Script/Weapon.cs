using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    abstract class Weapon
    {
        public abstract string Name();
        public abstract int Damage();

        public void Attack()
        {
            Console.WriteLine($"Use {Name()} to deal {Damage()} damages.");
        }
    }
}
