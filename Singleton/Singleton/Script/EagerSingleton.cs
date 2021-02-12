using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Script
{
    class EagerSingleton
    {
        private EagerSingleton()
        {
        }

        private static EagerSingleton _instance = new EagerSingleton();

        public static EagerSingleton Instance
        {
            get { return _instance; }
        }

    }
}
