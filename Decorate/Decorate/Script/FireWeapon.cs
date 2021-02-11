using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class FireWeapon : Decorator
    {
        public FireWeapon(Weapon weapon) : base(weapon)
        {
        }

        public override string Name() => $"fire {weapon.Name()}";
        public override int Damage() => weapon.Damage() + 5;
    }
}
