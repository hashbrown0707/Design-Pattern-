using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype.Script
{
    public static class Utility
    {
        public static T DeepCopy<T>(T obj) where T : class, ICloneable
        {
            using (var memo = new System.IO.MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memo, obj);
                memo.Seek(0, System.IO.SeekOrigin.Begin);
                return formatter.Deserialize(memo) as T;
            }
        }

    }
}
