using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Script;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder builder;
            Director director = new Director();

            builder = new ConcreteBuilderA();
            Product product1 = director.Construct(builder);
            product1.Show();
            
            builder = new ConcreteBuilderB();
            Product product2 = director.Construct(builder);
            product2.Show();

            Console.Read();
        }
    }
}
