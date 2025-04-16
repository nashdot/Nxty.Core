namespace Nxty.Core.Domain.Entities;

public abstract class EntityBase<TKey>
    : IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey Id { get; init; } = default!;

    private readonly List<IDomainEvent> _domainEvents = [];

    public List<IDomainEvent> DomainEvents => [.. _domainEvents];

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}