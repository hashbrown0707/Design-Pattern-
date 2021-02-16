using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var behavior = ConductBehaviorFactory.CreateConductBehavior(ConductBehaviorType.Healer);

            ConductModel model1 = new ConductModel(behavior);
            model1.Attack();

        }
    }
}
