using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver2 : IObserver
    {
        private ConcreteObservable observable;

        public ConcreteObserver2(ConcreteObservable observable)
        {
            this.observable = observable;
        }

        public void AddFunction()
        {
            observable.ObserveEventHandler += DoSomethingElse;
        }

        public void RemoveFunction()
        {
            observable.ObserveEventHandler -= DoSomethingElse;
        }

        private void DoSomethingElse(int data, string data2)
        {
            Console.WriteLine($"Something else with {data} and {data2}");
        }
    }
}
