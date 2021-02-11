using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class Sword : Weapon
    {
        public override string Name() => "sword";
        public override int Damage() => 10;
    }
}
