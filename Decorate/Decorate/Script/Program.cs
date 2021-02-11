using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Sword();
            Weapon dagger = new Dagger();
            Weapon shield = new Shield();

            sword.Attack();
            dagger.Attack();
            shield.Attack();

            FireWeapon fireSword = new FireWeapon(sword);
            IceWeapon iceDagger = new IceWeapon(dagger);

            fireSword.Attack();
            iceDagger.Attack();

            FireWeapon fireShield = new FireWeapon(shield);
            IceWeapon iceFireShield = new IceWeapon(fireShield);

            iceFireShield.Attack();

            Console.Read();
        }
    }
}
