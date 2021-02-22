using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Script
{
    class ConcreteBuilderA : ProductBuilder
    {
        public override string BuildPartA() => "Part A, type-1";

        public override string BuildPartB() => "Part B, type-1";
    }
}
