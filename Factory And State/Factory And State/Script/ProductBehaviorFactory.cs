using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_And_State.Script
{
    static class ProductBehaviorFactory
    {
        private static Dictionary<ProductBehaviorType, Type> conductDict;

        private static void InitDict()
        {
            if (conductDict != null)
                return;

            var types = Assembly.GetAssembly(typeof(AbstractBehaviorProduct)).GetTypes().
                Where(t => t.IsClass && !t.IsInterface && t.IsSubclassOf(typeof(AbstractBehaviorProduct)));

            conductDict = new Dictionary<ProductBehaviorType, Type>();

            foreach (var t in types)
            {
                var tempInstance = Activator.CreateInstance(t) as AbstractBehaviorProduct;
                conductDict.Add(tempInstance.GetProductType, t);
            }
        }

        public static AbstractBehaviorProduct CreateConductBehavior(ProductBehaviorType type)
        {
            InitDict();

            if (conductDict.ContainsKey(type))
                return Activator.CreateInstance(conductDict[type]) as AbstractBehaviorProduct;

            throw new NullReferenceException($"Conduct Type {type} is not found.");
        }

        public static ProductModel CreateProduct(ProductBehaviorType type) => new ProductModel(CreateConductBehavior(type));
    }
}
