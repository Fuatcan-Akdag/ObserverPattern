using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternBasicImplementation
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Atteched and observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Deteched and observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifiying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }


        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I 'm doing something important");
            this.State = new Random().Next(0, 10);
            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to " + this.State);
            this.Notify();
        }
    }
}
