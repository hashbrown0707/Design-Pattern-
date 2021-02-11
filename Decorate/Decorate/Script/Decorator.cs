using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    abstract class Decorator : Weapon
    {
        protected Weapon weapon;

        public Decorator(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override abstract string Name();
        public abstract override int Damage();
    }
}
