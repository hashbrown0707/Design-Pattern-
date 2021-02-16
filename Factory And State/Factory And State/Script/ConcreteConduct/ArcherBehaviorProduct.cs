using System;

namespace Factory_And_State.Script
{
    class ArcherBehaviorProduct : AbstractBehaviorProduct  
    {
        public override ProductBehaviorType GetProductType => ProductBehaviorType.Archer;

        public override void Setup()
        {
            Console.WriteLine("Archer has setup.");
        }

        public override void Attack()
        {
            Console.WriteLine("Archer is attacking.");
        }
    }
}
