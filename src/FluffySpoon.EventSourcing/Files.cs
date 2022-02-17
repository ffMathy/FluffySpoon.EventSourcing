namespace FluffySpoon.EventSourcing;

public interface IEvent
{
    public DateTime CreatedUtc { get; set; }
}

// public interface IView
// {
//     
// }

public interface IProjection<in TEvent> where TEvent : IEvent
{
    Task ApplyAsync(TEvent @event);
}

public interface IEventStore
{
    Task PersistEventAsync(IEvent @event);
}