namespace Nxty.Core.Domain.Entities;

/// <summary>
/// Describes an entity.
/// </summary>
public interface IEntity
{
}

/// <summary>
/// Describes an entity.
/// </summary>
/// <typeparam name="TKey">An entity's primary key type.</typeparam>
public interface IEntity<TKey>
    : IEntity
{
}

/// <summary>
/// Describes an entity.
/// </summary>
/// <typeparam name="TKey1">The first entity's composite primary key type.</typeparam>
/// <typeparam name="TKey2">The second entity's composite primary key type.</typeparam>
public interface IEntity<TKey1, TKey2>
    : IEntity<TKey1>
{
}

/// <summary>
/// Describes an entity.
/// </summary>
/// <typeparam name="TKey1">The first entity's composite primary key type.</typeparam>
/// <typeparam name="TKey2">The second entity's composite primary key type.</typeparam>
/// <typeparam name="TKey3">The third entity's composite primary key type.</typeparam>
public interface IEntity<TKey1, TKey2, TKey3>
    : IEntity<TKey1, TKey2>
{
}
