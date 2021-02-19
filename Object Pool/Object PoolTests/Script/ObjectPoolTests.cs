using Microsoft.VisualStudio.TestTools.UnitTesting;
using Object_Pool.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool.Script.Tests
{
    [TestClass()]
    public class ObjectPoolTests
    {
        [TestMethod()]
        public void InitPoolTest()
        {
            ObjectPool<SomeObject>.Pool pool = new ObjectPool<SomeObject>.Pool { name = "test", size = 5 };

            ObjectPool<SomeObject>.Instance.InitPool(pool);
            var actual = ObjectPool<SomeObject>.Instance.poolDict["test"];

            Assert.AreEqual(pool.name, actual.name);
            Assert.AreEqual(pool.size, actual.size);
        }

        [TestMethod()]
        public void GetObjectFromPoolTest()
        {
            ObjectPool<SomeObject>.Pool pool = new ObjectPool<SomeObject>.Pool { name = "a", size = 5 };

            ObjectPool<SomeObject>.Instance.InitPool(pool);
            var actual = ObjectPool<SomeObject>.Instance.GetObjectFromPool("a");

            Assert.AreEqual(new SomeObject().GetType(), actual.GetType());
        }

        [TestMethod()]
        public void ReturnObjectToPoolTest()
        {
            ObjectPool<SomeObject>.Pool pool = new ObjectPool<SomeObject>.Pool { name = "b", size = 5 };

            ObjectPool<SomeObject>.Instance.InitPool(pool);
            ObjectPool<SomeObject>.Instance.ReturnObjectToPool("b", new SomeObject());
            var actual = ObjectPool<SomeObject>.Instance.poolDict["b"].objectsQueue.Dequeue();

            Assert.AreEqual(new SomeObject().GetType(), actual.GetType());
        }
    }
}