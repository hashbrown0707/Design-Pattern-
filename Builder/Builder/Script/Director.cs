using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Script
{
    class Director
    {

        public Product Construct(ProductBuilder builder)
        {
            var a = builder.BuildPartA();
            var b = builder.BuildPartB();

            return new Product(a, b);
        }
    }
}
