using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Script
{
    public abstract class ProductBuilder
    {
        public Product product { get; protected set; }

        public abstract string BuildPartA();
        public abstract string BuildPartB();
    }
}
