using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObservable
    {
        public int data;
        public string data2;

        public event Action<int, string> ObserveEventHandler;

        public ConcreteObservable(int data, string data2)
        {
            this.data = data;
            this.data2 = data2;
        }

        public void CallEvent()
        {
            Console.WriteLine("Observable calling event...");
            ObserveEventHandler?.Invoke(data, data2);
        }
    }
}
