namespace Nxty.Core.Domain.Entities;

public abstract class EntityBase<TKey>
    : IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey Id { get; init; } = default!;
}