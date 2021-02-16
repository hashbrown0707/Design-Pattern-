using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_And_State.Script;

namespace Factory_And_State
{
    class Program
    {
        static void Main(string[] args)
        {
            var model1 = ProductBehaviorFactory.CreateProduct(ProductBehaviorType.Healer);
            model1.Attack();

            var behavior = ProductBehaviorFactory.CreateConductBehavior(ProductBehaviorType.Archer);
            ProductModel model2 = new ProductModel(behavior);
            model1.Attack();
            model2.Attack();

            model1.ChangeJob(ProductBehaviorType.Warrior);
            model1.Attack();

            Console.Read();
        }
    }
}
