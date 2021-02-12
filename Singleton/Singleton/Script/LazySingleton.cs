using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Script
{
    class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get { return InnerClass._instance; }
        }

        class InnerClass
        {
            public static readonly LazySingleton _instance = new LazySingleton();

            private InnerClass()
            {
            }
        }

    }
}
