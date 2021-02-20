using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype.Script
{
    [Serializable]
    public class ConcretePrototype : ICloneable
    { 
        private int id;
        private string name;
        public Data data { get; }

        public ConcretePrototype(int id, string name, Data data)
        {
            this.id = id;
            this.name = name;
            this.data = data;
        }

        /// <summary>
        /// 如果有reference type的話用淺層只能複製reference位址, 因此要用deep copy
        /// </summary>
        public T Clone<T>() => (T)this.MemberwiseClone();
    }
}
