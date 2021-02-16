using System;

namespace Factory_And_State.Script
{
    class HealerBehaviorProduct : AbstractBehaviorProduct
    {
        public override ProductBehaviorType GetProductType => ProductBehaviorType.Healer;

        public override void Setup()
        {
            Console.WriteLine("Healer has setup.");
        }

        public override void Attack()
        {
            Console.WriteLine("Healer is attacking.");
        }
    }
}
