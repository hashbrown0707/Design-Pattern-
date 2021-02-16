using System;

namespace Factory_And_State.Script
{
    class WarriorBehaviorProduct : AbstractBehaviorProduct 
    {
        public override ProductBehaviorType GetProductType => ProductBehaviorType.Warrior;

        public override void Setup()
        {
            Console.WriteLine("Warrior has setup.");
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior is attacking.");
        }
    }
}
