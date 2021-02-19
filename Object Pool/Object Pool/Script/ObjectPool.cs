using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool.Script
{
    public class ObjectPool<T> where T : new()
    {
        #region Singleton
        private static ObjectPool<T> _instance = new ObjectPool<T>();

        public static ObjectPool<T> Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        /// <summary>
        /// only name and size needs in initilize
        /// </summary>
        public struct Pool
        {
            public string name;
            public int size;
            public Queue<T> objectsQueue;
        }

        public Dictionary<string, Pool> poolDict { get; private set; } = new Dictionary<string, Pool>();

        public void InitPool(Pool pool)
        {
            if (!poolDict.ContainsKey(pool.name))
            {
                poolDict.Add(pool.name, pool);

                Pool temp = new Pool() { name = pool.name, size = pool.size, objectsQueue = new Queue<T>() };
                if (poolDict[pool.name].objectsQueue == null)
                    poolDict[pool.name] = temp;

                for (int i = 0; i < pool.size; i++)
                {
                    var obj = new T();
                    poolDict[pool.name].objectsQueue.Enqueue(obj);
                }
            }
        }

        public object GetObjectFromPool(string poolName)
        {
            if (poolDict.ContainsKey(poolName))
            {
                T objToGet;
                if (poolDict[poolName].objectsQueue.Count > 0)
                    objToGet = poolDict[poolName].objectsQueue.Dequeue();
                else
                    objToGet = new T();

                IPoolable poolObj = (IPoolable)objToGet;
                poolObj?.OnSpawn();

                return objToGet;
            }

            return null;
        }

        public void ReturnObjectToPool(string poolName, T obj)
        {
            if (!poolDict.ContainsKey(poolName))
                InitPool(new Pool { name = poolName });

            poolDict[poolName].objectsQueue.Enqueue(obj);
        }


    }
}
