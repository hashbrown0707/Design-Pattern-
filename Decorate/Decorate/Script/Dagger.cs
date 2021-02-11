using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class Dagger : Weapon
    {
        public override string Name() => "dagger";
        public override int Damage() => 7;
    }
}
