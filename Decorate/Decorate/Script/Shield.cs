using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class Shield : Weapon
    {
        public override string Name() => "shield";
        public override int Damage() => 3;
    }
}
