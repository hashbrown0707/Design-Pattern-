using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class IceWeapon : Decorator
    {
        public IceWeapon(Weapon weapon) : base(weapon)
        {
        }

        public override string Name() => $"ice {weapon.Name()}";
        public override int Damage() => weapon.Damage() + 5;
    }
}
