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
    public class UtilityTests
    {
        [TestMethod()]
        public void DeepCopyTest()
        {
            var expected = new ConcretePrototype(1, "b", new Data(64, 1.7f));

            var actual = Utility.DeepCopy(expected);
            actual.data.age = 50;

            Console.WriteLine($"expected age : {expected.data.age}");
            Console.WriteLine($"actual age : {actual.data.age}");
            Assert.AreNotEqual(expected.data.age, actual.data.age);     //success
        }
    }
}