using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Script.Tests
{
    [TestClass()]
    public class ConcretePrototypeTests
    {
        [TestMethod()]
        public void CloneTest()
        {
            ConcretePrototype expected = new ConcretePrototype(3, "A", new Data(16, 1.5f));

            //shallow copy
            var actual = expected.Clone<ConcretePrototype>();
            actual.data.age = 50;      //reference type的話用淺層只能複製reference位址, 所以會覆蓋到原始物件

            Console.WriteLine($"expected age : {expected.data.age}");
            Console.WriteLine($"actual age : {actual.data.age}");
            Assert.AreNotEqual(expected.data.age, actual.data.age);     //Fail
        }
    }
}