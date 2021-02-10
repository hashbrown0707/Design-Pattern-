using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        private ConcreteObservable observable;
        private string name;

        public ConcreteObserver(ConcreteObservable whatToObserver, string name)
        {
            this.observable = whatToObserver;
            this.name = name;
        }

        public void AddFunction()
        {
            observable.ObserveEventHandler += DoSomething;
        }

        public void RemoveFunction()
        {
            observable.ObserveEventHandler -= DoSomething;
        }

        private void DoSomething(int data, string data2)
        {
            Console.WriteLine($"{name} is doing something with {data} and {data2}.");
        }
    }
}
