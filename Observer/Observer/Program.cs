using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteObservable observable = new ConcreteObservable(1, "string");
            IObserver observer1 = new ConcreteObserver(observable, "Nic");
            IObserver observer2 = new ConcreteObserver(observable, "Marty");

            observer1.AddFunction();
            observer2.AddFunction();
            observable.CallEvent();

            observer1.RemoveFunction();
            observer2.AddFunction();
            observable.CallEvent();

            IObserver concrete2 = new ConcreteObserver2(observable);

            concrete2.AddFunction();
            observable.CallEvent();

            observable.data = 2;
            observable.CallEvent();

            Console.Read();
        }
    }
}
