using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Script
{
    [Serializable]
    public class Data
    {
        public int age;
        public float height;

        public Data(int age, float height)
        {
            this.age = age;
            this.height = height;
        }
    }
}
