using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Script
{
    class ThreadSaveDoubleCheckSingleton
    {
        private static ThreadSaveDoubleCheckSingleton _instance;
        private static object _lock = new object();

        public static ThreadSaveDoubleCheckSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new ThreadSaveDoubleCheckSingleton();
                        }
                    }
                }

                return _instance;
            }
        }

        private ThreadSaveDoubleCheckSingleton()
        {
        }
    }
}
