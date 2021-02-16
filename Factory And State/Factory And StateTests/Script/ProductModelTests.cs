using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory_And_State.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Factory_And_State.Script.Tests
{
    [TestClass()]
    public class ProductModelTests
    {
        [TestMethod()]
        public void ProductModelTest()
        {
            var expected = new ProductModel(new HealerBehaviorProduct());

            var actualBehavior = ProductBehaviorFactory.CreateConductBehavior(ProductBehaviorType.Healer);
            var actual = new ProductModel(actualBehavior);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void AttackTest()
        {
            var actualBehavior = ProductBehaviorFactory.CreateConductBehavior(ProductBehaviorType.Archer);
            var actual = new ProductModel(actualBehavior);
            actual.Attack();

            Trace.WriteLine(actual);
        }

        [TestMethod()]
        public void ChangeJobTest()
        {
            var expected = new ProductModel(new WarriorBehaviorProduct());

            var actual = ProductBehaviorFactory.CreateProduct(ProductBehaviorType.Healer);
            actual.ChangeJob(ProductBehaviorType.Warrior);

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}