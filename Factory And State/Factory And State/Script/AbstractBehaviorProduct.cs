using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_And_State.Script
{
    abstract class AbstractBehaviorProduct
    {
        public abstract ProductBehaviorType GetProductType { get; }
        public abstract void Setup();
        public abstract void Attack();
    }
}
