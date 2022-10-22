namespace ObserverPatternBasicImplementation;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State > 5)
        {
            Console.WriteLine("ConcreteObseverA: reacted to the event");
        }
    }
}
