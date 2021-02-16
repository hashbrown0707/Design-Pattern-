using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_And_State.Script
{
    class ProductModel
    {
        AbstractBehaviorProduct behavior;

        public ProductModel(AbstractBehaviorProduct behavior)
        {
            this.behavior = behavior;

            behavior?.Setup();
        }

        public void Attack()
        {
            behavior?.Attack();
        }

        public void ChangeJob(ProductBehaviorType job)
        {
            behavior = ProductBehaviorFactory.CreateConductBehavior(job);
            behavior.Setup();
        }

        //do other stuff u want
    }
}
