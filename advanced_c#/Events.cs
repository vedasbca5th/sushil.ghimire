public class EventPublisher
{
    // Define a delegate for the event
    public delegate void MyEventHandler(string message);

    // Define the event based on the delegate
    public event MyEventHandler MyEvent;

    // Method to raise the event
    public void RaiseEvent(string message)
    {
        // Check if there are subscribers to the event
        if (MyEvent != null)
        {
            // Raise the event
            MyEvent(message);
        }
    }
}

public class EventSubscriber
{
    // Event handler method
    public static void HandleEvent(string message)
    {
        Console.WriteLine($"Event handled: {message}");
    }
}

public class EventExample
{
    public static void Main()
    {
        // Create instances of the publisher and subscriber
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();

        // Subscribe to the event
        publisher.MyEvent += new EventPublisher.MyEventHandler(EventSubscriber.HandleEvent);

        // Raise the event
        publisher.RaiseEvent("Hello, Events!");
    }
}
