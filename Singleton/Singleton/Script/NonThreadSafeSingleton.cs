using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Script
{
    class NonThreadSafeSingleton
    {
        private NonThreadSafeSingleton()
        {
        }

        private static NonThreadSafeSingleton _instance;

        public static NonThreadSafeSingleton Instance
        {
            get
            {
                //??= 運算子C#8.0才有, 每次都忘記(´・ω・`)
                //_instance ??= new NonThreadSafeSingleton();

                if (_instance == null)
                    _instance = new NonThreadSafeSingleton();

                return _instance;
            }
        }
    }
}
